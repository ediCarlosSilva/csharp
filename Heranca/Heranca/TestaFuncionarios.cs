class TestaFuncionarios
{
    static void Main (string[] args)
    {
        Gerente g = new Gerente();
        g.Nome = "Edi Carlos";
        g.Salario = 2000;
        g.Usuario = "edi.carlos";
        g.Senha = "12345";

        Telefonista t = new Telefonista();
        t.Nome = "Carolina Mello";
        t.Salario = 1000;
        t.EstacaoDeTrabalho = 13;

        Secretaria s = new Secretaria();
        s.Nome = "Tatiane Andrade";
        s.Salario = 1500;
        s.Ramal = 198;

        //System.Console.WriteLine("GERENTE");
        //System.Console.WriteLine("Nome: " + g.Nome);
        //System.Console.WriteLine("Salário: " + g.Salario);
        //System.Console.WriteLine("Usuário: " + g.Usuario);
        //System.Console.WriteLine("Senha:" + g.Senha);
        //System.Console.WriteLine("Bonificação: " + g.CalculaBonificacao() + "\n");
        g.MostraDados();
        System.Console.WriteLine("\n");

        //System.Console.WriteLine("TELEFONISTA");
        //System.Console.WriteLine("Nome: " + t.Nome);
        //System.Console.WriteLine("Salario: " + t.Salario);
        //System.Console.WriteLine("Estação de Trabalho: " + t.EstacaoDeTrabalho);
        //System.Console.WriteLine("Bonificação: " + t.CalculaBonificacao() + "\n");
        t.MostraDados();
        System.Console.WriteLine("\n");

        //System.Console.WriteLine("SECRETÁRIA");
        //System.Console.WriteLine("Nome: " + s.Nome);
        //System.Console.WriteLine("Salário: " + s.Salario);
        //System.Console.WriteLine("Ramal: " + s.Ramal);
        //System.Console.WriteLine("Bonificação: " + s.CalculaBonificacao());
        s.MostraDados();
        System.Console.WriteLine("\n");
    }
}