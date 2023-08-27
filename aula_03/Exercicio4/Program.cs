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

            Console.WriteLine("Escreva a terceira palavra:");
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
                    else
                    {
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("Homem");

                        }
                        else
                            Console.WriteLine("Vaca");
                    }

                }
                else if (palavra1.Equals("invertebrado"))
                {
                    if (palavra2.Equals("inseto"))
                    {
                        if (palavra3.Equals("hematofago"))
                            Console.WriteLine("pulga");
                        else
                            Console.WriteLine("lagarta");
                    }

                    else
                    {
                        if (palavra3.Equals("hematofago"))
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        else
                            Console.WriteLine("minhoca");
                    }
                }

                else
                {
                    Console.WriteLine("Escreva uma palavra válida!");
                }
            }

        }

    }
}