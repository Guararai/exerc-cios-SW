public class Contrato
{
   

    protected string detalhes;
    protected string email;
    protected double valor;
    protected string telefone;
    protected string nome;
    protected int prazo;

    public Contrato(string detalhes, string email, double valor,string telefone, string nome, int prazo)
    {
      this.detalhes = detalhes;
      this.email = email;
      this.valor = valor;
      this.telefone = telefone;
      this.nome = nome;
      this.prazo = prazo;
    
    

    }
   

    public virtual void exibir()
    {
        Console.WriteLine("Nome : " + nome);
         Console.WriteLine("Valor : " + valor);
        Console.WriteLine("Detalhes : " + detalhes);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Telefone : " + telefone);
       
    }
       public virtual double Calcular_prestacao()
    {
        return valor / prazo;
    }
}