
using System;

namespace TP3POO_DOMINGUEZ_MINUCHIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc = ingresarOpcion();

            switch (opc)
            {
                case 1:   
                int dni = IngresarEntero("Ingrese el dni: ", 0, 100000000); 
                int tipoEntrada= IngresarEntero("Ingrese el tipo de entrada: ", 1, 4); 
                int cantidad = IngresarEntero("Ingrese la cantidad de entradas: ", 0, 6); 
                string apellido = IngresarCadena("Ingrese el apellido: "); 
                string nombre = IngresarCadena("Ingrese su nombre: ");   
                DateTime fechaInscripcion = DateTime.Now;  
                Tiquetera.AgregarCliente(dni, apellido, nombre, fechaInscripcion, tipoEntrada, cantidad); 
               


                break;

                case 2: 
                Console.WriteLine(Tiquetera.EstadisticasTicketera()); 
                break;

                case 3:
                break;

                case 4:
                break;


            }
            
        } 
        static int ingresarOpcion ()
        { int opc; 
            do {
                Console.WriteLine("Ingrese una opción: ");   
                Console.WriteLine(" 1. Nueva Inscripción"); 
                Console.WriteLine(" 2. Obtener Estadísticas del Evento"); 
                Console.WriteLine(" 3. Buscar Cliente");
                Console.WriteLine(" 4. Cambiar entrada de un Cliente "); 
                Console.WriteLine("5. Salir");  
                opc = int.Parse(Console.ReadLine()); 
            }while(opc < 1 || opc > 5);

            return opc;
           
        } 
        static int IngresarEntero(string txt, int tope1, int tope2) 
        { 
            int num;  
            do {
            Console.WriteLine(txt); 
            num = int.Parse(Console.ReadLine());  
            }while (num < tope1 || num > tope2); 
            return num ;
        }
        static string IngresarCadena(string txt)
        {
            Console.WriteLine(txt);
            return Console.ReadLine();
        }
    }
}
