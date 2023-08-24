namespace Rh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            float salario, reajuste;
            int cargo;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - cargo de Supervisor");
            Console.WriteLine("2 - cargo de Diretor");
            Console.WriteLine("3 - cargo de Gerente");
            Console.WriteLine("4 - outros cargos");

            Console.WriteLine("Digite o seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToInt32(Console.ReadLine());

            switch (cargo)
            {
                case 1: 
                    reajuste = (salario * 7) / 100;
                    break;
                case 2:
                    reajuste = (salario * 9) / 100;
                    break;
                case 3:
                    reajuste = (salario * 5) / 100;
                    break;
                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }

            Console.WriteLine($"O reajuste do Salário do(a) {nome} é de: {reajuste}");
            Console.WriteLine($"O novo o Salário do(a) {nome} é de: {salario + reajuste}");
        }
    }
}