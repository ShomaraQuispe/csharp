using Exercicio6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class CursoLivre : Curso
    {
        private string patrocinador;
        public CursoLivre(string area, string nomeDoCurso, int valor, string id, int duracao, string patrocinador) 
            : base(area, nomeDoCurso, valor, id, duracao)
        {
            this.patrocinador = patrocinador;
        }
        public string GetPatrocinador() { return patrocinador; }
        public void SetPatrocinador(string patrocinado) { this.patrocinador=patrocinado; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"O Curso Livre é patrocinador por: {patrocinador}");
        }
    }
}
