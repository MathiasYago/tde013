

public class Empresa
{
    private List<Funcionario> Funcionarios;
    
    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }
    public void ListerFuncionarios()
    {
        foreach(var funcionario in Funcionarios)
        {
            Console.WriteLine($"Nome do funcionario: {funcionario.Nome}");
            Console.WriteLine($"o salario do funcionario: {funcionario.CalcularSalario()}");
        }
    }
}
