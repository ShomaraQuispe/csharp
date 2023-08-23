namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o seu abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = abono + salario;
            Console.WriteLine("Seu novo salário é: " + novoSalario);


        }
    }
}