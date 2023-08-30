namespace Exercicio2_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroSolicitado, numeroEncontrado;
            List<int> lista = new List<int>() {2,5,1,3,4,9,7,10,6};
           
            Console.WriteLine("Digite o número que você deseja encontrar:");
            numeroSolicitado = Convert.ToInt32(Console.ReadLine());
            numeroEncontrado = lista.IndexOf(numeroSolicitado);

            if (numeroEncontrado >= 0)
                Console.WriteLine($"Posição do número {numeroSolicitado} é: " + lista.IndexOf(numeroSolicitado));
            else Console.WriteLine($"O numero {numeroSolicitado} não foi encontrado.");
        }
    }
}