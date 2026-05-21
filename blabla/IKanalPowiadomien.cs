namespace Powiadomienia;

/// <summary>
/// Interfejs reprezentujący kanał do wysyłania powiadomień.
/// Powiadamiacz nie wie, z jakiej implementacji korzysta.
/// </summary>
public interface IKanalPowiadomien
{
    void Wyslij(string tytul, string tresc);
    string NazwaKanalu();
}
