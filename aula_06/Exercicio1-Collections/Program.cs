namespace Exercicio1_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite uma cor: ");
                cores.Add(Console.ReadLine());
            }

            foreach (var cor in cores)
            {
                Console.WriteLine(cor);
            }

            Console.WriteLine(" ");
            cores.Sort();

            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

        }
    }
}