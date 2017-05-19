class Gerente : Funcionario
{
    public string Usuario { get; set; }
    public string Senha { get; set; }

    public override double CalculaBonificacao()
    {
        return this.Salario * 0.6 + 100;
    }

    public override void MostraDados()
    {
        base.MostraDados();
        System.Console.WriteLine("Usuário: " + this.Usuario);
        System.Console.WriteLine("Senha: " + this.Senha);
    }
}