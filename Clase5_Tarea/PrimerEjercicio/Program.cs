using System;

namespace PrimerEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Hola, si quiere continuar ingrese: (S/N)");
            string respuesta = Console.ReadLine();

            respuesta = "S";
            int contador = 0;

            while(respuesta.ToUpper()!="N")
            {
                contador++;
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();

                Console.WriteLine($"¡Hola {nombre}!");
                Console.ReadKey();

                Console.WriteLine("Quiere continuar (S/N)");
                respuesta = Console.ReadLine();                
            }
            
            if (respuesta.ToUpper()!="S")
            {
                Console.WriteLine("Programa finalizado correctamente");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
            Console.ReadKey();

        }
    }
}
