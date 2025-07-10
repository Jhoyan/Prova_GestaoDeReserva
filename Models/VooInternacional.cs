using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_GestaoDeReserva.Models
{
    internal class VooInternacional : Voo
    {
        public VooInternacional(int numeroVoo, string origem, string destino, DateTime data, string horario, int totalAssentos, string portaoEmbarque, string nomeAeronave, double taxaEmbarque)
        {
            this.NumeroVoo = numeroVoo;
            this.Origem = origem;
            this.Destino = destino;
            this.Data = data;
            this.Horario = horario;
            this.TotalAssentos = totalAssentos;
            this.PortaoEmbarque = portaoEmbarque;
            this.NomeAeronave = nomeAeronave;
            SetTaxaEmbarque(taxaEmbarque);

            this.TaxaEmbarque = CalcularTaxas();
        }
        public override double CalcularTaxas() // DEIXEI COMO PUBLIC PRA TESTAR SE TAVA SOMANDO CERTO
        {
            return this.TaxaEmbarque * 1.5;
        }
    }
}
