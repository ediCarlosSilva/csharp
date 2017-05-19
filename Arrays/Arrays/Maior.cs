class Maior
{
    static void Main(string[] args)
    {
        double maior = 0;

        for ( int i = 0; i < args.Length; i++)
        {
            if (System.Convert.ToDouble(args[i]) > maior)
            {
                maior = System.Convert.ToDouble(args[i]);
            }
        }

        System.Console.WriteLine("O maior número passado foi: " + maior);
    }
}