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
    }
    public static cliente BuscarCliente(int Id)
    {

    }
    public static int CambiarEntrada(int Id, int Tipo, int Cantidad)
    {

    }
    public static List<string> EstadisticasTicketera()
    {

    }
}