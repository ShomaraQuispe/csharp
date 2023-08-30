namespace Exercicio4_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> lista = new HashSet<int>() { 2,5,1,3,4,9,7,8,10,6};
            int numeroSolicitado;

            Console.WriteLine("Digite o número que você deseja encontrar:");
            numeroSolicitado = Convert.ToInt32(Console.ReadLine());

            if (lista.Contains(numeroSolicitado))
            {
                Console.WriteLine($"O número {numeroSolicitado} foi encontrado!");
            }
            else
                Console.WriteLine($"O número {numeroSolicitado} não foi encontrado!");
        }
    }
}