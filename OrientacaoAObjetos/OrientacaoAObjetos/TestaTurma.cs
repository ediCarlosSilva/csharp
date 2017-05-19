class TestaTurma
{
    static void Main(string[] args)
    {
        Turma t1 = new Turma();
        t1.periodo = "noturno";
        t1.serie = "2";
        t1.sigla = "ADS";
        t1.tipoEnsino = "superior";

        Turma t2 = new Turma();
        t2.periodo = "Diurno";
        t2.serie = "3";
        t2.sigla = "POL";
        t2.tipoEnsino = "Técnico";

        System.Console.WriteLine("Dados da primeira turma");
        System.Console.WriteLine("Período: " + t1.periodo);
        System.Console.WriteLine("Série: " + t1.serie);
        System.Console.WriteLine("Sigla: " + t1.sigla);
        System.Console.WriteLine("Tipo de Ensino: " + t1.tipoEnsino);

        System.Console.WriteLine("\n");

        System.Console.WriteLine("Dados da segunda Turma");
        System.Console.WriteLine("Período: " + t2.periodo);
        System.Console.WriteLine("Série: " + t2.serie);
        System.Console.WriteLine("Sigla: " + t2.sigla);
        System.Console.WriteLine("Tipo de Ensino: " + t2.tipoEnsino);
    }
}