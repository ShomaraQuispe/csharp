namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int procurarNumero;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            procurarNumero = Convert.ToInt32(Console.ReadLine());

            for (int indice = 0; indice < vetor1.Length; indice++)
            {
                if (procurarNumero == vetor1[indice])
                {
                    Console.WriteLine($"O número {vetor1[indice]} está localizado na posição: [{indice}]");
                }
            }

            if (procurarNumero > 10 || procurarNumero < 0)
            {
                Console.WriteLine($"O número {procurarNumero} não foi encontrado");
            }
        }
    }
}