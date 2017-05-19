class TestaConta
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

        c.Numero = 123;
        c.Saldo = 3000;
        c.Limite = 5000;

        System.Console.WriteLine(c.Numero);
        System.Console.WriteLine(c.Saldo);
        System.Console.WriteLine(c.Limite);
    }
}