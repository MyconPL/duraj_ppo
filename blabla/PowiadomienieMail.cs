namespace Powiadomienia.Kanaly;

public class PowiadomienieMail : IKanalPowiadomien
{
    private readonly string _adresEmail;

    public PowiadomienieMail(string adresEmail)
    {
        if (string.IsNullOrWhiteSpace(adresEmail))
            throw new ArgumentException("Adres e-mail nie może być pusty.", nameof(adresEmail));

        _adresEmail = adresEmail;
    }

    public void Wyslij(string tytul, string tresc)
    {
        Console.WriteLine($"Do:      {_adresEmail}");
        Console.WriteLine($"Temat:   {tytul}");
        Console.WriteLine($"Treść:   {tresc}");
    }

    public string NazwaKanalu() => $"E-mail ({_adresEmail})";
}
