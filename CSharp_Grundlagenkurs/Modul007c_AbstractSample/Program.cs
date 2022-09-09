namespace Modul007c_AbstractSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);

            Circle circle = new Circle(2.5);

            Zylinder zylinder = new Zylinder(2.5, 5);

            Console.WriteLine(square.GetArea());
            Console.WriteLine(circle.GetArea());
            Console.WriteLine(zylinder.GetArea());


            List<string> cityNamesList = new List<string>();
            cityNamesList.Add("Berlin");
            cityNamesList.Add("Hamburg");


            //Polymoprhie

            List<Shape> geoformListe = new List<Shape>();

            geoformListe.Add(square);
            geoformListe.Add(circle);
            geoformListe.Add(zylinder);


            double gesamtFlaecherAllerGeoFormen = 0;

            foreach (Shape shape in geoformListe)
            {
                gesamtFlaecherAllerGeoFormen += shape.GetArea();
            }
            Console.WriteLine(gesamtFlaecherAllerGeoFormen);
        }
    }

    #region Beispiel 1
    //ABSTRACT definiert eine Klasse als abstrakt. D.h. von dieser Klasse können keine Objekte mehr instanziiert werden,
    //sie dient nur noch als Mutterklasse
    public abstract class Lebewesen
    {
        public string Lieblingsnahrung { get; set; }


        //Abstrakte Methoden dürfen nur in abstrakten Klassen existieren und definieren nur
        ///eine Signatur. Die erbenden Klassen werden gezwungen eine Implementierung vorzunehmen
        public abstract void Essen();
    }

    public class Mensch : Lebewesen
    {
        public override void Essen()
        {
            Console.WriteLine($"Der Mensch konsumiert {this.Lieblingsnahrung}");
        }
    }

    public class Wels : Lebewesen
    {
        public override void Essen()
        {
            Console.WriteLine($"Der Wels mahlt  {this.Lieblingsnahrung}");
        }
    }
    #endregion


    #region Beispiel2
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Square : Shape
    {
        private double side;
        private double _variablenamen;

        public Square(double side)
        {
            this.side = side;
        }
        public override double GetArea()
        {
            return side * side;
        }
    }

    public class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Zylinder : Shape
    {
        double radius;
        double hoehe;

        public Zylinder(double radius, double hoehe)
        {
            this.radius = radius;
            this.hoehe = hoehe;
        }

        public override double GetArea()
        {
            return 2 * Math.PI * radius * radius + 2 * Math.PI * radius * radius;
        }
    }
    #endregion
}