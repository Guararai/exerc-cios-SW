namespace exercicio_2;
class Program
{
    static void Main(string[] args)
    {

        Contrato_pessoa_juridica Contrato_pessoa_juridica = new Contrato_pessoa_juridica("contrato de pessoa jurídica","juridico@gmail.com",150000,"(11) 99999-9999","Brian Souza dos Santoss","12.345.678/0001-00", "123456789", "Nibri Móveis", 24);
        Contrato_pessoa_juridica.exibir();
       Console.WriteLine("Valor da prestação : " + Contrato_pessoa_juridica.Calcular_prestacao());
       

  Console.WriteLine("-------------------------------------------");

        Contrato_pessoa_fisica Contrato_pessoa_fisica = new Contrato_pessoa_fisica("contrato de pessoa física","fisico@gmail.com",10000,"(11) 00000-0000","Davi dos Santos", "123.456.789-00", 19, 12);
        Contrato_pessoa_fisica.exibir();
        Console.WriteLine("Valor da prestação : " + Contrato_pessoa_fisica.Calcular_prestacao());
        Console.WriteLine();


    }
        
    
}

