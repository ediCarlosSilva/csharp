class Media
{
    static void Main(string[] args)
    {
        double soma = 0;
        double media;
        int quantidade = args.Length;
        for (int i = 0; i < args.Length; i++)
        {
            soma += System.Convert.ToDouble(args[i]);
        }

        if (soma != 0)
        {
            media = soma / quantidade;
            System.Console.WriteLine("Média = " + media);
        }
    }
}