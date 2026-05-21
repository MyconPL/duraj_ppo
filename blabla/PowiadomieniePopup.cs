namespace Powiadomienia.Kanaly;

public class PowiadomieniePopup : IKanalPowiadomien
{
    public void Wyslij(string tytul, string tresc)
    {
        int szerokosc = Math.Max(tytul.Length, tresc.Length) + 4;
        string linia = new string('═', szerokosc);

        Console.WriteLine($"╔{linia}╗");
        Console.WriteLine($"║  {tytul.PadRight(szerokosc - 2)}║");
        Console.WriteLine($"╠{linia}╣");
        Console.WriteLine($"║  {tresc.PadRight(szerokosc - 2)}║");
        Console.WriteLine($"╚{linia}╝");
    }

    public string NazwaKanalu() => "Popup";
}
