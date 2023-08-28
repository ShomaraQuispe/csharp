namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz02 = new int[3, 3];
            int somaDiagonalPrincipal, somaDiagonalSecundaria;

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
                {
                    Console.Write($"matriz02[{indiceLinha}, {indiceColuna}] = ");
                    matriz02[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());                 
                }
            }

            Console.WriteLine("Diagonal principal: ");
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                Console.Write($"{matriz02[indiceLinha, indiceLinha]} ");
            }

            Console.WriteLine("\n\nDiagonal secundária: ");
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                Console.Write($"{matriz02[indiceLinha, 3 - 1 - indiceLinha]} ");
            }

            somaDiagonalPrincipal = matriz02[0,0] + matriz02[1, 1] + matriz02[2, 2];
            somaDiagonalSecundaria = matriz02[2,0] + matriz02[1, 1] + matriz02[0, 2];
            Console.WriteLine($"\nSoma dos elementos da Diagonal principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"\nSoma dos elementos da Diagonal segundaria:{somaDiagonalSecundaria}");
        }
    }
}