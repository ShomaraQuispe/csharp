namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz02 = new int[3, 3];
            int somaDiagonalPrincipal = 0, somaDiagonalSecundaria = 0;

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
                {
                    Console.Write($"matriz02[{indiceLinha}, {indiceColuna}] = ");
                    matriz02[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());                 
                }
            }

            Console.Write("Diagonal principal: ");
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                Console.Write($"{matriz02[indiceLinha, indiceLinha]} ");
                somaDiagonalPrincipal += matriz02[indiceLinha, indiceLinha];
            }

            Console.Write("\n\nDiagonal secundária: ");
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                Console.Write($"{matriz02[indiceLinha, (int)(Math.Sqrt(matriz02.Length) - 1 - indiceLinha)]} ");
                somaDiagonalSecundaria += matriz02[indiceLinha, (int)(Math.Sqrt(matriz02.Length) - 1 - indiceLinha)];
            }
            Console.WriteLine($"\n\nSoma da diagonal principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"\nSoma da diagonal secundaria: {somaDiagonalSecundaria}");
        }
    }
}