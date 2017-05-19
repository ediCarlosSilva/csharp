class TestaContaEAgencia
{
    static void Main(string[] args)
    {
        Agencia a = new Agencia(178);
        Conta c = new Conta(a);

        //a.numero = 178;

        c.numero = 123;
        c.saldo = 1000.0;
        c.limite = 500;

        System.Console.WriteLine("Dados da agência");
        System.Console.WriteLine("Número: " + a.numero);

        System.Console.WriteLine("\n-----------------------\n");

        System.Console.WriteLine("Dados da Conta");
        System.Console.WriteLine("Número: " + c.numero);
        System.Console.WriteLine("Saldo: " + c.saldo);
        System.Console.WriteLine("Limite: " + c.limite);

        System.Console.WriteLine("\n------------------------\n");

        //c.agencia = a;

        System.Console.WriteLine("Dados da agência obtidos através da conta");
        System.Console.WriteLine(c.agencia.numero);
    }
}