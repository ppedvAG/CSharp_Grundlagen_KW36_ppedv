namespace Modul010Demo_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fritz ist 16 Jahre alt und hat eine ToDo-Liste, welche Orte er im Jahrmarkt besuchen möchte
            List<Jahrmarktstand> jahrmarktstandeDieFritzBesucht = new List<Jahrmarktstand>();
            jahrmarktstandeDieFritzBesucht.Add(new AutoScooter() { Name = "AutoScooter 2000"});
            jahrmarktstandeDieFritzBesucht.Add(new HorrorCabinet() { Name = "Fredy Krüger Show"});
            jahrmarktstandeDieFritzBesucht.Add(new HoechsteAchterbahnDerWelt() { Name = "Schnellste Achterbahn der Welt" });
            jahrmarktstandeDieFritzBesucht.Add(new Wildwasserbahn() { Name = "Wildwasserspaß" });
            jahrmarktstandeDieFritzBesucht.Add(new Streichelzoo() { Name = "Liebe Tiere" });


            foreach (Jahrmarktstand aktuellerJahrmarktstand in jahrmarktstandeDieFritzBesucht)
            {
                //befindet sich das Interface IFSKCheck beim aktuellen Stand
                if (aktuellerJahrmarktstand is IFSK18Check fskCheck)
                {
                    if (fskCheck.CheckAge(16))
                    {
                        Console.WriteLine($"Fritz darf {aktuellerJahrmarktstand.Name} besuchen");
                    }
                    else
                        Console.WriteLine($"Fritz ist für {aktuellerJahrmarktstand.Name} zu jung");
                }

                //SO BITTE NICHT
                //if (aktuellerJahrmarktstand is HoechsteAchterbahnDerWelt achterbahn)
                //{
                //    if (achterbahn.CheckAge(16))
                //    {
                //        Console.WriteLine($"Fritz darf {aktuellerJahrmarktstand.Name} besuchen");
                //    }
                //    else
                //        Console.WriteLine($"Fritz ist für {aktuellerJahrmarktstand.Name} zu jung");
                //}
            }
        }
    }

    public interface IFSK18Check
    {
        bool CheckAge(int alter);
    }

    public interface IToilets
    {
        int ToiletenAnzahl { get; set; }
    }

    public class Jahrmarktstand
    {
        public string Name { get; set; }
        public double FlacheInQuatratmeter { get; set; }
        public int Mitarbeiteranzahl { get; set; }

        public DateTime Öffnet { get; set; }
        public DateTime Schließt { get; set; }
    }

    

    public class AutoScooter : Jahrmarktstand
    {
        public int Autoanzahl { get; set; }
        public int FahrdauerInSek { get; set; }

    }

    public class HorrorCabinet : Jahrmarktstand, IFSK18Check
    {
        public int VerkleideteMitarbeiter { get; set; }

        public bool CheckAge(int alter)
        {
            return alter < 18 ? false : true;
        }
    }

    public class HoechsteAchterbahnDerWelt : Jahrmarktstand, IFSK18Check
    {
        public double Hoehe { get; set; }
        public int LaengeDerAchterbachn { get; set; }

        public int MaxKmhGeschwindigkeit { get; set; }

        public bool CheckAge(int alter)
        {
            return alter < 18 ? false : true;
        }
    }

    public class Wildwasserbahn : Jahrmarktstand
    {
        public int LaengeDerWildwasserbahn { get; set; }

        public int PersonenImWagen { get; set; }
    }

    public class Streichelzoo : Jahrmarktstand, IToilets
    {
        public int AnzahlDerTiere { get; set; }
        public int ToiletenAnzahl { get; set; }
    }
}