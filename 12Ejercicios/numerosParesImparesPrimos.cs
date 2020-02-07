using System;

namespace NumerosParesImparesPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            double impar = 0;
            for (int i = 0; i <= numero; i++)
            {
                if ((i % 2) != 0)
                {
                    impar = impar + i;
                }
            }
            Console.WriteLine("Sumatoria de los numeros impares, del numero " + numero + " es: " + impar);

            double pares = 0;
            for (int i = 0; i <= numero; i++)
            {
                if ((i % 2) == 0)
                {
                    pares = pares + i;
                }
            }
            Console.WriteLine("Sumatoria de los numeros pares, del numero " + numero + " es: " + pares);

            int num = 1, resto, divisor, salirWhile, contador = 0;
            int primos = 0;
            
            while (contador < numero)
            {
                divisor = 2; salirWhile = 0;

                while ((divisor < num) & (salirWhile == 0))
                {
                    resto = num % divisor;

                    if (resto == 0)
                    {
                        salirWhile = 1;
                    }
                    else
                    {
                        divisor = divisor + 1;
                    }
                }
                if (num <= numero) {
                    primos += num;
                    contador = contador + 1;
                }
                num = num + 1;
            }
            Console.Write("Sumatoria de los numeros primos, del numero " + numero + " es: " + primos);
            Console.WriteLine();
        }
    }
}
