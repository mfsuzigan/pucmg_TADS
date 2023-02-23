partial class Program
{
    struct Produto
    {
        public String? Nome;
        public double PrecoUnitario;
        public int QuantidadeEmEstoque;
        public Data Validade;
    }

    struct Data
    {
        public string? Mes;
        public string? Ano;
    }

    static Produto CadastrarProduto()
    {
        Produto Produto = new Produto();

        Console.Write("\nNome: ");
        Produto.Nome = Console.ReadLine();

        Console.Write("Preco unitario: ");
        double.TryParse(Console.ReadLine(), out Produto.PrecoUnitario);

        Console.Write("Qtd. em estoque: ");
        int.TryParse(Console.ReadLine(), out Produto.QuantidadeEmEstoque);

        Console.WriteLine("Data de validade");

        Console.Write("     Mes: ");
        Produto.Validade.Mes = Console.ReadLine();

        Console.Write("     Ano: ");
        Produto.Validade.Ano = Console.ReadLine();

        return Produto;
    }

    static void ListarProduto(Produto Produto)
    {
        Console.WriteLine($"    Nome: {Produto.Nome}");
        Console.WriteLine($"    Preco unitario: {Produto.PrecoUnitario}");
        Console.WriteLine($"    Qtd. em estoque: {Produto.QuantidadeEmEstoque}");
        Console.WriteLine($"    Data de validade");
        Console.WriteLine($"       Mes: {Produto.Validade.Mes}");
        Console.WriteLine($"       Ano: {Produto.Validade.Ano}");
    }

    static void BuscarProdutos(Produto[] Produtos)
    {
        Console.Write("Digite o preco minimo para busca: ");
        double PrecoMinimoBuscaProdutos;
        double.TryParse(Console.ReadLine(), out PrecoMinimoBuscaProdutos);
        Console.WriteLine("\n");

        bool EncontrouProduto = false;

        foreach (Produto Produto in Produtos)
        {
            if (Produto.PrecoUnitario > PrecoMinimoBuscaProdutos)
            {
                ListarProduto(Produto);
                Console.WriteLine("\n");
                EncontrouProduto = true;
            }
        }

        if (!EncontrouProduto)
        {
            Console.WriteLine("Produto nao encontrado");
        }

        Console.Write("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    static void Exercicio_CadastroProdutos()
    {
        Produto[] Produtos = Array.Empty<Produto>();
        int OpcaoMenu = -1;

        do
        {
            Console.WriteLine("\n***GESTAO DE PRODUTOS***");
            Console.WriteLine("\nEscolha uma opcao:");
            Console.WriteLine(" 1 - cadastrar produto");
            Console.WriteLine(" 2 - consultar produto p/ preco minimo");
            Console.WriteLine(" 3 - sair");

            Console.Write("\nDigite sua opcao: ");
            int.TryParse(Console.ReadLine(), out OpcaoMenu);

            switch (OpcaoMenu)
            {
                case 1:
                    Produtos = Produtos.Append(CadastrarProduto()).ToArray();
                    break;

                case 2:
                    BuscarProdutos(Produtos);
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("\nOpcao invalida");
                    Console.Write("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
            }

        } while (OpcaoMenu != 3);
    }
}