namespace Tabuada_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador = 11;

            Console.Write("Digite a tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                contador++;
            }

        }
    }
}