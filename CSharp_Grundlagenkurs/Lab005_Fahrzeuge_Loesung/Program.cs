namespace Lab005_Fahrzeuge_Loesung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }


    public class Fahrzeug
    {
        #region Lab 06: Properties, Methoden, Konstruktor

        //Properties
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public bool MotorLäuft { get; set; }

        //Konstruktor mit Übergabeparametern und Standartwerten
        public Fahrzeug(string name, int maxG, double preis)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLäuft = false;
        }

        //Methode zum Beschleunigen und Bremsen
        public void Beschleunige(int a)
        {
            //Beschleunigt werden kann nur bei einem Motor der läuft
            if (this.MotorLäuft)
            {
                //Prüfung dass die Zielbeschleunigung nicht der MaxGeschwindigkeit übersteigt. 
                //Wenn Zielbeschleunigung höher als MaxGeschwindigkeit, wird MaxGeschwinigkeit der AktGeschwindigkeit zugeordnet
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0) // Dieser Fall ist eher selten, aber es wäre auch Möglich beim Beschleunigen einen negativen Wert zu übergeben
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;

                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
            }
        }

        #endregion
    }
}