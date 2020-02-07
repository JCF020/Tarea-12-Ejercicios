using System;

namespace SumaNumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double contador = 0;
            for(int i = 0; i <= numero; i++)
            {
                if((i % 2) != 0)
                {
                    contador = contador+i;
                }
            }
            Console.WriteLine("Sumatoria de los impares, del numero " + numero + " es: " + contador);
        }
    }
}
