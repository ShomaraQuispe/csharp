namespace Exercicio3_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> listaNumeros = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                listaNumeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var numero in listaNumeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}