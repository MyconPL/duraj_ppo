namespace Powiadomienia;


public interface IKanalPowiadomien
{
    void Wyslij(string tytul, string tresc);
    string NazwaKanalu();
}
