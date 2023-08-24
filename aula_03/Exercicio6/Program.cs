namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, emprego;
            float salario, novoSalario;
            int cargo;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - cargo de Gerente");
            Console.WriteLine("2 - cargo de Vendedor");
            Console.WriteLine("3 - cargo de Supervisor");
            Console.WriteLine("4 - cargo Motorista");
            Console.WriteLine("5 - cargo Estoquista");
            Console.WriteLine("6 - cargo Técnico de TI");

            Console.WriteLine("Digite o número do seu cargo:");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToInt32(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    novoSalario = (salario * 10) / 100;
                    emprego = "Gerente";
                    break;
                case 2:
                    novoSalario = (salario * 7) / 100;
                    emprego = "Vendedor";
                    break;
                case 3:
                    novoSalario = (salario * 9) / 100;
                    emprego = "Supervisor";
                    break;
                case 4:
                    novoSalario = (salario * 6) / 100;
                    emprego = "Motorista";
                    break;
                case 5:
                    novoSalario = (salario * 5) / 100;
                    emprego = "Estoquista";
                    break;
                default:
                    novoSalario = (salario * 8) / 100;
                    emprego = "Técnico de TI";
                    break;
            }

            Console.WriteLine($"O novo Salário do(a) {nome}, com cargo de {emprego} é de R${novoSalario+salario}");
        }
    }
}