using System;

namespace TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el numero de la cual desea la tabla de multiplicación: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine(numero + " X " + i + " = " + (numero * i));
            }

            Console.ReadKey();
        }
    }
}
