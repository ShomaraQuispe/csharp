namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, total;
            int operacao;
            string nomeOperacao;

            Console.WriteLine("Digite um dos números abaixo para realizar a operação que deseja:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            operacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            numero2 = Convert.ToSingle(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    total = numero1 + numero2;
                    nomeOperacao = "soma";
                    break;
                case 2:
                    total = numero1 - numero2;
                    nomeOperacao = "subtração";
                    break;
                case 3:
                    total = numero1 * numero2;
                    nomeOperacao = "multiplicação";
                    break;
                default:
                    total = numero1 / numero2;
                    nomeOperacao = "divisão";
                    break;

            }
            Console.WriteLine($"A {nomeOperacao} do primeiro e segundo número é {total}");

        }
    }
}