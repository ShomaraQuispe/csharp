using Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class PessoaFisica : Cliente
    {
    private string cpf;
        public PessoaFisica(string nome, string cep, string telefone, string email, int id, string cpf) 
            : base(nome, cep, telefone, email, id)
        {
            this.cpf = cpf;
        }

        public string GetCpf() { return cpf; }
        public void SetCpf(string cpf) { this.cpf = cpf; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CPF do Cliente: {this.cpf}");
        }
    }
}
