namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 1; // para Do While não precisa adicionar um valor incial
            int menores21Anos = 0, maiores50Anos = 0;

            while (idade > 0)
            {
                Console.WriteLine("Digite sua idade");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 21 && idade > 0)
                {
                    menores21Anos++;
                }

                if (idade > 50 )
                {
                    maiores50Anos++;
                }
            }
            Console.WriteLine($"Total de pessoas menores de 21 anos: {menores21Anos} \nTotal de pessoas maiores de 50 anos: {maiores50Anos}");



            /*do
            {
                Console.WriteLine("Digite sua idade");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{idade}");

            } while (idade > 0);*/

        }
    }
}