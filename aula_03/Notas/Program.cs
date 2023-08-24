namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            //if ternários
            // O "?" abaixo significa condição "É verdadeiro?", se sim ele lê a primeira palavra e depois de : é o negativo
            Console.WriteLine((media > 6) ? "Aprovado" : "Reprovado");
            // condição ? ação verdadeiro : ação para falso
            // interessante para usar no máximo 2 condições e no front
        }
    }
}