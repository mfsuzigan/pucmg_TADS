partial class Program
{
    class Vetor
    {
        private int[] _Value;

        public int[] Value { get => _Value; set => _Value = value; }

        public Vetor()
        {
            _Value = new int[10];
        }

        public Vetor(int? Tamanho)
        {
            _Value = new int[Tamanho ?? 10];
        }

        public Vetor(int? Tamanho, int LimiteValoresAleatoriosMinimo, int LimiteValoresAleatoriosMaximo) : this(Tamanho)
        {
            Random random = new Random();

            for (int i = 0; i < _Value.Length; i++)
            {
                _Value[i] = random.Next(LimiteValoresAleatoriosMinimo, LimiteValoresAleatoriosMaximo);
            }
        }

        public void Listar()
        {
            Console.Write($"Vetor: [{string.Join(",", _Value)}]");
        }

        public void Preencher()
        {
            for (int i = 0; i < _Value.Length; i++)
            {
                Console.WriteLine($"Insira o {i + 1}o elemento do vetor: ");
                int.TryParse(Console.ReadLine(), out _Value[i]);
            }
        }

        public void InserirNaPosicao(int Posicao, int Valor)
        {
            _Value[Posicao] = Valor;
        }

        public int RecuperarDaPosicao(int Posicao)
        {
            return _Value[Posicao];
        }

        public int RecuperarMaiorValor()
        {
            return _Value.ToList().Max();
        }

        public int RecuperarMenorValor()
        {
            return _Value.ToList().Min();
        }

        public int RecuperarTamanho()
        {
            return _Value.Length;
        }
    }

    static void Exercicio_ConstrutoresClasse()
    {
        Console.WriteLine("** VETORES - Operacoes **");

        string? Operacao = "";
        string[] OpcoesOperacao = { "1", "2", "3", "4", "5", "6", "7" };
        bool OpcaoFoiValida = false;

        Vetor? Vetor = null;
        string? TamanhoVetor = "";

        do
        {
            Console.WriteLine("\n\nEscolha uma opcao:");
            Console.WriteLine(" 1 - criar");
            Console.WriteLine(" 2 - criar com valores aleatorios");
            Console.WriteLine(" 3 - listar");
            Console.WriteLine(" 4 - inserir valor");
            Console.WriteLine(" 5 - recuperar valor");
            Console.WriteLine(" 6 - localizar maior e menor valores");
            Console.WriteLine(" 7 - sair");

            Operacao = Console.ReadLine();
            OpcaoFoiValida = OpcoesOperacao.Contains(Operacao);

            if (!OpcaoFoiValida)
            {
                Console.WriteLine("\nOpcao invalida. Tente novamente");
            }

            switch (Operacao)
            {
                case "1":
                    Console.WriteLine("Informe (opcionalmente) o tamanho do vetor:");
                    TamanhoVetor = Console.ReadLine();

                    if (TamanhoVetor != null)
                    {
                        Vetor = new Vetor(int.Parse(TamanhoVetor));
                    }
                    else
                    {
                        Vetor = new Vetor();
                    }

                    Vetor.Preencher();
                    Console.Write($"Vetor criado: ");
                    Vetor.Listar();
                    Console.WriteLine("\n");

                    PausarExecucaoELimparTela();
                    break;

                case "2":
                    Console.WriteLine("Informe (opcionalmente) o tamanho do vetor:");
                    TamanhoVetor = Console.ReadLine();

                    Console.WriteLine("Informe o limite inferior de valores aleatorios:");
                    int LimiteValoresAleatoriosMinimo;
                    int.TryParse(Console.ReadLine(), out LimiteValoresAleatoriosMinimo);

                    Console.WriteLine("Informe o limite superior de valores aleatorios:");
                    int LimiteValoresAleatoriosMaximo;
                    int.TryParse(Console.ReadLine(), out LimiteValoresAleatoriosMaximo);

                    if (!string.IsNullOrEmpty(TamanhoVetor))
                    {
                        Vetor = new Vetor(int.Parse(TamanhoVetor), LimiteValoresAleatoriosMinimo, LimiteValoresAleatoriosMaximo);
                    }
                    else
                    {
                        Vetor = new Vetor(null, LimiteValoresAleatoriosMinimo, LimiteValoresAleatoriosMaximo);
                    }

                    Console.Write($"Vetor criado: ");
                    Vetor.Listar();
                    Console.WriteLine("\n");

                    PausarExecucaoELimparTela();
                    break;

                case "3":

                    if (Vetor != null)
                    {
                        Vetor.Listar();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("\nO vetor esta vazio no momento. \n");
                    }

                    PausarExecucaoELimparTela();
                    Console.WriteLine("\n");
                    break;

                case "4":

                    if (Vetor != null)
                    {
                        Console.WriteLine("Informe o valor a ser inserido: ");
                        int ValorASerInserido;
                        int.TryParse(Console.ReadLine(), out ValorASerInserido);

                        Console.WriteLine("Informe a posicao para insercao: ");
                        int PosicaoParaInsercao;
                        int.TryParse(Console.ReadLine(), out PosicaoParaInsercao);

                        Vetor.InserirNaPosicao(PosicaoParaInsercao, ValorASerInserido);

                    }

                    else
                    {
                        Console.WriteLine("\nO vetor esta vazio no momento. \n");
                    }

                    PausarExecucaoELimparTela();
                    break;

                case "5":

                    if (Vetor != null)
                    {
                        Console.WriteLine("Informe a posicao (zero based) para recuperar um valor: ");
                        int PosicaoParaRecuperacao;
                        int.TryParse(Console.ReadLine(), out PosicaoParaRecuperacao);

                        if (PosicaoParaRecuperacao < 0 || PosicaoParaRecuperacao >= Vetor.RecuperarTamanho())
                        {
                            Console.WriteLine("Nao existe valor nesta posicao");
                        }
                        else
                        {
                            Console.WriteLine($"Valor na posicao {PosicaoParaRecuperacao} do vetor: {Vetor.RecuperarDaPosicao(PosicaoParaRecuperacao)}");
                        }
                    }

                    else
                    {
                        Console.WriteLine("\nO vetor esta vazio no momento. \n");
                    }

                    PausarExecucaoELimparTela();
                    break;

                case "6":

                    if (Vetor != null)
                    {
                        Console.WriteLine($"Maior valor no vetor: {Vetor.RecuperarMaiorValor()}");
                        Console.WriteLine($"Menor valor no vetor: {Vetor.RecuperarMenorValor()}");
                    }

                    else
                    {
                        Console.WriteLine("\nO vetor esta vazio no momento. \n");
                    }

                    PausarExecucaoELimparTela();
                    break;
            }

        } while (Operacao != "7");
    }

}
