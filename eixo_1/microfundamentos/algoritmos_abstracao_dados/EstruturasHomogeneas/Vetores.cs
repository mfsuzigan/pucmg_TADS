partial class Program
{
    static int[] CriarVetor(int Tamanho, Boolean PreenchimentoAutomatico = true)
    {
        int[] Vetor = (new int[Tamanho]);
        Random random = new Random();

        for (int i = 0; i < Tamanho; i++)
        {
            if (PreenchimentoAutomatico)
            {
                Vetor[i] = random.Next(100);

            }
            else
            {
                Console.Write($"Informe o elemento {i} do vetor: ");
                int.TryParse(Console.ReadLine(), out Vetor[i]);
            }
        }

        return Vetor;
    }

    static string ImprimirVetor(int[] Vetor)
    {
        return string.Join(", ", Vetor);
    }

    static int SomarPares(int[] Vetor)
    {
        return Vetor.ToList().Where(e => e % 2 == 0).Sum();
    }

    static int ContarImpares(int[] Vetor)
    {
        return Vetor.ToList().Where(e => e % 2 != 0).Count();
    }

    static int ContarPares(int[] Vetor)
    {
        return Vetor.Length - ContarImpares(Vetor);
    }

    static int ObterMaiorValor(int[] Vetor)
    {
        return Vetor.ToList().Max();
    }

    static int ObterMenorValor(int[] Vetor)
    {
        return Vetor.ToList().Min();
    }

    static double ObterMedia(int[] Vetor)
    {
        return Vetor.ToList().Average();
    }
}