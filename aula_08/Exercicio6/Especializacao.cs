using Exercicio6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Especializacao : Curso
    {
        private int tipo;
        public Especializacao(string area, string nomeDoCurso, int valor, string id, int duracao, int tipo)
            : base(area, nomeDoCurso, valor, id, duracao)
        {
            this.tipo = tipo;
        }
        public int GetTipo() { return tipo; }
        public void SetTipo(int tipo) { this.tipo = tipo; }

        public override void Visualizar()
        {

            string tipo = "";

            switch (this.tipo)
            {
                case 1:
                    tipo = "Bacharel";
                    break;
                case 2:
                    tipo = "Tecnólogo";
                    break;
                case 3:
                    tipo = "Licenciatura";
                    break;
            }
            base.Visualizar();
            Console.WriteLine($"O curso é do tipo : { tipo}");
        }
    }
}
