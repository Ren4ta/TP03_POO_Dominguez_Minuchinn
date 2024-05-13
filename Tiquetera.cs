static class Tiquetera 
{
    private static int UltimoIDEntrada = 0; 
    static int id = 0; 
    private static Dictionary<int, cliente> DicClientes = new Dictionary<int,cliente>();
    public static int DevolverUltimoID() 
    {
        return; 
    } 
    public static int AgregarCliente(int dni, string apellido, string nombre, DateTime fechaInscripcion, int tipoEntrada, int cantidad) 
    {
        cliente Cliente = new cliente(dni, tipoEntrada, cantidad, apellido, nombre, fechaInscripcion);
        id++;  
        DicClientes.Add(id,Cliente); 
        return id;
    }
    public static cliente BuscarCliente(int Id)
    {

    }
    public static int CambiarEntrada(int Id, int Tipo, int Cantidad)
    {

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
            int cantT1=0,cantT2=0,cantT3=0,cantT4=0;

            estadisticas.Add("La cantidad de clientes inscriptos es: "+totalClientes);
            foreach (int valor in DicClientes.Keys) 
            {
                if (DicClientes[valor].TipoEntrada == 1)
                {
                    cantT1+= DicClientes[valor].Cantidad;
                    recaudacionT1 += DicClientes[valor].ObtenerImporte();

                }
                else if (DicClientes[valor].TipoEntrada == 2)
                {
                    cantT2+= DicClientes[valor].Cantidad;
                    recaudacionT2 += DicClientes[valor].ObtenerImporte();

                }if (DicClientes[valor].TipoEntrada == 3)
                {
                    cantT3+= DicClientes[valor].Cantidad;
                    recaudacionT3 += DicClientes[valor].ObtenerImporte();

                }
                else 
                {
                    cantT4+= DicClientes[valor].Cantidad;
                    recaudacionT4 += DicClientes[valor].ObtenerImporte();

                }
                recaudacionTotal+= DicClientes[valor].ObtenerImporte();
                
            }
            int cantTotal = cantT1 + cantT2 + cantT3 + cantT4;
            double porcentajeT1 =  (cantT1/cantTotal)*100;
            double porcentajeT2 =  (cantT2/cantTotal)*100;
            double porcentajeT3 =  (cantT3/cantTotal)*100;
            double porcentajeT4 =  (cantT4/cantTotal)*100;

            estadisticas.Add("La cantidad de clientes que compraron Opcion 1 es: "+cantT1);
            estadisticas.Add("La cantidad de clientes que compraron Opcion 2 es: "+cantT2);
            estadisticas.Add("La cantidad de clientes que compraron Opcion 3 es: "+cantT3);
            estadisticas.Add("La cantidad de clientes que compraron Opcion 4 es: "+cantT4);
            estadisticas.Add("El porcentaje de entradas Tipo 1: "+porcentajeT1+"%");
            estadisticas.Add("El porcentaje de entradas Tipo 2: "+porcentajeT2+"%");
            estadisticas.Add("El porcentaje de entradas Tipo 3: "+porcentajeT3+"%");
            estadisticas.Add("El porcentaje de entradas Tipo 4: "+porcentajeT4+"%");
            estadisticas.Add("La recaudación del tipo 1 es: $"+recaudacionT1);
            estadisticas.Add("La recaudación del tipo 2 es: $"+recaudacionT2);
            estadisticas.Add("La recaudación del tipo 3 es: $"+recaudacionT3);
            estadisticas.Add("La recaudación del tipo 4 es: $"+recaudacionT4);
            estadisticas.Add("La recaudación total es: $"+recaudacionTotal);

            return estadisticas;
        }

    }
}