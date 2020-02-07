using System;

namespace CuentaAtras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int[] impares;
            impares = new int[100000];
            string nose = "";
            int contador = 0;
            while(numero>=0)
            {
                    impares[contador] = numero;
                    nose += Convert.ToString(impares[contador]) + ", ";

                contador++;
                numero--;
            }
            Console.WriteLine(nose);
            Console.ReadKey();
        }
    }
}
