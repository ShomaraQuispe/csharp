namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, somaDeMultiplosDe3 = 0;
            float quantidadeNumeroMultiplosDe3 = 0.0f;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 3 == 0 && numero != 0)
                {
                    somaDeMultiplosDe3 += numero;
                    quantidadeNumeroMultiplosDe3++;
                }

            } while (numero != 0);

            

            Console.WriteLine($"A média de todos os números múltiplos de 3 é {somaDeMultiplosDe3 / quantidadeNumeroMultiplosDe3}");
        }
    }
}