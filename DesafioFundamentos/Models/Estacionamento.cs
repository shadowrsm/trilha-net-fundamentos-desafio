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

        public void AdicionarVeiculo()
        {
            //implementado 👍🏼
            Console.WriteLine("-".PadLeft(50, '-'));
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            Console.WriteLine("-".PadLeft(50, '-'));

            veiculos.Add(Console.ReadLine().ToUpper());
            Console.WriteLine("-".PadLeft(50, '-'));
        }

        public void RemoverVeiculo()
        {
            //implementado 👍🏼
            string placa = string.Empty;
            Console.WriteLine("-".PadLeft(50, '-'));
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.WriteLine("-".PadLeft(50, '-'));
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;
                
                //modificado ✌🏼
                Console.WriteLine("-".PadLeft(80, '-'));
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                Console.WriteLine("-".PadLeft(80, '-'));
                horas = int.Parse(Console.ReadLine());

                //implementado 👍🏼
                valorTotal = (precoPorHora * horas) + precoInicial;
                Console.WriteLine("-".PadLeft(80, '-'));
                Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal.ToString("N2")}");
                Console.WriteLine("-".PadLeft(80, '-'));

                //removendo item na Lista
                veiculos.Remove(placa.ToUpper());
            }
            else
            {
                //modificado ✌🏼
                Console.WriteLine("-".PadLeft(50, '-'));
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui.\n" +
                    "Confira se digitou a placa corretamente");
                Console.WriteLine("-".PadLeft(50, '-'));
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //modificado ✌🏼
                Console.WriteLine("-".PadLeft(50, '-'));
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine("-".PadLeft(50, '-'));

                //implementado 👍🏼
                int contadorVeiculos = 0;
                foreach (string item in veiculos)
                {
                    contadorVeiculos++;
                    Console.WriteLine($"{contadorVeiculos}º Veículo Placa: {item}");
                }

                Console.WriteLine("-".PadLeft(50, '-'));
            }
            else
            {
                //modificado ✌🏼
                Console.WriteLine("-".PadLeft(50, '-'));
                Console.WriteLine("Não há veículos estacionados.");
                Console.WriteLine("-".PadLeft(50, '-'));
            }
        }
    }
}