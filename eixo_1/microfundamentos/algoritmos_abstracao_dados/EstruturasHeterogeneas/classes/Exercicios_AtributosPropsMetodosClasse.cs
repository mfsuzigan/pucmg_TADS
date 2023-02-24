partial class Program
{
    class Veiculo
    {
        private string? _Nome;
        private string? _Marca;
        private int _AnoFabricacao;
        private string? _Placa;


        public string? Nome { get => _Nome; set => _Nome = value; }
        public string? Marca { get => _Marca; set => _Marca = value; }
        public int AnoFabricacao { get => _AnoFabricacao; set => _AnoFabricacao = value; }
        public string? Placa { get => _Placa; set => _Placa = value; }

        public Veiculo Cadastrar()
        {
            Console.Write("\nNome: ");
            _Nome = Console.ReadLine();

            Console.Write("Marca: ");
            _Marca = Console.ReadLine();

            Console.Write("Ano de Fabricacao: ");
            int.TryParse(Console.ReadLine(), out _AnoFabricacao);

            Console.Write("Placa: ");
            _Placa = Console.ReadLine();

            return this;
        }

        public void Listar()
        {
            Console.WriteLine($"    Nome: {_Nome}");
            Console.WriteLine($"    Marca: {_Marca}");
            Console.WriteLine($"    Ano de Fabricacao: {_AnoFabricacao}");
            Console.WriteLine($"    Placa: {_Placa}");
        }
    }

    static void ListarVeiculos(Veiculo[] Veiculos)
    {
        Console.WriteLine("\n");

        foreach (Veiculo Veiculo in Veiculos)
        {
            Veiculo.Listar();
            Console.WriteLine("\n");
        }
    }

    static void Exercicio_CadastroVeiculos()
    {
        Veiculo[] Veiculos = Array.Empty<Veiculo>();
        int OpcaoMenu = -1;

        do
        {
            Console.WriteLine("\n***GESTAO DE VEICULOs***");
            Console.WriteLine("\nEscolha uma opcao:");
            Console.WriteLine(" 1 - cadastrar veiculo");
            Console.WriteLine(" 2 - listar todos os veiculos");
            Console.WriteLine(" 3 - sair");

            Console.Write("\nDigite sua opcao: ");
            int.TryParse(Console.ReadLine(), out OpcaoMenu);

            switch (OpcaoMenu)
            {
                case 1:
                    Veiculos = Veiculos.Append(new Veiculo().Cadastrar()).ToArray();
                    Console.WriteLine("\nVeiculo cadastrado com sucesso");
                    PausarExecucaoELimparTela();
                    break;

                case 2:
                    ListarVeiculos(Veiculos);
                    PausarExecucaoELimparTela();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("\nOpcao invalida");
                    PausarExecucaoELimparTela();
                    break;
            }

        } while (OpcaoMenu != 3);
    }
}