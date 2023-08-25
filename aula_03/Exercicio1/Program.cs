namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, soma;

            Console.WriteLine("Digite um número A");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um número B");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite um número C");
            n3= Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;

            if (soma > n3)
            {
                Console.WriteLine("A Soma de A + B é Maior do que C");
            }
            else if (soma < n3)
            {
                Console.WriteLine("A Soma de A + B é Menor do que C");
            }
            else
            {
                Console.WriteLine("A Soma de A + B é Igual a C");
            }

        }
    }
}