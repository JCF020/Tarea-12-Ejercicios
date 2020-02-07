using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Numero Armstrong  del 1 al 500: ");

            int a, b, c, d;
           
            for (int numero = 1; numero <= 500; numero++)
            {
                a = numero / 100;
                b = (numero - a * 100) / 10;
                c = (numero - a * 100 - b * 10);
                d = a * a * a + b * b * b + c * c * c;
                if (numero == d)
                {
                    Console.WriteLine($"{numero}");
                }


            }
            Console.ReadKey();
        }
            
    }
}
