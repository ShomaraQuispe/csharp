using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6.Model
{
    public class Curso
    {
        private string area;
        private string nomeDoCurso;
        private int valor;
        private string id;
        private int duracao;

        public Curso(string area, string nomeDoCurso, int valor, string id, int duracao)
        {
            this.area = area;
            this.nomeDoCurso = nomeDoCurso;
            this.valor = valor;
            this.id = id;
            this.duracao = duracao;
        }

        public string GetArea() { return area; }
        public void SetArea(string area) { this.area = area; }

        public string GetNomDoCurso() {  return nomeDoCurso; }
        public void SetNomeDoCurso(string nomeDoCurso)
        {
            this.nomeDoCurso = nomeDoCurso;
        }

        public int GetValor() {  return valor; }
        public void SetValor(int valor)
        {
            this.valor = valor;
        }
        public string GetId() { return id; }
        public void SetId(string id)
        {
            this.id = id;
        }

        public int GetDuracao() {  return duracao; }
        public void SetDuracao(int duracao)
        {
            this.duracao = duracao;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("\nDados do Curso");
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("ID do Curso: " + this.id);
            Console.WriteLine("Área do Curso: " + this.area);
            Console.WriteLine("Nome do Curso: " + this.nomeDoCurso);
            Console.WriteLine("Investimento do Curso: " + (this.valor).ToString(format: "C"));
            Console.WriteLine("Duração: " + this.duracao + " horas");
        }
    }
}
