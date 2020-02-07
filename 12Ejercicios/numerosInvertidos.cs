using System;

namespace numerosInvertidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir numero:");
            

            char[] array = Console.ReadLine().ToCharArray();

            Array.Reverse(array);

            string numero = new string(array);

            Console.WriteLine(numero);
        }
    }
}
