using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_GestaoDeReserva.Models
{
    internal class Reserva
    {
        private Passageiro Passageiro { get; set; }
        private Voo Voo {  get; set; }
        private int Assento {  get; set; }
        private double ValorPassagem;
        private string Status { get; set; }
        private string Classe { get; set; }

        public Reserva(Passageiro passageiro, Voo voo, int assento, double valor, string status, string classe)
        {
            this.Passageiro = passageiro;
            this.Voo = voo;
            this.Assento = assento;
            SetValorPassagem(valor);
            this.Status = status;
            this.Classe = classe;

            CalcularValorPassagem();
        }

        public double GetValorPassagem()
        {
            return ValorPassagem;
        }
        public void SetValorPassagem(double valorPassagem)
        {
            if(valorPassagem < 1)
            {
                throw new Exception("Valor inválido");
            }
            else
            {
                this.ValorPassagem = valorPassagem;
            }
        }

        public double CalcularValorPassagem()
        {
            double novoTotal = 0;
            novoTotal = this.ValorPassagem + Voo.TaxaEmbarque;

            this.ValorPassagem = novoTotal;
            return novoTotal;
        }
    }
}
