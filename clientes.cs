class cliente
{
    public int DNI {get;private set;}
    public int TipoEntrada {get;set;}
    public int Cantidad {get;set;}
    public string Apellido {get;private set;}
    public string Nombre {get;private set;}
    public DateTime FechaInscripcion {get;set;}

    const double PRECIO1=45000, PRECIO2=60000, PRECIO3=30000, PRECIO4=100000;

    public cliente (int dni, int tipoEntrada, int cantidad, string apellido, string nombre, DateTime fechainscripcion)
    {
        DNI = dni;
        TipoEntrada = tipoEntrada;
        Cantidad = cantidad;
        Apellido = apellido;
        Nombre = nombre;
        FechaInscripcion = fechainscripcion;
    }
    public double ObtenerImporte (int cantidad,int TipoEntrada)
    {
        double importe;
        if(TipoEntrada == 1)
        {
            importe =PRECIO1*Cantidad;
        }
        else if (TipoEntrada ==2)
        {
            importe =PRECIO2*Cantidad;
        }
        else if (TipoEntrada == 3)
        {
            importe =PRECIO3*Cantidad;
        }
        else
        {
            importe= PRECIO4*Cantidad;
        }

        return importe;

    }
    

    
}