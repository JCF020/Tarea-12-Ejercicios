using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir un numero: ");
            Double numero = Convert.ToDouble(Console.ReadLine());

            int fubonacci = 0;
            int contador = 1;
            int cambio;

            for(int i = 0; i <= numero; i++)
            {
                cambio = fubonacci;
                fubonacci = contador;
                contador = cambio + fubonacci; 
                Console.WriteLine(fubonacci);
            }
        }
    }
}
