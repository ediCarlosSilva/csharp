class TestaFuncionario
{
    static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.nome = "Edi Carlos";
        f1.salario = 4500;

        Funcionario f2 = new Funcionario();
        f2.nome = "Joaquim";
        f2.salario = 5000;

        System.Console.WriteLine("Dados do primeiro funcionário");
        System.Console.WriteLine("Nome: " + f1.nome);
        System.Console.WriteLine("Salário: " + f1.salario);

        System.Console.WriteLine("Dados do segundo funcionário");
        System.Console.WriteLine("Nome: " + f2.nome);
        System.Console.WriteLine("Salário: " + f2.salario);

    }
}