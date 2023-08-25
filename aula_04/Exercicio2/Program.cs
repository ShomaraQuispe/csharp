using System.Runtime.CompilerServices;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, par = 0, impar = 0;

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"Digite o numero {contador}: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

            }

            Console.WriteLine($"Total de números pares: {par} ");
            Console.WriteLine($"Total de números impares: {impar} ");

        }
    }
}