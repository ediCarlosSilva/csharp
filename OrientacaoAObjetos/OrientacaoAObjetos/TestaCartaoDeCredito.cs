class TestaCartaoDeCredito
{
    static void Main(string[] args)
    {
        CartaoDeCredito cdc1 = new CartaoDeCredito(11111);
        //cdc1.numero = 111111;
        cdc1.dataDeValidade = "01/01/2013";

        CartaoDeCredito cdc2 = new CartaoDeCredito(22222);
        //cdc2.numero = 222222222;
        cdc2.dataDeValidade = "01/01/2014";

        System.Console.WriteLine("Dados do primeiro cartão");
        System.Console.WriteLine("Número: " + cdc1.numero);
        System.Console.WriteLine("Data de validade: " + cdc1.dataDeValidade);

        System.Console.WriteLine("-----------------------------------------");

        System.Console.WriteLine("Dados do segundo cartão");
        System.Console.WriteLine("Número: " + cdc2.numero);
        System.Console.WriteLine("Data de validade: " + cdc2.dataDeValidade);
    }
}