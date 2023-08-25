namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float saldo = 1000, novoSaldo;
            int operacao;
            string? nome, nomeOperacao;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Bem-vindo(a) ao nosso banco! Digite um dos números abaixo de acordo com o serviço que deseja");
            Console.WriteLine("1 - SALDO");
            Console.WriteLine("2 - SAQUE");
            Console.WriteLine("3 - DEPOSITO");
            operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 1)
            {
                novoSaldo = saldo;
            }

            else if (operacao == 2 || operacao == 3)
            {
                Console.WriteLine("Digite o valor");
                novoSaldo = Convert.ToSingle(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Operação Inválida");
            }

            switch (operacao)
            {
                case 1:
                    novoSaldo = saldo;
                    nomeOperacao = "SALDO";
                    break;
                case 2:
                    saldo = 1000 - novoSaldo;
                    nomeOperacao = "SAQUE";
                    break;
                default:
                    saldo = 1000 + novoSaldo;
                    nomeOperacao = "DEPOSITO";
                    break;
            }
            Console.WriteLine($"{nome}, segue abaixo sua solicitação!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Operação solicitada: {nomeOperacao}");
            Console.WriteLine($"O seu saldo atual é de R${novoSaldo}");
        }
    }
}