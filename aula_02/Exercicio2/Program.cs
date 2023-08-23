namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, notaMedia;
            string nomeAluno;

            Console.WriteLine("Digite o nome do aluno(a):");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota do aluno(a): ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            notaMedia = (nota1+nota2+nota3+nota4)/4;

            Console.WriteLine("A nota média do(a) aluno(a), " + nomeAluno + ", é " + notaMedia);
        }
    }
}