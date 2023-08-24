namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  pedido;
            float quantidade, valorTotal;
            string nomeProduto;

            Console.WriteLine("Digite o código do pedido:");
            Console.WriteLine("1 - Cachorro Quente");
            Console.WriteLine("2 - X-Salada");
            Console.WriteLine("3 - X-Bacon");
            Console.WriteLine("4 - Bauro");
            Console.WriteLine("5 - Refrigerante");
            Console.WriteLine("6 - Suco de Laranja");


            Console.WriteLine("Digite o seu pedido: ");
            pedido = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade do pedido: ");
            quantidade = Convert.ToSingle(Console.ReadLine());

            switch (pedido)
            {
                case 1:
                    valorTotal = (10f * quantidade);
                    nomeProduto = "Cachorro Quente";
                    break;
                case 2:
                    valorTotal = (15f * quantidade);
                    nomeProduto = "X-Salada";
                    break;
                case 3:
                    valorTotal = (18f * quantidade);
                    nomeProduto = "X-Bacon";
                    break;
                case 4:
                    valorTotal = (12f * quantidade);
                    nomeProduto = "Bauru";
                    break;
                case 5:
                    valorTotal = (8f * quantidade);
                    nomeProduto = "Refrigerante";
                    break;
                default:
                    valorTotal = (13f * quantidade);
                    nomeProduto = "Suco de laranja";
                    break;

            }
            Console.WriteLine($"O seu pedido, {nomeProduto} deu no total de R${valorTotal}");

        }
    }
}