using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_GestaoDeReserva.Models
{
    internal class Passageiro
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string cpf;
        private DateTime dataNasc { get; set; }
        private string email { get; set; }
        private string telefone { get; set; }

        public Passageiro(string nome, string cpf, DateTime dataNasc, string email, string telefone)
        {
            this.nome = nome;
            SetCpf(cpf);
            this.dataNasc = dataNasc;
            this.email = email;
            this.telefone = telefone;
        }

        public Passageiro() { }

        public string GetCpf()
        {
            return cpf;
        }
        public void SetCpf(string cpf)
        {
            string cpf2 = cpf.Replace("-", "").Replace(".", "").Trim();
            if (cpf2.Length == 11)
            {
                this.cpf = cpf;
            }
            else
            {
                throw new Exception("CPF inválido!");
            }
        }
    }
}
