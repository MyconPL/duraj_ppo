namespace zwierzeta;

public class Program
{
    public static void Main(string[] args)
    {
        Zwierze[] schronisko =
        {
            new Pies("Dog", 3),
            new Kot("Nygus", 2),
            new Krolik("Kaninchen", 1),
            new Krolik("Czarny krolik", 5)
        };
        
        foreach (Zwierze zwierze in schronisko)
        {
            zwierze.PrzedstawSie();
            zwierze.Dzwiek();
            Console.WriteLine();
        }
    }
    
}