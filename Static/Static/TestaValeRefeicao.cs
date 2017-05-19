class TestaValeRefeicao
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Funcionario.valeRefeicaoDiario);
        Funcionario.valeRefeicaoDiario = 15;
        System.Console.WriteLine(Funcionario.valeRefeicaoDiario);

        Funcionario.ReajustaValeRefeicao(0.1);

        System.Console.WriteLine(Funcionario.valeRefeicaoDiario);
    }
}