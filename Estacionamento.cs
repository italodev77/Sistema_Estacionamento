using System;
using System.Collections.Generic;

namespace SistemaEstacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }

        public void AdicionarVeiculo(string placa)
        {
            if (!string.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"O veículo com placa {placa} foi adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void RemoverVeiculo(string placa, decimal precoInicial, decimal precoHora, decimal qtdHoras)
        {
            decimal total = precoInicial + precoHora * qtdHoras;

            if (veiculos.Remove(placa))
            {
                Console.WriteLine($"Pague o valor de {total} para que o veículo com placa {placa} seja removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Veículos no estacionamento:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo registrado.");
            }
        }
    }
}
