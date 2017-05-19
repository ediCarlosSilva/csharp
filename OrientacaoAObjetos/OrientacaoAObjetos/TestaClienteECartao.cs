class TestaClienteECartao
{
    static void Main(string[] args)
    {
        Cliente c = new Cliente();
        CartaoDeCredito cdc = new CartaoDeCredito(112333);

        c.nome = "Edi Carlos";
        c.codigo = 123;

        //cdc.numero = 111111;
        cdc.dataDeValidade = "12/12/18";

        System.Console.WriteLine("Dados do Cliente");
        System.Console.WriteLine("Nome: " + c.nome);
        System.Console.WriteLine("Código: " + c.codigo);

        System.Console.WriteLine("\n---------------------------------------------\n");

        System.Console.WriteLine("Dados do Cartão");
        System.Console.WriteLine("Número: " + cdc.numero);
        System.Console.WriteLine("Data de Validade: " + cdc.dataDeValidade);

        System.Console.WriteLine("\n----------------------------------------\n");

        cdc.cliente = c;

        System.Console.WriteLine("Dados do cliente obtidos através do cartão");
        System.Console.WriteLine(cdc.cliente.nome);
        System.Console.WriteLine(cdc.cliente.codigo);
    }
}