partial class Program
{
    class Consulta
    {
        public Data_? Data;
        public string? Horario;
        public string? NomePaciente;
        public string? NomeMedico;
    }

    class Data_
    {
        public string? Dia;
        public string? Mes;
        public string? Ano;
    }

    static Consulta CadastrarConsulta()
    {
        Consulta Consulta = new Consulta();
        Consulta.Data = new Data_();

        Console.Write("\nNome do paciente: ");
        Consulta.NomePaciente = Console.ReadLine();

        Console.Write("Nome do medico: ");
        Consulta.NomeMedico = Console.ReadLine();

        Console.WriteLine("Data: ");

        Console.Write("     Dia: ");
        Consulta.Data.Dia = Console.ReadLine();

        Console.Write("     Mes: ");
        Consulta.Data.Mes = Console.ReadLine();

        Console.Write("     Ano: ");
        Consulta.Data.Ano = Console.ReadLine();

        Console.Write("\nHorario: ");
        Consulta.Horario = Console.ReadLine();

        Console.WriteLine("\nConsulta cadastrada com sucesso\n");
        PausarExecucaoELimparTela();

        return Consulta;
    }

    static void ListarConsulta(Consulta Consulta)
    {
        Console.WriteLine($"    Nome do Paciente: {Consulta.NomePaciente}");
        Console.WriteLine($"    Nome do Medico: {Consulta.NomeMedico}");
        Console.WriteLine($"    Data: {Consulta.Data?.Dia}/{Consulta.Data?.Mes}/{Consulta.Data?.Ano}");
        Console.WriteLine($"    Horario: {Consulta.Horario}");
    }

    static void ListarAgendaMedico(Consulta[] Consultas)
    {
        Console.Write("Digite o nome do medico: ");
        string? NomeMedicoBusca = Console.ReadLine();
        Console.WriteLine("\n");

        bool EncontrouConsulta = false;

        foreach (Consulta Consulta in Consultas)
        {
            if (Consulta.NomeMedico == NomeMedicoBusca)
            {
                ListarConsulta(Consulta);
                Console.WriteLine("\n");
                EncontrouConsulta = true;
            }
        }

        if (!EncontrouConsulta)
        {
            Console.WriteLine("Nao foram encontradas consultas");
        }

        PausarExecucaoELimparTela();
    }

    static void Exercicio_CadastroConsultas()
    {
        Consulta[] Consultas = Array.Empty<Consulta>();
        int OpcaoMenu = -1;

        do
        {
            Console.WriteLine("\n***GESTAO DE CONSULTAS MEDICAS***");
            Console.WriteLine("\nEscolha uma opcao:");
            Console.WriteLine(" 1 - cadastrar consulta");
            Console.WriteLine(" 2 - consultar agenda de medico");
            Console.WriteLine(" 3 - sair");

            Console.Write("\nDigite sua opcao: ");
            int.TryParse(Console.ReadLine(), out OpcaoMenu);

            switch (OpcaoMenu)
            {
                case 1:
                    Consultas = Consultas.Append(CadastrarConsulta()).ToArray();
                    break;

                case 2:
                    ListarAgendaMedico(Consultas);
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