class TesteAlunoTurma
{
    static void Main(string[] args)
    {
        Turma t = new Turma();
        t.periodo = "Noturno";
        t.serie = "3";
        t.sigla = "ADS";
        t.tipoEnsino = "Superior";

        Aluno a = new Aluno();

        a.nome = "Edi Carlos";
        a.rg = "332556789";
        a.dataNascimento = "06/06/1983";

        System.Console.WriteLine("Dados da turma");
        System.Console.WriteLine("Período: " + t.periodo);
        System.Console.WriteLine("Série: " + t.serie);
        System.Console.WriteLine("Sigla: " + t.sigla);
        System.Console.WriteLine("Tipo de Ensino: " + t.tipoEnsino);

        System.Console.WriteLine("\n------------------\n");

        System.Console.WriteLine("Dados do Aluno");
        System.Console.WriteLine("Nome: " + a.nome);
        System.Console.WriteLine("RG: " + a.rg);
        System.Console.WriteLine("Data de Nascimento: " + a.dataNascimento);

        System.Console.WriteLine("\n-------------------\n");

        a.turma = t;

        System.Console.WriteLine("Dados da turma obtidos através da classe aluno");
        System.Console.WriteLine("Periodo: " + a.turma.periodo);
        System.Console.WriteLine("Série: " + a.turma.serie);
        System.Console.WriteLine("Sigla: " + a.turma.sigla);

    }
}