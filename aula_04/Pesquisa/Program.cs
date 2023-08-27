namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, continua = "S";
            int idade, esporte, futebol = 0, voleimai18 = 0, basquetemen18 = 0;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o seu esporte favorito (1- Futebol/2-Volei/3-Basquete/4-Outros): ");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;

                if (esporte == 2 && idade > 18)
                    voleimai18++;

                if (esporte == 3 && idade < 18)
                    basquetemen18++;

                Console.WriteLine("Deseja continuar (S/N): ");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S"));

            Console.WriteLine($"Total de pessoas que gostam de Futebol: {futebol}");
            Console.WriteLine($"Total de pessoas que gostam de Volei maiores de 18 anos: {voleimai18}");
            Console.WriteLine($"Total de pessoas que gostam de Basquete menores de 18 anos: {basquetemen18}");

        }
    }
}