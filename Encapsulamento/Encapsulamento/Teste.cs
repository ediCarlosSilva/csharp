class Teste
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();

        f.Nome = "Edi Carlos";
        f.Salario = 2000;

        System.Console.WriteLine(f.Nome);
        System.Console.WriteLine(f.Salario);
    }
}