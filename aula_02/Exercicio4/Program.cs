namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, valorDiferenca;

            Console.WriteLine("Digite o valor do produto 1: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 2: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 3: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do produto 4: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            valorDiferenca = (n1 * n2) - (n3 * n4);

            Console.WriteLine(valorDiferenca);

        }
    }
}