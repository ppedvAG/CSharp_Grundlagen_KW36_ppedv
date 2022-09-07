namespace Modul007_Vererbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Lebewesen
    {
        public DateTime Geburtsdatum { get; set; }
        public string Name { get; set; }
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
            Name = name;
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
            Name = otherLebewesen.Name;
            Gewicht = otherLebewesen.Gewicht;
            Geburtsdatum = otherLebewesen.Geburtsdatum;
        }
        #endregion

        public void Atmen()
            => Console.WriteLine($"{Name} atmet");



    }
}