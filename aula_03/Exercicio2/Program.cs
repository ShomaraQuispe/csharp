namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string positivoNegativo, parImpar;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            /*if (numero % 2 == 00) 
            {
                Console.WriteLine("O número digitado é PAR e ");
            }

            else
            {
                Console.WriteLine("O número digitado é IMPAR e");
            }

            Console.Write((numero >= 0) ? "POSITIVO." : "NEGATIVO");

            */

            if (numero % 2 == 00)
            {
                positivoNegativo = "PAR";
            }
            else
            {
                positivoNegativo = "ÍMPAR";
            }

            if (numero >= 0)
            {
                parImpar = "POSITIVO";
            }
            else
            {
                parImpar = "NEGATIVO";
            }

            Console.WriteLine($"O número {numero} é {positivoNegativo} e {parImpar}");


        }
    }
}