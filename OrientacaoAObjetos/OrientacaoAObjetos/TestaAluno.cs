class TestaAluno
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        a1.nome = "Edi Carlos";
        a1.rg = "1111111111";
        a1.dataNascimento = "06/06/1983";

        Aluno a2 = new Aluno();
        a2.nome = "Aline";
        a2.rg = "3245658978";
        a2.dataNascimento = "3545678979";

        System.Console.WriteLine("Dados do primeiro aluno");
        System.Console.WriteLine("Nome: " + a1.nome);
        System.Console.WriteLine("RG: " + a1.rg);
        System.Console.WriteLine("Data de Nascimento: " + a1.dataNascimento);

        System.Console.WriteLine("-------------------------------");

        System.Console.WriteLine("Dados do segundo aluno");
        System.Console.WriteLine("Nome: " + a2.nome);
        System.Console.WriteLine("RG: " + a2.rg);
        System.Console.WriteLine("Data de Nascimento: " + a2.dataNascimento);
    }
}