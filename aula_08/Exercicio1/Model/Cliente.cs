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
        private string cpf;
        private string rg;
        private string email;
        public Cliente(string nome, string cpf, string rg, string email, int id)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.email = email;
            this.id = id;
        }

        public string GetNome() { return nome; }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public string GetCpf() { return cpf; }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string GetRg() { return rg; }
        public void SetRg(string rg)
        {
            this.rg = rg;
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

        public void Visualizar()
        {
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("\nDados do Cliente");
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine("ID do Cliente: " + this.id);
            Console.WriteLine("Nome do Cliente: " + this.nome);
            Console.WriteLine("CPF do Cliente: " + this.cpf);
            Console.WriteLine("RG do Cliente: " + this.rg);
            Console.WriteLine("E-mail do Cliente: " + this.email);
        }
    }
}
