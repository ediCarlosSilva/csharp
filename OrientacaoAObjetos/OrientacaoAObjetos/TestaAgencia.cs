﻿class TestaAgencia
{
    static void Main(string[] args)
    {
        Agencia a1 = new Agencia(1234);
        //a1.numero = 1234;

        Agencia a2 = new Agencia(5678);
        //a2.numero = 5678;

        System.Console.WriteLine("Dados da primeira agência");
        System.Console.WriteLine("Número: " + a1.numero);

        System.Console.WriteLine("---------------------------------");

        System.Console.WriteLine("Dados da segunda agência");
        System.Console.WriteLine("Número: " + a2.numero);
    }
}