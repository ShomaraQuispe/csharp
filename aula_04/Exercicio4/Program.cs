namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, genero, cargo, back = 0;
            string continua;
            int total = 0, mulherCTFront = 0, homemCTMobile40 = 0, nBiFull30 = 0;
            float mediaIdade = 0;

            do
            {
                Console.WriteLine("Qual é a sua idade?");
                idade = Convert.ToInt32(Console.ReadLine());

                mediaIdade += idade;

                if (idade > 10)
                {
                    total++;
                    
                }
                else
                    Console.WriteLine("Idade inválida!");

                do
                {
                    Console.WriteLine("Qual é o seu gênero? \n1- Mulher Cis \n2-Homem Cis \n3-Não-Binário \n4-Mulher Trans \n5-Homem Trans \n6-Outros");
                    genero = Convert.ToInt32(Console.ReadLine());

                    do
                    {
                        Console.WriteLine("Qual é o seu cargo?\n1-Back-end \n2-Front-end \n3-Mobile \n4-FullStack");
                        cargo = Convert.ToInt32(Console.ReadLine());
                    } while (cargo < 1 || cargo > 4);
                

                } while (genero < 1 || genero > 6);


                if ((genero == 1 || genero == 4) && cargo == 2)
                    mulherCTFront++;

                if ((genero == 2 || genero == 5) && cargo == 3 && idade > 40)
                    homemCTMobile40++;

                if (genero == 3 && cargo ==4 && idade < 30)
                    nBiFull30++;

                if (cargo == 1)
                        back++;


                Console.WriteLine("Deseja continuar (S/N): ");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S"));

            Console.WriteLine($"Total de pessoas desenvolvedoras Backend: {back}");
            Console.WriteLine($"Total de Mulheres Cis e Trans desenvolvedoras Frontend: {mulherCTFront}");
            Console.WriteLine($"Total de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {homemCTMobile40}");
            Console.WriteLine($"Total de Pessoas Não Binárias desenvolvedoras FullStack menores de 30 anos: {nBiFull30}");
            Console.WriteLine($"O número total de pessoas que responderam à pesquisa: {total}");
            Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa: {mediaIdade/total}");

        }

    }
}