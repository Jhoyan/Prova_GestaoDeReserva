using Prova_GestaoDeReserva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_GestaoDeReserva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Informe o tipo de voo:\n1 - Voo Domestico\n2 - Voo Internacional\n");
                string op = Console.ReadLine();

                
                Console.WriteLine("Informe o número do voo: ");
                int numeroVoo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a origem do voo: ");
                string origem = Console.ReadLine();

                Console.WriteLine("Informe o destino do voo: ");
                string destino = Console.ReadLine();

                Console.WriteLine("Informe a data prevista de embarque (YYYY-MM-DD): ");
                DateTime dataEmbarque = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Informe o horário do voo: ");
                string horario = Console.ReadLine();

                Console.WriteLine("Informe o total de assentos");
                int totalAssentos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o portão de embarque: ");
                string portaoEmbarque = Console.ReadLine();

                Console.WriteLine("Informe o nome da aeronave: ");
                string nomeAeronave = Console.ReadLine();

                Console.WriteLine("Informe a taxa de embarque: ");
                double taxaEmbarque = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("DADOS DO PASSAGEIRO\nInforme o nome do passageiro: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o CPF do passageiro: ");
                string cpf = Console.ReadLine();

                Console.WriteLine("Informe a data de nascimento do passageiro (YYYY-MM-DD): ");
                DateTime dataNasc = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Informe o email do passageiro: ");
                string email = Console.ReadLine();

                Console.WriteLine("Informe o telefone do passageiro: ");
                string telefone = Console.ReadLine();

                Console.WriteLine("DADOS DA RESERVA\nInforme o número do assento: ");
                int assento = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor da reserva: ");
                double valorPassagem = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o status da reserva: ");
                string status = Console.ReadLine();

                Console.WriteLine("Informe a classe da reserva: ");
                string classe = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        VooDomestico vooDomestico = new VooDomestico(numeroVoo, origem, destino, dataEmbarque, horario, totalAssentos, portaoEmbarque, nomeAeronave, taxaEmbarque);
                        Passageiro passageiroDom = new Passageiro(nome, cpf, dataNasc, email, telefone);
                        Reserva reservaDom = new Reserva(passageiroDom, vooDomestico, assento, valorPassagem, status, classe);

                        Console.WriteLine("O valor da passagem + taxa de embarque é de: " + reservaDom.GetValorPassagem());
                        break;
                    case "2":
                        VooInternacional vooInternacional = new VooInternacional(numeroVoo, origem, destino, dataEmbarque, horario, totalAssentos, portaoEmbarque, nomeAeronave, taxaEmbarque);
                        Passageiro passageiroInt = new Passageiro(nome, cpf, dataNasc, email, telefone);
                        Reserva reservaInt = new Reserva(passageiroInt, vooInternacional, assento, valorPassagem, status, classe);

                        Console.WriteLine("O valor da passagem + taxa de embarque é de: " + reservaInt.GetValorPassagem());
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção de voo válida.");
                        break;
                }                

                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}