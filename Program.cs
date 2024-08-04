using System;

namespace SistemaEstacionamento
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o valor inicial:");
            decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o valor da hora:");
            decimal precoHora = Convert.ToDecimal(Console.ReadLine());

            Estacionamento est = new Estacionamento(precoInicial, precoHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            
            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Informe a Placa:");
                        string placa = Console.ReadLine();
                        est.AdicionarVeiculo(placa);
                        break;

                    case "2":
                        Console.WriteLine("Informe a Placa do veículo a ser removido:");
                        string placaRemover = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade de horas que o veículo permaneceu no estacionamento");
                        decimal qtdHoras =  Convert.ToDecimal(Console.ReadLine());
                        est.RemoverVeiculo(placaRemover, precoInicial,precoHora, qtdHoras);
                        break;

                    case "3":
                        est.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
