using Powiadomienia;
using Powiadomienia.Kanaly;

Powiadamiacz powiadamiacz = new Powiadamiacz();
powiadamiacz.DodajKanal(new PowiadomienieSMS("+48 600 123 456"));
powiadamiacz.DodajKanal(new PowiadomienieMail("jan.kowalski@example.com"));
powiadamiacz.DodajKanal(new PowiadomieniePopup());

powiadamiacz.ListaKanalow();
Console.WriteLine(new string('-', 50));

powiadamiacz.RozeslijWszystkim(
    tytul: "Nowe zamówienie",
    tresc: "Zamówienie #1042 zostało złożone.");
