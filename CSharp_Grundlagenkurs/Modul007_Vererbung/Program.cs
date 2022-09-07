namespace Modul007_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensch mensch = new Mensch("Otto", "Walkes", null, "Mensch", 80, new DateTime(1965, 7, 3), 10);

            Mensch mensch1 = new Mensch("Junior Otto", "Walkes", mensch, "Mensch", 80, new DateTime(1965, 7, 3), 10);

            Console.WriteLine(Mensch.ZeigeAnzahlLebewesen());
        }
    }

    public class Lebewesen
    {
        public DateTime Geburtsdatum { get; set; }
        public string Bezeichnung { get; set; }
        public double Gewicht { get; set; }

        public double Groeße { get; set; }

        #region statische Variablen und Methoden
        //statische Property mit dem DEfault-Wert 0
        public static int AnzahlLebewesen { get; set; } = 0;

        public static string ZeigeAnzahlLebewesen()
        {
            return $"Es gibt {AnzahlLebewesen} Lebewesen";
        }
        #endregion

        #region Konstruktoren
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)

        public Lebewesen()
        {
            //Geburtsdatum = DateTime.Now;
            //Gewicht = 0;
            //Name = String.Empty;
            AnzahlLebewesen++;
        }

        public Lebewesen(string name, double gewicht, DateTime geb)
            : this()
        {
            Geburtsdatum = geb;
            Bezeichnung = name;
            Gewicht = gewicht;
        }

        public Lebewesen(string name, double gewicht, DateTime geb, double groeße)
            : this(name, gewicht, geb) //Aufruf von Konstruktor -> public Lebewesen(string name, double gewicht, DateTime geb)
        {

            Groeße = groeße;
        }

        //Default-Konstruktor -> Default-Werte werden gesetzt


        public Lebewesen(Lebewesen otherLebewesen)
            : this()
        {
            Bezeichnung = otherLebewesen.Bezeichnung;
            Gewicht = otherLebewesen.Gewicht;
            Geburtsdatum = otherLebewesen.Geburtsdatum;
        }
        #endregion

        public void Atmen()
            => Console.WriteLine($"{Bezeichnung} atmet");
    }

    public class Mensch : Lebewesen
    {
       

        public Mensch(string vorname, string nachname, Mensch mutter, string name, double gewicht, DateTime geb, double groeße) 
            : base(name, gewicht, geb, groeße)
        {
            Vorname = vorname;
            Nachname = nachname;
            Mutter = mutter; 
        }

        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public Mensch Mutter { get; set; }


        

        public void Sprechen ()
        {
            Console.WriteLine($"{Vorname} sagt etwas");
        }
    }
}