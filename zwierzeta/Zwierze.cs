namespace zwierzeta;

public abstract class Zwierze
{
    protected Zwierze(string imie, int wiek)
    {
        Imie = imie;
        Wiek = wiek;
    }

    protected string Imie { get; set; }
    protected int Wiek { get; set; }

    public abstract void Dzwiek();
    public abstract string Gatunek();

    //public void WydajDziwek()
    //{
    //    Console.WriteLine(Nazwa + " wydał dziwek");
    //}

    public void PrzedstawSie()
    {
        Console.WriteLine($"{Imie} ({Gatunek()}), wiek: {Wiek} lat");
    }

   ~Zwierze()
    {
        //desteruktor 
    }
}
