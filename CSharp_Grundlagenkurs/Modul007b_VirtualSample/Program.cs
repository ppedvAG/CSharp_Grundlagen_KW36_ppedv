namespace Modul007b_VirtualSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund = new Hund();

            Console.WriteLine(hund.Kommunikation());
            Console.WriteLine(hund.ToString());


            Hund hund1 = new Hund();
            hund1.Name = "Bello";

            Hund hund2 = new Hund();
            hund2.Name = "Bello";


            if (hund1 == hund2)
            {
                Console.WriteLine("gleich");
            }
            else
                Console.WriteLine("ungleich");


            if (hund1.Equals(hund2))
            {
                Console.WriteLine("gleich");
            }
            else
                Console.WriteLine("ungleich");



            Dackel dackel = new Dackel();
            dackel.Name = "Bello";

            Console.WriteLine(dackel.Kommunikation());
        }
    }

    /* - virtual hat eine Implementierung
     * - virtual steht 'meist' in einer Basisklasse
     * - Die abgeleitete Klasse (Vererbte Klasse) kann eine virtual - Methode mit override spezialisieren
     * 
     * Zu spezialisieren:
     * - komplett neue Implementierung
     * - kombination mit der virtual-Implementierung
     */

    public class Lebewesen
    {
        public virtual string Name { get; set; }

        public virtual string Kommunikation ()
        {
            return $"Lebewesen kommuniziert";
        }
    }

    public class Vogel : Lebewesen
    {
        public override string Kommunikation()
        {
            //Wir ersetzten hier die Logik von Kommunikation komplett 
            return $"Der Vogel zwitschert";
        }
    }



    public class Hund : Lebewesen
    {
        private string name;

        public override string Name 
        { 
            get => name;

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        public override string Kommunikation()
        {
            string könntenBasisLogikAufrufen = base.Kommunikation(); //Lebewesen.Kommunikation()

            return $"Der Hund bellt";
        }


        public override string ToString()
        {
            return $"Variablenausgabe der Klasse Hund+Lebewesen";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)    
                throw new ArgumentNullException(nameof(obj)); //Parameter ist leer

            Hund otherDog = (Hund)obj;

            if (this.Name != otherDog.Name)
                return false;

            //..... weitere Prüfungen auf Variablen-Ebene

            return true;
        }
    }


    public class Dackel : Hund
    {
        //public override string Kommunikation()
        //{
        //    return "Macht Dackel-Wuff Wuff";
        //}
    }
}