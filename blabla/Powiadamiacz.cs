namespace Powiadomienia;

/// <summary>
/// Agreguje kanały powiadomień i rozsyła wiadomości do wszystkich zarejestrowanych kanałów.
/// Działa wyłącznie na interfejsie IKanalPowiadomien — nie zna konkretnych implementacji.
/// </summary>
public class Powiadamiacz
{
    private readonly List<IKanalPowiadomien> _kanaly = [];

    public void DodajKanal(IKanalPowiadomien kanal)
    {
        ArgumentNullException.ThrowIfNull(kanal);
        _kanaly.Add(kanal);
    }

    public void RozeslijWszystkim(string tytul, string tresc)
    {
        foreach (var kanal in _kanaly)
        {
            kanal.Wyslij(tytul, tresc);
            Console.WriteLine();
        }
    }

    public void ListaKanalow()
    {
        if (_kanaly.Count == 0)
        {
            Console.WriteLine("Brak zarejestrowanych kanałów.");
            return;
        }

        Console.WriteLine("Zarejestrowane kanały:");
        for (int i = 0; i < _kanaly.Count; i++)
            Console.WriteLine($"  {i + 1}. {_kanaly[i].NazwaKanalu()}");
    }
}
