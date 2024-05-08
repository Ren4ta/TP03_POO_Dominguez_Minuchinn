class cliente
{
    public int DNI {get;private set;}
    public int TipoEntrada {get;set;}
    public double Cantidad {get;set;}
    public string Apellido {get;private set;}
    public string Nombre {get;private set;}
    public DateTime FechaInscripcion {get;set;}

    public cliente (int dni, int tipoEntrada, double cantidad, string apellido, string nombre, DateTime fechainscripcion)
    {
        DNI = dni;
        TipoEntrada = tipoEntrada;
        Cantidad = cantidad;
        Apellido = apellido;
        Nombre = nombre;
        FechaInscripcion = fechainscripcion;
    }
}