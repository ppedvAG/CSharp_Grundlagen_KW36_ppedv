namespace Modul005Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Klasse, Felder, Properties
            //Deklaration des Datentypes bzw der Klasse
            Lebewesen lebewesen1;

            //Instanziierung -> Aus der Klasse Lebewesen wir ein Objekt mit dem Zugriffsvariable (Instanz) lebewesen1
            lebewesen1 = new Lebewesen();

            //So bitte nie!
            //lebewesen.Gewicht = -1;

            //Ganz alte Variante 
            Lebewesen lebewesen = new Lebewesen();
            lebewesen.SetName("Donald Duck");
            string nameDesLebewesens = lebewesen.GetName();
            
            //Properties 
            lebewesen.Name = "Otto Walkes";
            string nameOfLebewesen = lebewesen.Name; //Get
            #endregion

            #region Konstruktor
            Modul005DemoB.Lebewesen lebewesen2 = new Modul005DemoB.Lebewesen();

            lebewesen2.Name = "Hund";
            lebewesen2.Gewicht = 2;
            lebewesen2.Geburtsdatum = DateTime.Now;


            //Werte-Konstruktor
            Modul005DemoB.Lebewesen lebewesen3 = new Modul005DemoB.Lebewesen("Katze", 3, DateTime.Now);

            //Default-Konstruktor
            Modul005DemoB.Lebewesen lebewesen4 = new Modul005DemoB.Lebewesen();


            #region Reference vs Kopier-Konstruktor
            Modul005DemoB.Lebewesen lebewesen5; 
            lebewesen5 = lebewesen3; //Lebewesen3 gibt seine Speicheradresse an Lebewesen5
            lebewesen5.Name = "Garfield"; //BEdeutet: Alle Änderungen an Lebewesen5 wird auch auf Lebewesen3 erfolgen (selbe Speicheradresse) 

            //Kopier-Konstruktor überträgt die Werte eines Objektes in ein Anderes Objekt (mit eigener Speicheradresse
            Modul005DemoB.Lebewesen lebewesen6 = new Modul005DemoB.Lebewesen(lebewesen5);
            lebewesen6.Name = "Gestiefelter Kater";
            #endregion


            #region Veketten von Konstruktoren
            Modul005DemoB.Lebewesen lebewesen7 = new Modul005DemoB.Lebewesen("Garfield", 20, DateTime.Now, 1);
            #endregion
            #endregion

        }
    }



    public class Lebewesen
    {
        #region Member-Variablen
        //Variablen in einer Klasse werden klein geschrieben und sind keine public Variablen
        //public double gewicht;

        private string name;
        
        private DateTime geburtsDatum;


        #endregion


        #region Zeiten von C++ / frühe Zeiten von C#

        //Wurde früher verwendet
        //hat weniger Potenzial als Properties 

        /// <summary>
        /// Member-Variable name wird gesetzt
        /// </summary>
        /// <param name="name">Neuer Name</param>
        public void SetName(string name)
        {
            // Wenn name eine Bennenung enthält, wird der Name gesetzt 
            if (!string.IsNullOrEmpty(name))
                this.name = name;
        }

        /// <summary>
        /// Member-Variable 'name' wird ausgelesen
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        #endregion


        #region Properties
        //Klassische Verwendung einer Property mit MemberVariablen (Kapselung)
        public string Name
        {
            get { return name; }

            //value ist der Platzhalter, für den Wert der zur Variable Name zugewiesen wird 
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }

        //Auto-Property
        //Member-Variable wird beim kompilieren vom Kompilier intern angelegt
        public double Gewicht { get; set; }

        #region Auto-Property -> Nach Klassicher Property
        // Vorher: public double Groeße { get; set; }

        //Nachher:
        //Gehört eigentlich zu den Klassen-Variablen
        //bleibt für das sperate Beispiel, aber hier stehen
        private double groeße; 

        public double Groeße 
        { 
            get
            {
                return groeße;
            }
            
            set
            {
                if (value > 0)
                    groeße = value;
            }
        }
        #endregion
        #endregion


        #region Klassen Methoden
        //Klassen-Methoden
        public void Atmen()
        {
            Console.WriteLine("Lebewesen atmet");
        }
        #endregion
    }


    public class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName 
        { 
            get => lastName; 
            set => lastName = value; 
        }

        //Readonly Property nur mit einem Get 
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
    }
}