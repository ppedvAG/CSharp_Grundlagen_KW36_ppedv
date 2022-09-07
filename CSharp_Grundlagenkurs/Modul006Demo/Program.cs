namespace Modul006Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lebewesen lebewesen = new Lebewesen();

            Lebewesen lebewesen2 = new Lebewesen("Gestiefelter Kater", 5, DateTime.Now);
            Lebewesen lebewesen3 = new Lebewesen("Garfield", 20, DateTime.Now, 1);

            string ausgabe = Lebewesen.ZeigeAnzahlLebewesen();
            Console.WriteLine(ausgabe);


            #region andere Statische Methoden oder Properties

            string str = "Hallo;Ich;Bin;Ein;CSV;Eintrag";

            //Methoden: Substring, Trim, Replace -> Verarbeiten direkt einen String-> bzw.seine Zeichenkette
            string[] csvParts = str.Split(';');
            //str.Substring
            //str.Trim
            //str.Replace

            string str = string.Empty; //str ="";

            if (string.IsNullOrEmpty(str))
            {

            }
            #endregion

        }
    }

    public class Lebewesen
    {
        public DateTime Geburtsdatum { get; set; }
        public string Name { get; set; }
        public double Gewicht { get; set; }

        public double Groeße { get; set; } 


        //statische Property mit dem DEfault-Wert 0
        public static int AnzahlLebewesen { get; set; } = 0;
        
        public static string ZeigeAnzahlLebewesen()
        {
            return $"Es gibt {AnzahlLebewesen} Lebewesen";
        }


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
            :this()
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
            :this()
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