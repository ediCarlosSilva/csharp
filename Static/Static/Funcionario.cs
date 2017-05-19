class Funcionario
{
    public string nome;
    public double salario;

    public static double valeRefeicaoDiario;

    public static void ReajustaValeRefeicao(double taxa)
    {
        Funcionario.valeRefeicaoDiario += Funcionario.valeRefeicaoDiario * taxa;
    }
}