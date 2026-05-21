namespace Powiadamiacz;

public class PowiadomienieSMS : IKanalPowiadomien
{
    private int numer;
    public void Wyslij(string tytul, string tresc)
    {
        Console.WriteLine($"Powiadomienie na nr {numer}: {tytul} - {tresc}");
    }

    public string NazwaKanalu()
    {
        throw new NotImplementedException();
    }
}