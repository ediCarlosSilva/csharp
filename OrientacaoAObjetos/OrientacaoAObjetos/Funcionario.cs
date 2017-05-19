class Funcionario
{
    public string nome;
    public double salario;

    public void aumentarSalario(double valor)
    {
        this.salario += valor;
    }

    public string consultaDados()
    {
        return "Nome: " + this.nome + "\nSalário: " + this.salario;
     }



}