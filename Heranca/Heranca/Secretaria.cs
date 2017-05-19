class Secretaria : Funcionario
{
    public int Ramal { get; set; }

    public override void MostraDados()
    {
        base.MostraDados();
        System.Console.WriteLine("Ramal: " + this.Ramal);
    }
}