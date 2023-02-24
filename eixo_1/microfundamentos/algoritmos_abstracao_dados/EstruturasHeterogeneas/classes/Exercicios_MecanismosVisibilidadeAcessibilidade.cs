partial class Program
{
    class Complex
    {
        private double _PReal;
        private double _PImag;

        public double PReal { get => _PReal; set => _PReal = value; }
        public double PImag { get => _PImag; set => _PImag = value; }

        public Complex Adicionar(Complex C)
        {
            _PReal += C.PReal;
            _PImag += C._PImag;

            return this;
        }

        public Complex Subtrair(Complex C)
        {
            _PReal -= C.PReal;
            _PImag -= C._PImag;

            return this;
        }

        // Se: z1 = a + bi; z2 = c + di.
        // Logo: z1 . z2 = (ac - bd) + (ad + bc)i.
        public Complex Multiplicar(Complex C)
        {
            double PRealAnterior = _PReal;
            _PReal = (_PReal * C.PReal) - (_PImag * C.PImag);
            _PImag = (PRealAnterior * C.PImag) + (_PImag * C.PReal);

            return this;
        }

        // Se: z1 = a + bi; z2 = c + di
        // Logo z1 : z2 = (ac + bd)/(c² + d²) + (cb - ad)i/(c² + d²)
        public Complex Dividir(Complex C)
        {
            double Denominador = Math.Pow(C.PReal, 2) + Math.Pow(C.PImag, 2);
            double PRealAnterior = _PReal;

            _PReal = ((_PReal * C.PReal) + (_PImag * C.PImag)) / Denominador;
            _PImag = ((C.PReal * _PImag) - (PRealAnterior * C.PImag)) / Denominador;

            return this;
        }

        public void Preencher()
        {
            Console.WriteLine("Insira a parte real: ");
            double.TryParse(Console.ReadLine(), out _PReal);

            Console.WriteLine("Insira a parte imaginaria: ");
            double.TryParse(Console.ReadLine(), out _PImag);

            Console.Write($"\nNumero informado: ");
            Imprimir();
        }

        public void Imprimir()
        {
            Console.Write($"{_PReal}{(_PImag > 0 ? "+" : "")}{_PImag}i");
        }
    }

    static void Exercicio_OperacoesNumComplexos()
    {
        Console.WriteLine("** NUM. COMPLEXOS - Operacoes **");

        Console.WriteLine("\nInforme o primeiro numero complexo");
        Complex NumeroComplexo1 = new Complex();
        NumeroComplexo1.Preencher();

        string? Operacao = "";
        string[] OpcoesOperacao = { "1", "2", "3", "4" };
        bool OpcaoFoiValida = false;

        do
        {
            Console.WriteLine("\n\nEscolha uma opcao:");
            Console.WriteLine(" 1 - adicionar");
            Console.WriteLine(" 2 - subtrair");
            Console.WriteLine(" 3 - multiplicar");
            Console.WriteLine(" 4 - dividir");

            Operacao = Console.ReadLine();
            OpcaoFoiValida = OpcoesOperacao.Contains(Operacao);

            if (!OpcaoFoiValida)
            {
                Console.WriteLine("\nOpcao invalida. Tente novamente");
            }

        } while (!OpcaoFoiValida);

        Console.WriteLine("\nInforme o segundo numero complexo");
        Complex NumeroComplexo2 = new Complex();
        NumeroComplexo2.Preencher();
        
        switch (Operacao)
        {
            case "1":
                NumeroComplexo1.Adicionar(NumeroComplexo2);
                break;
                
            case "2":
                NumeroComplexo1.Subtrair(NumeroComplexo2);
                break;
                
            case "3":
                NumeroComplexo1.Multiplicar(NumeroComplexo2);
                break;
                
            case "4":
                NumeroComplexo1.Dividir(NumeroComplexo2);
                break;
        }

        Console.Write("\n\nResultado: ");
        NumeroComplexo1.Imprimir();
        Console.WriteLine("\n");
    }
}