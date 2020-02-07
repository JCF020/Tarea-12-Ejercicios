using System;

namespace palidromas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra1 = "";
            string  palabra2 = "";
            string le = "";
            int i = 0, tl = 0;
            Console.Write("Ingrese una palabra: ");
            palabra1 = Console.ReadLine();
            tl = palabra1.Length;
            for (i = tl - 1; i >= 0; i--)
            {
                le = palabra1.Substring(i, 1);
                palabra2 = palabra2 + le;
            }

            
            if (palabra1.Equals(palabra2))
            {
                Console.WriteLine("La palabras es Palindroma: "+palabra2);
            }
            else
            {
                Console.WriteLine("No es palindroma :"+palabra2);
            }

            Console.ReadKey();
        }
    }
}
