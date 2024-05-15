using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.models
{
    public class Estacionamento
    {
        // Propriedades da Classe Estacionamento
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        // Método Construtor
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Métodos Funcionais //

        // método de adição para adicionar veiculos a lista
        public void AdicionarVeiculo()
        {
            // adquire a placa do veiculo chegado
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();
            
            // verifica se a placa já consta na lista de veiculos estacionados
            if(veiculos.Any(x => x == placa)){
                Console.WriteLine($"Erro! Carro : {placa} já está estacionado");
            }
            // caso não esteja entre elas, adiciona com a hora da chegada
            else {
                veiculos.Add(placa);
                string hora = (DateTime.Now).ToString("HH:mm");
                Console.WriteLine($"Carro placa: {placa}, adicionado com entrada em: {hora}");
            }
        }

        // método de remoção de veiculo da lista, com horas de permanencia manual
        public void RemoverVeiculoManual()
        {
            // adquire a placa do veiculo
            Console.Write("Digite a placa do veículo para remover: ");
            string placa = Console.ReadLine().ToUpper();

            // caso a mesma se encontre estacionada
            if (Encontra(placa))
            {
                // pede quantas horas o carro esteve estacionado
                Console.Write("Preencha quantas horas que o veículo permaneceu:\n (horas inteiras, arredonde para Mais)\n - ");

                int horas = Convert.ToInt32(Console.ReadLine()); // passa o valor para um tipo "int"

                // calcula o valor total do carro
                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                // informa da saida do carro com horario de saida atual
                string hora = DateTime.Now.ToString("HH:mm");                
                Console.WriteLine($"O veículo {placa} foi removido as {hora} e o preço total foi de: R$ {valorTotal}");
                
                // retira a placa da lista
                veiculos.Remove(placa);
            }
        }

        // método de visualização de placas no sistema
        public void ListarVeiculos()
        {
            // verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // apresenta o cabeçalho e informa o nº de veiculos estacionados
                Console.WriteLine($"Os veículos estacionados são {veiculos.Count}:");
                // passa por todos os elementos da lista, apresentando placa a placa
                for (int i = 0; i < veiculos.Count; i++)
                {
                 Console.WriteLine($"{i+1}-\t{veiculos[i]}");
                }
                // mensagem de indicação que encerrou o loop
                Console.WriteLine("--Fim da lista--");
            }
            // caso não, informa
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        // método interno de busca
        private bool Encontra(string placa)
        {
            // verifica se uma placa especifica consta dentre as placas em lista
            if(veiculos.Any(x => x == placa)){
                // retorna verdade caso a placa procurada encontre-se na lista
                return true;
            }
            // caso contrario
            else{
                // informa que tal placa não consta na lista
                Console.WriteLine("Placa não localizada no nosso sistema, por favor verifique a digitação (sem -, sinais graficos ou espaços)");
                return false;
            }
        }
    }
}