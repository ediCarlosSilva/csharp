class TestaMetodosConta
{
    static void Main(string[] args)
    {
        Agencia a = new Agencia(123);

        Conta c = new Conta(a);

        System.Console.WriteLine("Chamando o método deposita passando o valor 1000");
        c.deposita(1000);
        c.imprimeExtrato();

        System.Console.WriteLine("\n-----------------------\n");

        System.Console.WriteLine("Chamando o método saca passando o valor 100");
        c.saca(100);
        c.imprimeExtrato();

        System.Console.WriteLine("\n-----------------------\n");

        double saldoDisponivel = c.consultaSaldoDisponivel();
        System.Console.WriteLine("SALDO DISPONÍVEL: " + saldoDisponivel);
    }
}