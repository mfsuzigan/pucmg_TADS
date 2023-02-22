partial class Program
{
    static void Main(string[] args)
    {

        // Vetores
        // int[] Vetor = CriarVetor(5, false);
        // Console.WriteLine($"Vetor: [{ImprimirVetor(Vetor)}]");
        // Console.WriteLine($"Soma de pares: {SomaPares(Vetor)}");
        // Console.WriteLine($"Numero de impares: {ContaImpares(Vetor)}");

        // Matrizes
        // int[,] Matriz = CriarMatriz(100, 100);
        // Console.WriteLine("Matriz: ");
        // ImprimirMatriz(Matriz);
        // Console.WriteLine($"\nDiagonal principal: ");
        // ObterDiagonalPrincipal(Matriz);

        // Exercicio 1
        // Exercicio1_VetorInteiros();

        // Exercicio 2
        // Exercicio2_NotasAlunos(3, 3);

        // Exercicio 3
        Exercicio3_CadastroPesquisaFuncionarios(3);
    }

    static void Exercicio1_VetorInteiros()
    {
        int[] Vetor = CriarVetor(10, false);
        Console.WriteLine($"\nVetor: [{ImprimirVetor(Vetor)}]");
        Console.WriteLine($"Maior valor: {ObterMaiorValor(Vetor)}");
        Console.WriteLine($"Menor valor: {ObterMenorValor(Vetor)}");

        int QuantidadeImpares = ContarImpares(Vetor);
        int QuantidadePares = Vetor.Length - QuantidadeImpares;

        Console.WriteLine($"Quantidade de pares: {QuantidadePares}");
        Console.WriteLine($"Quantidade de impares: {QuantidadeImpares}");
        Console.WriteLine($"Media aritmetica: {ObterMedia(Vetor)}");
    }

    static void Exercicio2_NotasAlunos(int QuantidadeAlunos, int QuantidadeProvas)
    {
        double[,] Notas = new double[QuantidadeAlunos, QuantidadeProvas];

        for (int contadorProva = 0; contadorProva < QuantidadeProvas; contadorProva++)
        {
            for (int contadorAluno = 0; contadorAluno < QuantidadeAlunos; contadorAluno++)
            {
                Console.Write($"Insira a nota da {contadorProva + 1}a prova do {contadorAluno + 1}o aluno: ");
                double.TryParse(Console.ReadLine(), out Notas[contadorAluno, contadorProva]);
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nRESULTADOS\n");

        double[] NotasTotaisAlunos = new Double[QuantidadeAlunos];
        double[] MediasTurmaPorProva = new Double[QuantidadeProvas];

        Console.WriteLine(" Notas totais");

        for (int contadorAluno = 0; contadorAluno < QuantidadeAlunos; contadorAluno++)
        {
            for (int contadorProva = 0; contadorProva < QuantidadeProvas; contadorProva++)
            {
                NotasTotaisAlunos[contadorAluno] += Notas[contadorAluno, contadorProva];
                MediasTurmaPorProva[contadorProva] += Notas[contadorAluno, contadorProva];
            }

            Console.WriteLine($"    Aluno {contadorAluno + 1}: {NotasTotaisAlunos[contadorAluno]}");
        }

        MediasTurmaPorProva = MediasTurmaPorProva.Select(media => media / QuantidadeAlunos).ToArray();
        Console.WriteLine("\n Medias da Turma por Prova");

        for (int contadorProva = 0; contadorProva < QuantidadeProvas; contadorProva++)
        {
            Console.WriteLine($"     Prova {contadorProva + 1}: {MediasTurmaPorProva[contadorProva]}");
        }
    }
    static void Exercicio3_CadastroPesquisaFuncionarios(int QuantidadeFuncionarios)
    {
        string?[] Funcionarios = new string[QuantidadeFuncionarios];
        string?[] Telefones = new string[QuantidadeFuncionarios];

        for (int i = 0; i < QuantidadeFuncionarios; i++)
        {
            Console.Write($"Cadastre o nome do Funcionario {i + 1}: ");
            Funcionarios[i] = Console.ReadLine();

            Console.Write($"Cadastre o telefone do Funcionario {i + 1}: ");
            Telefones[i] = Console.ReadLine();

            Console.WriteLine();
        }

        Console.Write("\nDeseja pesquisar um funcionario? (s/n) ");
        string? DesejaConsultarFuncionario = Console.ReadLine();
        bool EncontrouFuncionario = false;

        if (DesejaConsultarFuncionario != null && DesejaConsultarFuncionario.ToLower() == "s")
        {
            Console.Write("Informe o nome do funcionario: ");
            string? PesquisaPorNome = Console.ReadLine();

            for (int i = 0; i < QuantidadeFuncionarios; i++)
            {
                if (Funcionarios[i] == PesquisaPorNome) {
                    Console.WriteLine($"{Funcionarios[i]} => {Telefones[i]}");
                    EncontrouFuncionario = true;
                }
            }

            if (!EncontrouFuncionario){
                Console.WriteLine("\nFuncionario nao encontrado");
            }
        }
    }
}