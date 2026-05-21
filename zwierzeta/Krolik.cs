namespace zwierzeta;

public class Krolik : Zwierze
    {
        public Krolik(string imie, int wiek) : base(imie, wiek)
        {
            Imie = imie;
            Wiek = wiek;
        }
        
        
        public string Imie { get; set; }
        public override void Dzwiek()
        {
            Console.WriteLine("Skacze jak twoj stary po browca do biedry");
        }

        public override string Gatunek()
        {
            return "Krolik";
        }
    }