namespace zwierzeta;

public class Pies : Zwierze
{
    public Pies(string nazwa, int wiek) : base(nazwa, wiek) { }
    public override void Dzwiek()
    {
        throw new NotImplementedException();
    }

    public override string Gatunek()
    {
        return "To jest pies (chyba). Chinczyk go zjad";
    }
}

