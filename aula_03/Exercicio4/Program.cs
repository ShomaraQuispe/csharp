using System.ComponentModel.Design;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Escreva a primeira palavra:");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Escreva a segunda palavra:");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Escreva a terceir palavra:");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                if (palavra1.Equals("vertebrado"))
                {
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("Águia");
                        }
                        else
                            Console.WriteLine("Pomba");
                    }
                    if (palavra2.Equals("mamifero"))
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("Homem");

                        }
                        else
                            Console.WriteLine("Vaca");
                    }

                }
            }
            else
            {
                if (palavra3.Equals("onivoro"))
                    Console.WriteLine("Homem");
                {
                    Console.WriteLine("Vaca");
                }
            }

        }
            else
            {
                Console.WriteLine("Escreva uma palavra válida!");
            }
}
    }
}