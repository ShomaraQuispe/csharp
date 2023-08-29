using System.Data;

namespace Exercicio1_Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int servicoSolicitado;
            Queue<string> nomeDoCliente = new Queue<string>();

            do
            {
                Console.WriteLine("\n***************************************************");
                Console.WriteLine("\n    1: Adicionar um novo Cliente na fila. ");
                Console.WriteLine("\n    2: Listar todos os Clientes na fila");
                Console.WriteLine("\n    3: Chamar (retirar) uma pessoa da fila");
                Console.WriteLine("\n    0: Para finalizar");
                Console.WriteLine("\n***************************************************");
                Console.WriteLine("\n    Entre com a opção desejada:");
                servicoSolicitado = Convert.ToInt32(Console.ReadLine());

                if (servicoSolicitado == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Digite o nome do novo cliente: ");
                    nomeDoCliente.Enqueue(Console.ReadLine());
                    Console.WriteLine("\nCliente adicionado!");
                }

                if (servicoSolicitado == 2)
                {
                    if (nomeDoCliente.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A Fila está vazia!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Lista de Clientes na fila: ");
                        foreach (var nome in nomeDoCliente)
                        {
                            Console.WriteLine($"{nome}");
                        }
                        Console.WriteLine("\nNumero de pessoas na fila: " + nomeDoCliente.Count);
                    }
                }
                if (servicoSolicitado == 3)
                {
                    if (nomeDoCliente.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A Fila está vazia!");
                    }
                    else
                    {
                        Console.Clear();
                        nomeDoCliente.Dequeue();
                        Console.WriteLine("O Cliente foi Chamado!");
                    }
                }

            } while (servicoSolicitado > 0 && servicoSolicitado < 5);
        }
    }
}