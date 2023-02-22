partial class Program
{
    struct Professor
    {
        public string? Matricula;
        public String? Nome;
        public Disciplina DadosDisciplina;
    }

    struct Disciplina
    {
        public string? Nome;
        public int CargaHoraria;
    }

    static Professor[] CadastrarProfessores(Professor[] Professores)
    {
        Console.WriteLine("REGISTRO DE PROFESSORES \n");

        for (int i = 0; i < Professores.Length; i++)
        {
            Console.WriteLine($"\nPROFESSOR {i + 1}");

            Console.Write("\nMatricula: ");
            Professores[i].Matricula = Console.ReadLine();

            Console.Write("Nome: ");
            Professores[i].Nome = Console.ReadLine();

            Console.Write("Nome da disciplina: ");
            Professores[i].DadosDisciplina.Nome = Console.ReadLine();

            Console.Write("Carga horaria da disciplina: ");
            int.TryParse(Console.ReadLine(), out Professores[i].DadosDisciplina.CargaHoraria);
        }

        return Professores;
    }

    static Professor[] ListarProfessores(Professor[] Professores)
    {
        Console.WriteLine("\n\nLISTA DE PROFESSORES \n");

        for (int i = 0; i < Professores.Length; i++)
        {
            ListarProfessor(Professores[i]);
        }

        return Professores;
    }

    static void ListarProfessor(Professor Professor)
    {
        Console.WriteLine($"Matricula: {Professor.Matricula}");
        Console.WriteLine($"Nome: {Professor.Nome}");
        Console.WriteLine($"Nome da disciplina: {Professor.DadosDisciplina.Nome}");
        Console.WriteLine($"CH da disciplina: {Professor.DadosDisciplina.CargaHoraria}");
        Console.Write("\n");
    }


    static void BuscarProfessores(Professor[] Professores)
    {
        Console.WriteLine("\n\nBUSCA DE PROFESSORES \n");
        Console.Write("Digite o nome de um professor: ");
        string? BuscaProfessor = Console.ReadLine();
        Console.WriteLine("\n");

        bool EncontrouProfessor = false;

        foreach (Professor Professor in Professores)
        {
            if (Professor.Nome == BuscaProfessor)
            {
                ListarProfessor(Professor);
                EncontrouProfessor = true;
            }
        }

        if (!EncontrouProfessor){
            Console.WriteLine("Professor nao encontrado.");
        }
    }

    static void Exemplo(int QuantidadeProfessores)
    {
        Professor[] Professores = new Professor[QuantidadeProfessores];
        CadastrarProfessores(Professores);
        ListarProfessores(Professores);
        BuscarProfessores(Professores);
    }
}