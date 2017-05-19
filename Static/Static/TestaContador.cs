class TestaContador
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Contador: " + Conta.contador);

        Conta c1 = new Conta();

        //System.Console.WriteLine("Contador: " + Conta.contador);
        System.Console.WriteLine("Número da primeira conta: " + c1.numero);

        System.Console.WriteLine("Contador: " + Conta.contador);

        Conta c2 = new Conta();

        //System.Console.WriteLine("Contador: " + Conta.contador);
        System.Console.WriteLine("Número da segunda conta: " + c2.numero);

        System.Console.WriteLine("Contador: " + Conta.contador);

        Conta.ZeraContador();
        System.Console.WriteLine("Contador: " + Conta.contador);

    }
}