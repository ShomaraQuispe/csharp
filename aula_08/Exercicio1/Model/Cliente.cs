using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Model
{
    public class Cliente
    {
        private string nome;
        private int id;
        private string cep;
        private string telefone;
        private string email;
        public Cliente(string nome, string cep, string telefone, string email, int id)
        {
            this.nome = nome;
            this.cep = cep;
            this.telefone = telefone;
            this.email = email;
            this.id = id;
        }

        public string GetNome() { return nome; }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCpf() { return cep; }
        public void SetCpf(string cep)
        {
            this.cep = cep;
        }

        public string GetRg() { return telefone; }
        public void SetRg(string telefone)
        {
            this.telefone = telefone;
        }

        public string GetEmail() { return email; }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public int GetId() { return id; }
        public void SetId(int id)
        {
            this.id = id;
        }

        public virtual void Visualizar()
        {
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("\nDados do Cliente");
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("ID do Cliente: " + this.id);
            Console.WriteLine("Nome do Cliente: " + this.nome);
            Console.WriteLine("CEP do Cliente: " + this.cep);
            Console.WriteLine("Telefone do Cliente: " + this.telefone);
            Console.WriteLine("E-mail do Cliente: " + this.email);
        }
    }
}
