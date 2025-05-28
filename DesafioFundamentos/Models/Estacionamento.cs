namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        /// <summary>
        ///     Verifica se a placa inserida segue o seguinte formato: ABC-1234 
        /// </summary>
        /// <param name="placa"></param>
        /// <returns></returns>
        private bool VerificarPlaca(string placa)
        {
            // ABC-1234
            if(placa.Length == 8 &&
                char.IsUpper(placa[0]) &&
                char.IsUpper(placa[1]) &&
                char.IsUpper(placa[2]) &&
                placa[3] == '-' &&
                char.IsDigit(placa[4]) &&
                char.IsDigit(placa[5]) &&
                char.IsDigit(placa[6]) &&
                char.IsDigit(placa[7]))
            {
                return true;
            }

            return false;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if(VerificarPlaca(placa) != true)
            {
                Console.WriteLine("Placa foi inserida no modelo errado!\n" +
                    "Exemplo de modelo correto (ABC-1234)");
            }
            else
            {
                Console.WriteLine("Veículo estacionado!");
                veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            if(veiculos.Count == 0)
            {
                // Reaproveito o método para informar que não veículos cadastrados
                ListarVeiculos();
                return ;
            }

            ListarVeiculos();

            Console.WriteLine("Digite a placa do véiculo que deseja remover: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                decimal horas = 0;
                decimal valorTotal = 0; 
                
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToDecimal(Console.ReadLine());

                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
