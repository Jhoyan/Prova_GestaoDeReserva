using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_GestaoDeReserva.Models
{
    internal abstract class Voo
    {
        protected int NumeroVoo { get; set; }
        protected string Origem { get; set; }
        protected string Destino { get; set; }
        protected DateTime Data { get; set; }
        protected string Horario { get; set; }
        public int TotalAssentos;
        protected string PortaoEmbarque { get; set; }
        protected string NomeAeronave { get; set; }
        public double TaxaEmbarque; // DEIXEI COMO PUBLIC PRA TESTAR SE TAVA SOMANDO CERTO

        //public Voo()
        //{
        //    int teste = TotalAssentos;
        //    public int[] assentosTotais = new int[teste];
        //}        

        public double GetTaxaEmbarque()
        {
            return TaxaEmbarque;
        }
        public void SetTaxaEmbarque(double taxaEmbarque)
        {
            if (taxaEmbarque < 0)
            {
                throw new Exception("Valor inválido!");
            }
            else
            {
                this.TaxaEmbarque = taxaEmbarque;
            }
        }
        public int GetTotalAssentos()
        {
            return TotalAssentos;
        }
        public void SetTotalAssentos(int totalAssentos)
        {
            if (totalAssentos > 0)
            {
                this.TotalAssentos = totalAssentos;
            }
            else
            {
                throw new Exception("O total de assentos informado deve ser maior que zero");
            }
        }

        public abstract double CalcularTaxas(); // DEIXEI COMO PUBLIC PRA TESTAR SE TAVA SOMANDO CERTO

    }
}
