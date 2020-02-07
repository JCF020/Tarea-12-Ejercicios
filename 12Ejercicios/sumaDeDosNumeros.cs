using System;

namespace SumaDeDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string condicion = "";
            do {
                Console.WriteLine("Introduzca el primer numero: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Introduzca el segundo numero: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double suma = num1 + num2;

                Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + suma);

                Console.WriteLine("Desea repetir la operación otra vez, presione una (S)");
                 condicion = Console.ReadLine();

            } while (condicion=="S" || condicion=="s");
            
            Console.ReadKey();
        }
    }
}
