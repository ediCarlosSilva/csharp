class OrdenaArgumentos
{
    static void Main(string[] args)
    {
        System.Array.Sort(args);

        foreach (string arg in args)
        {
            System.Console.WriteLine(arg);
        }
    }
}