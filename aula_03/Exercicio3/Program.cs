namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade;
            string? nome, inputDoou;
            bool doou;

            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18 && idade <= 59)
            {
                Console.WriteLine($"Olá, {nome}! Você está apto para doar!");
            }
            else if (idade >= 60 && idade <= 69)
            {
                Console.WriteLine("Você já doou antes? Digite [1] para Sim | Digite [2] para Não");
                inputDoou = Console.ReadLine();

                if (inputDoou.Equals("1") || inputDoou.Equals("2"))
                {
                    doou = inputDoou.Equals("1");

                    if (doou)
                    {
                        Console.WriteLine($"Olá, {nome}! Você está apto para doar!");
                    }
                    else
                    {
                        Console.WriteLine($"Olá, {nome}! Você não está apto para doar!");
                    }

                }
                else
                {
                    Console.WriteLine("Você digitou um valor inválido!");
                }


            }
            else
                Console.WriteLine($"Olá, {nome}! Você não está apto(a) para doar!");

        }
    }
}