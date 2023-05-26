namespace heranca_polimorfismo;
class Program
{
    static void Main(string[] args)
    {
        Gato n1 = new Gato();
        Cão n2 = new Cão();
        Homem n3 = new Homem();

        n1.Nome = "Gato";
        n1.Fala = "Miau";
        n2.Nome = "Cão";
        n2.Fala = "Au au";
        n3.Nome = "Homem";
        n3.Fala = "Oi";

        
        Console.WriteLine(n1.Nome + " : " + n1.Fala);
        Console.WriteLine(n2.Nome + " : " + n2.Fala);
        Console.WriteLine(n3.Nome + " : " + n3.Fala);
    }
}
