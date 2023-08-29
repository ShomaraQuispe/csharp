namespace Exercicio2_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int servicoSolicitado;
            Stack<string> nomeDoLivro = new Stack<string>();

            do
            {
                Console.WriteLine("\n***************************************************");
                Console.WriteLine("\n    1: Adicionar um novo livro na pilha.");
                Console.WriteLine("\n    2: Listar todos os livros da Pilha");
                Console.WriteLine("\n    3: Retirar um livro da pilha");
                Console.WriteLine("\n    0: Para finalizar");
                Console.WriteLine("\n***************************************************");
                Console.WriteLine("\n    Entre com a opção desejada:");
                servicoSolicitado = Convert.ToInt32(Console.ReadLine());

                if (servicoSolicitado == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Adicione o nome do novo livro: ");
                    nomeDoLivro.Push(Console.ReadLine());
                    Console.WriteLine("\nLivro adicionado!");
                }

                if (servicoSolicitado == 2)
                {
                    if (nomeDoLivro.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A Pilha está vazia!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Lista de Livros na Pilha: ");
                        foreach (var nome in nomeDoLivro)
                        {
                            Console.WriteLine($"{nome}");
                        }
                        Console.WriteLine("\nNumero de Livros na pilha: " + nomeDoLivro.Count);
                    }
                }
                if (servicoSolicitado == 3)
                {
                    if (nomeDoLivro.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("A Pilha está vazia!");
                    }
                    else
                    {
                        Console.Clear();
                        nomeDoLivro.Pop();
                        Console.WriteLine("Livros na pilha:");
                        foreach (var livro in nomeDoLivro)
                        {
                            Console.WriteLine(livro);
                        }
                        Console.WriteLine("\nUm Livro foi retirado da pilha!");
                    }
                }
                if (servicoSolicitado == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Programa Finalizado!");
                    servicoSolicitado--;
                }

            } while (servicoSolicitado >= 0 && servicoSolicitado < 5);
        }
    }
}