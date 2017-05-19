class Conta
{
    public int numero;
    public double saldo;
    public double limite = 100;

    public Agencia agencia;

    public Conta(Agencia agencia)
    {
        this.agencia = agencia;
    }

    public void transfere(Conta destino, double valor)
    {
        this.saldo -= valor;
        destino.saldo += valor;
    }

    public void deposita(double valor)
    {
        this.saldo += valor;
    }

    public void saca(double valor)
    {
        this.saldo -= valor;
    }

    public void imprimeExtrato()
    {
        System.Console.WriteLine("Saldo: " + this.saldo);
    }

    public double consultaSaldoDisponivel()
    {
        return this.saldo + this.limite;
    }
}