class Telefonista : Funcionario
{
    public int EstacaoDeTrabalho { get; set; }

    public override void MostraDados()
    {
        base.MostraDados();
        System.Console.WriteLine("Estação de Trabalho: " + this.EstacaoDeTrabalho);
    }
}