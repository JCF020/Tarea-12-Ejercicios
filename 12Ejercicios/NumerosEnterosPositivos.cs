using System;

namespace numeroEnteroPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero entero positivo: ");
            int numero=Convert.ToInt32(Console.ReadLine());

            int[] impares;
            impares = new int[100000];
            string nose="";
            
            for (int i = 1; i <= numero; i++)
            {
                if ((i % 2) != 0) { 
                    impares[i] = i;
                    nose += Convert.ToString(impares[i])+", ";
                    
                }
                
            }
            Console.WriteLine(nose);
        }
    }
}
