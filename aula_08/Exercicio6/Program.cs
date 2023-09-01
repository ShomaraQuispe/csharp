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

            CursoLivre livre1 = new("Comunicação", "Marketing para Ongs", 580, "1235", 40, "B3");
            livre1.Visualizar();

            CursoLivre livre2 = new("Direito", "LGPD para comércios locais", 500, "59878", 40, "B3");
            livre2.Visualizar();

            Especializacao especializacao1 = new("Saúde", "Enfermagem", 3000, "15987", 1200, 1);
            especializacao1.Visualizar();

            Especializacao especializacao2 = new("Tecnologia", "Análise de Desenvolvimento de Sistema", 2200, "15987", 1200, 2);
            especializacao2.Visualizar();

        }
    }
}