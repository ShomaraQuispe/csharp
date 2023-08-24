namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, divisao;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            divisao = numero1 / numero2;

            Console.WriteLine(numero1 + " " + numero2);
            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));//interpolação de string
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));
            Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2));
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            if (numero2 > 0)
             Console.WriteLine("{0:F} / {1:F} = {2:F2}", numero1, numero2, divisao);
            else
             Console.WriteLine("Não existe divisão por zero");
        }
    }
}