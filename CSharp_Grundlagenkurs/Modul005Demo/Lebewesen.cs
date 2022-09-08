using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul005DemoB
{
    //Klassen sind Referentzyp
    public class Lebewesen
    {
        public DateTime Geburtsdatum { get; set; }
        public string Name { get; set; }
        public double Gewicht { get; set; }

        public double Groeße { get; set; }

        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
       
        public Lebewesen(string name, double gewicht, DateTime geb)
        {
            Geburtsdatum = geb;
            Name = name;
            Gewicht = gewicht;
        }

        public Lebewesen(string name, double gewicht, DateTime geb, double groeße)
            :this(name, gewicht, geb) //Aufruf von Konstruktor -> public Lebewesen(string name, double gewicht, DateTime geb)
        {
            
            Groeße = groeße;
        }

        //Default-Konstruktor -> Default-Werte werden gesetzt
        public Lebewesen()
        {
            Geburtsdatum = DateTime.Now;
            Gewicht = 0;
            Name = String.Empty;
        }

        public Lebewesen(Lebewesen otherLebewesen)
        {
            Name = otherLebewesen.Name;
            Gewicht = otherLebewesen.Gewicht;
            Geburtsdatum = otherLebewesen.Geburtsdatum;
        }
    }
}
