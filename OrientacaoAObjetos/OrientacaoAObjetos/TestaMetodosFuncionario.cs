class TestaMetodosFuncionario
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();
        f.nome = "Edi Carlos";
        f.salario = 2000;

        System.Console.WriteLine("Consultando dados antes do aumento.");
        System.Console.WriteLine(f.consultaDados());

        f.aumentarSalario(1500);

        System.Console.WriteLine("Dados depois do aumento.");
        System.Console.WriteLine(f.consultaDados());
    }
}