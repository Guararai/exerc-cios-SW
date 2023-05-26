public class Contrato_pessoa_fisica:Contrato
{
    private string cpf;
    private int idade;

    public Contrato_pessoa_fisica(string detalhes,string email, double valor, string telefone, string nome, string cpf, int idade, int prazo)
        : base(detalhes, email, valor, telefone, nome, prazo)
    {
        this.cpf = cpf;
        this.idade = idade;
    }

     public override double Calcular_prestacao()
    {
        double prestacao = base.Calcular_prestacao();
        double adicional = 0.0;

        if (idade <= 30)
            adicional = 1.0;
        else if (idade <= 40)
            adicional = 2.0;
        else if (idade <= 50)
            adicional = 3.0;
        else if (idade > 50)
            adicional = 4.0;

        return prestacao + adicional;
    }

    public override void exibir()
    {
        base.exibir();
        Console.WriteLine("CPF : " + cpf);
        Console.WriteLine("Idade : " + idade);
    }
}
