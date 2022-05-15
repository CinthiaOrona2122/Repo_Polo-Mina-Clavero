using System;

namespace NumeroRandom
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 5);
            int contador = 0;

            Console.WriteLine("Hola, ingresa un numero: ");
            int numeroIngresado = Convert.ToInt32(Console.ReadLine());



            while (numeroIngresado != numeroSecreto)
            {
                Console.WriteLine("Intenta otro numero");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());

                if (numeroIngresado > numeroSecreto)
                {
                    Console.WriteLine("Oops!! el numero ingresado es mayor al secreto");
                }
                else
                {
                    Console.WriteLine("Oops!! el numero ingresado es menor al secreto");
                }
            }

            if (numeroIngresado == numeroSecreto)
            {
                Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:  {numeroSecreto}");
                Console.WriteLine($"Lo has logrado en {contador} intentos!!");
            }
            Console.ReadKey();
        }

    }
}

