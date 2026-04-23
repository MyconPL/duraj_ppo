namespace zwierzeta;

public class Zwierze
{
    public Zwierze(string nazwa, int wiek)
    {
        Nazwa = nazwa;
        Wiek = wiek;
    }

    private string Nazwa { get; set; }
    private int Wiek { get; set; }

    public void WydajDziwek()
    {
        Console.WriteLine(Nazwa + " wydał dziwek");
    }

    public void PrzedstawSie()
    {
        Console.WriteLine("czesc, jestem " + Nazwa + ", mam " + Wiek + " lata");
    }
}
