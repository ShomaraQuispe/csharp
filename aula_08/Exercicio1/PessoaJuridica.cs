using Exercicio1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class PessoaJuridica : Cliente
    {
        private string cnpj;
        public PessoaJuridica(string nome, string cep, string telefone, string email, int id, string cnpj) :
            base(nome, cep, telefone, email, id)
        {
            this.cnpj = cnpj;
        }
        public string GetCnpj() { return cnpj; }
        public void SetCnpj(string cnpj) { this.cnpj = cnpj; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"CNPJ do Cliente: {this.cnpj}");

        }
    }
}
