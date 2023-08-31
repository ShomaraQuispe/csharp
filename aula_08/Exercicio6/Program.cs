using Exercicio6.Model;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso1 = new("Tecnologia", "Sistema da Informação", 2500, "159753", 800);
            curso1.Visualizar();

            Curso curso2 = new("Multimídia", "Design Digital", 2290, "157981", 800);
            curso2.Visualizar();
        }
    }
}