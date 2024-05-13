static class Tiquetera 
{
    private static int UltimoIDEntrada = 0; 
    static int id = 0; 
    
    private static Dictionary<int, cliente> DicClientes = new Dictionary<int,cliente>();
    public static int DevolverUltimoID() 
    {   

        return UltimoIDEntrada++; 
    } 
    public static int AgregarCliente(int dni, string apellido, string nombre, DateTime fechaInscripcion, int tipoEntrada, int cantidad) 
    {
        cliente Cliente = new cliente(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);
        id = DevolverUltimoID();  
        DicClientes.Add(id,Cliente); 
        return id;
    }
    public static void BuscarCliente(int Id)
    {
        if (DicClientes[id] != null) 
        {
           Console.WriteLine(DicClientes[id].Apellido);  
            Console.WriteLine (DicClientes[id].Nombre); 
            Console.WriteLine(DicClientes[id].TipoEntrada); 
           Console.WriteLine(DicClientes[id].FechaInscripcion.ToShortDateString()); 
           Console.WriteLine(DicClientes[id].Cantidad); 
           Console.WriteLine( DicClientes[id].DNI); 
            
        } 
        else {
            Console.WriteLine("No se encontró el id"); 
        }
    }
    public static void CambiarEntrada(int Id, int Tipo, int Cantidad)
    {
        double nuevoImporte=0; 
        
        if(DicClientes[Id]!= null)
        {
            nuevoImporte = DicClientes[id].ObtenerImporte(Cantidad,Tipo);
            double viejoImporte= DicClientes[id].ObtenerImporte(DicClientes[id].Cantidad,DicClientes[id].TipoEntrada);
            if (nuevoImporte > viejoImporte )
            {
                DicClientes[id].TipoEntrada = Tipo;
                DicClientes[id].Cantidad = Cantidad; 
                Console.WriteLine("Se pudo hacer el cambio.El nuevo importe a cambiar es: $"+ (nuevoImporte-viejoImporte));
                
            } 
            else 
            {
                Console.WriteLine("No se pudo cambiar los datos");
            }

        }  
         else {
            Console.WriteLine("No se encontró el id"); 
        }
        
    }
    public static List<string> EstadisticasTicketera()
    {
        List<string> estadisticas = new List<string>(); 
        if(DicClientes == null)
        {
            estadisticas.Add("Aún no se anotó nadie"); 
        } 
        else {  
            int totalClientes = DicClientes.Count;
            double recaudacionTotal=0, recaudacionT1=0, recaudacionT2=0, recaudacionT3=0, recaudacionT4=0;
            int cantT1=0,cantT2=0,cantT3=0,cantT4=0,clientesT1=0,clientesT2=0, clientesT3=0, clientesT4=0;

            estadisticas.Add("La cantidad de clientes inscriptos es: "+totalClientes);
            foreach (int valor in DicClientes.Keys) 
            {
                if (DicClientes[valor].TipoEntrada == 1)
                {
                    cantT1+= DicClientes[valor].Cantidad;
                    recaudacionT1 += DicClientes[valor].ObtenerImporte(DicClientes[valor].Cantidad, DicClientes[valor].TipoEntrada);
                    clientesT1++;

                }
                else if (DicClientes[valor].TipoEntrada == 2)
                {
                    cantT2+= DicClientes[valor].Cantidad;
                    recaudacionT2 += DicClientes[valor].ObtenerImporte(DicClientes[valor].Cantidad, DicClientes[valor].TipoEntrada);
                    clientesT2++;

                }
                else if (DicClientes[valor].TipoEntrada == 3)
                {
                    cantT3+= DicClientes[valor].Cantidad;
                    recaudacionT3 += DicClientes[valor].ObtenerImporte(DicClientes[valor].Cantidad, DicClientes[valor].TipoEntrada);
                    clientesT3++;

                }
                else 
                {
                    cantT4+= DicClientes[valor].Cantidad;
                    recaudacionT4 += DicClientes[valor].ObtenerImporte(DicClientes[valor].Cantidad, DicClientes[valor].TipoEntrada);
                    clientesT4++;

                }
                recaudacionTotal+= DicClientes[valor].ObtenerImporte(DicClientes[valor].Cantidad, DicClientes[valor].TipoEntrada);
                
            }
            int cantTotal = cantT1 + cantT2 + cantT3 + cantT4;
            double porcentajeT1 =  (cantT1*100/cantTotal);
            double porcentajeT2 =   (cantT2*100/cantTotal);
            double porcentajeT3 =  (cantT3*100/cantTotal);
            double porcentajeT4 =  (cantT4*100/cantTotal);

            estadisticas.Add("La cantidad de clientes que compraron Opcion 1 es: "+clientesT1);
            estadisticas.Add("La cantidad de clientes que compraron Opcion 2 es: "+clientesT2);
            estadisticas.Add("La cantidad de clientes que compraron Opcion 3 es: "+clientesT3);
            estadisticas.Add("La cantidad de clientes que compraron Opcion 4 es: "+clientesT4);
            estadisticas.Add("El porcentaje de entradas Tipo 1: "+porcentajeT1+"%");
            estadisticas.Add("El porcentaje de entradas Tipo 2: "+porcentajeT2+"%");
            estadisticas.Add("El porcentaje de entradas Tipo 3: "+porcentajeT3+"%");
            estadisticas.Add("El porcentaje de entradas Tipo 4: "+porcentajeT4+"%");
            estadisticas.Add("La recaudación del tipo 1 es: $"+recaudacionT1);
            estadisticas.Add("La recaudación del tipo 2 es: $"+recaudacionT2);
            estadisticas.Add("La recaudación del tipo 3 es: $"+recaudacionT3);
            estadisticas.Add("La recaudación del tipo 4 es: $"+recaudacionT4);
            estadisticas.Add("La recaudación total es: $"+recaudacionTotal);

           
        }
        return estadisticas;
    }
}