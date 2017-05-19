using System;

class GeradorDeExtrato
{
    public void ImprimeExtratoBasico(Conta c)
    {
        DateTime agora = DateTime.Now;
        string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        Console.WriteLine("DATA: " + horario);
        Console.WriteLine("Saldo: " + c.Saldo);
    }
}