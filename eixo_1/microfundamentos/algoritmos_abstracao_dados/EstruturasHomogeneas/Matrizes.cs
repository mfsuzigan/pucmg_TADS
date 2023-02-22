partial class Program
{
    static int[,] CriarMatriz(int NumeroLinhas, int NumeroColunas)
    {
        int[,] Matriz = (new int[NumeroLinhas, NumeroColunas]);
        Random random = new Random();

        for (int i = 0; i < NumeroLinhas; i++)
        {
            for (int j = 0; j < NumeroColunas; j++)
            {
                Matriz[i, j] = random.Next(100);
            }
        }

        return Matriz;
    }

    static void ImprimirMatriz(int[,] Matriz)
    {
        for (int i = 0; i < Matriz.GetLength(0); i++)
        {
            for (int j = 0; j < Matriz.GetLength(1); j++)
            {
                Console.Write(Matriz[i, j] + " ");
            }

            Console.WriteLine("");
        }
    }

    static void ObterDiagonalPrincipal(int[,] Matriz)
    {
        for (int i = 0; i < Matriz.GetLength(0); i++)
        {
            for (int j = 0; j < Matriz.GetLength(1); j++)
            {
                if (i == j)
                {
                    Console.Write(Matriz[i, j] + " ");
                }
            }
        }
    }
}