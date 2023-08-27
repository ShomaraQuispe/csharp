namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float saldo = 1000, valorDaOperacao=0;
            int operacao;
            string? nome, nomeOperacao;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Bem-vindo(a) ao nosso banco! Digite um dos números abaixo de acordo com o serviço que deseja");
            Console.WriteLine("1 - SALDO");
            Console.WriteLine("2 - SAQUE");
            Console.WriteLine("3 - DEPOSITO");
            operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    valorDaOperacao = saldo;
                    nomeOperacao = "SALDO";
                    break;
                case 2:
                    Console.WriteLine("Digite um valor que deseja sacar:");
                    valorDaOperacao = Convert.ToSingle(Console.ReadLine());
                    if ((valorDaOperacao <= saldo) && (valorDaOperacao > 0))
                    {
                        saldo = 1000 - valorDaOperacao;
                        nomeOperacao = "SAQUE CONCLUÍDO COM SUCESSO";
                    }
                    else
                        nomeOperacao = "SALDO INSUFICIENTE OU VALOR INVÁLIDO";
                    break;
                case 3:
                    Console.WriteLine("Digite um valor que deseja depositar:");
                    valorDaOperacao = Convert.ToSingle(Console.ReadLine());
                    if (valorDaOperacao > 0)
                    {
                    saldo = 1000 + valorDaOperacao;
                    nomeOperacao = "DEPOSITO";
                    }
                    else
                        nomeOperacao = "SALDO INSUFICIENTE OU VALOR INVÁLIDO";
                    break;
                default:
                    nomeOperacao = "OPERAÇÃO INVÁLIDA";
                    break;
            }
            Console.WriteLine($"{nome}, segue abaixo sua solicitação!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Status da operação solicitada: {nomeOperacao}");
            Console.WriteLine($"O seu saldo atual é de R${saldo}");
        }
    }
}