namespace zwierzeta;

public class Program
{
    

    public static void Main(string[] args)
    {
        Zwierze[] schronisko =
        {
            new Pies("Burek", 3),
            new Kot("Mruczek", 2),
            new Krolik("Skoczek", 1),
            new Pies("Reksio", 5)
        };
        
        foreach (Zwierze zwierze in schronisko)
        {
            zwierze.PrzedstawSie();
            zwierze.Dzwiek();
            Console.WriteLine();
        }
    }
    
}