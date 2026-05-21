namespace zwierzeta;

public class Krolik : Zwierze
    {
        public Krolik(string imie, int wiek) : base(imie, wiek) { }

        public override void Dzwiek()
        {
            Console.WriteLine($"{imie}: Chrup chrup!");
        }

        public override string Gatunek()
        {
            return "Krolik";
        }
    }

}