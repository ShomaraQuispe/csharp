namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, contador;
            bool eMultiploDe5e3;

            Console.WriteLine("Digite o primeiro número do intervalo:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o último número do intervalo:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                for (contador = numero1; contador <= numero2; contador++)
                {
                    eMultiploDe5e3 = contador % 3 == 0 && contador % 5 == 0;
                    if (eMultiploDe5e3 == true && contador != 0)
                    {
                        Console.WriteLine($"{contador} é múltiplo de 3 e 5");
                    }
                }
            }
            else
            {
                Console.WriteLine("Intervalo inválido!");
            }
        }
    }
}