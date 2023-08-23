namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, desconto, salarioLiquido;

            Console.WriteLine("Digite o seu salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite adicional noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Digite as horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite os descontos: ");
            desconto = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras * 5) - desconto;

            Console.WriteLine("O seu salário liquido é: " + salarioLiquido);
        }
    }
}