namespace Powiadomienia.Kanaly;

public class PowiadomienieSMS : IKanalPowiadomien
{
    private readonly string _numer;

    public PowiadomienieSMS(string numer)
    {
        if (string.IsNullOrWhiteSpace(numer))
            throw new ArgumentException("Numer telefonu nie może być pusty.", nameof(numer));

        _numer = numer;
    }

    public void Wyslij(string tytul, string tresc)
    {
        Console.WriteLine($"SMS na nr {_numer}: {tytul} - {tresc}");
    }

    public string NazwaKanalu() => $"SMS ({_numer})";
}
