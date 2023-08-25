namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, rest = 0;

            do
            {
                Console.WriteLine("Escreva o número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 > 0)
                {
                    rest += num1;
                }

            } while (num1 != 0);

            Console.WriteLine($"{rest}");

        }
    }
}