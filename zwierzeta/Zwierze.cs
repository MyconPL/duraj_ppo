namespace zwierzeta;

public abstract class Zwierze
{
    protected Zwierze(string nazwa, int wiek) { }

    private string Nazwa { get; set; }
    private int Wiek { get; set; }

    public abstract void Dzwiek();
    public abstract string Gatunek();

    //public void WydajDziwek()
    //{
    //    Console.WriteLine(Nazwa + " wydał dziwek");
    //}

    public void PrzedstawSie()
    {
        Console.WriteLine("czesc, jestem " + Nazwa + ", mam " + Wiek + " lata");
    }

   ~Zwierze()
    {
        //desteruktor 
    }
}
