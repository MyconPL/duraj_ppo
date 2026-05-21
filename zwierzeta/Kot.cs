namespace zwierzeta;

public class Kot : Zwierze
{
    public Kot(string nazwa, int wiek) : base(nazwa, wiek) { }
    public override void Dzwiek()
    {
        Console.WriteLine("Meow meow nigga");
    }

    public override string Gatunek()
    {
        return "To kot. Zamiast whiskas wpierdziela whisky";
    }
}