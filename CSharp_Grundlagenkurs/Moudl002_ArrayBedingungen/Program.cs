using System.Linq;

namespace Moudl002_ArrayBedingungen
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Arrays
            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.

            //Variante 1: Deklaration + Initialisierung 
            int[] zahlen = { 11, 22, 33, 44 }; //Array hat 4 Felder 
            Console.WriteLine(zahlen[0]); //Index 0 -> Erstes Eleement -> Zahl 11

            //Bauen zuerst ein Array auf mit der Größe von 4 Felder
            int[] zahlen2 = new int[4];

            //Befüllen Array anschließen 
            zahlen2[0] = 11;
            zahlen2[1] = 22;
            zahlen2[2] = 33;
            zahlen2[3] = 44;

            string[] worte = new string[6];            
            worte[0] = "Hallo";
            worte[1] = "liebe";
            worte[2] = "Teilnehmer";
            worte[3] = "im";
            worte[4] = "C#";
            worte[5] = "Kurs";
            #endregion

            #region Erweiterungen durch System.Linq
            //Eine Methode die Immer vorhanden ist

            int lengeth = zahlen.Length; //Length gibt die Anzahl der Array-Felder zurück 

            //Erweiterungen durch System.Linq

            //Gibt es die Zahl 22 im Array 'zahlen'

            bool wahrOderFalsch = zahlen.Contains(22); //bool wahrOderFalsch = true
            wahrOderFalsch = zahlen.Contains(21); //false

            //https://linqsamples.com/ 
            #endregion

            #region Mehrdimensionales Array

            //3 Felder Lang
            //5 Felder breit 
            int[,] zweiDimArray = new int[3, 5];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    zweiDimArray[x, y] = x * y;
                }
            }

            Console.WriteLine(zweiDimArray[2, 3]);

            #endregion
            #region Trick 17 Array Erweitern
            List<int> myList = new List<int>();
            myList.AddRange(zahlen); //Array kann als IEnumerable<int> verwendet werden
            myList.Add(55);
            zahlen = myList.ToArray();
            #endregion


            #region Bedingungen (If/Else)

            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 23;
            int b = 23;

            bool retValue = true;
            bool retValue1 = false;


            //Wenn retValue "true" ist, wird Console.WriteLine ausgeführt
            if (retValue)
                Console.WriteLine("Return-Wert ist true");

            //Wenn retValue false ist kann man mithilfe des Ausrufezeichens das Statement umkippen 
            if (!retValue1)
                Console.WriteLine("Return-Wert ist false");
            else
                Console.WriteLine("Return-Value ist true");

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            ///
            if (a < b)
            {
                //Wenn a kleiner als B, wird dieser Code-Block ausgeführt { ... }
                Console.WriteLine("A ist kleiner als B");
            }
            else if (a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
            {
                //Wenn alles davor nicht genommen wurde, wird hier der Default-Block ausgeführt 

                Console.WriteLine("A und B sind gleich");
            }

            if (a==b)
            {
                Console.WriteLine("A ist gleich B");
            }

            if (a < b)
                Console.WriteLine("Ausgabe");
            else if (a > b)
                Console.WriteLine("Ausgabe 2");
            else
                Console.WriteLine("Ausgabe 3");

            //if (a == b)
            //    Console.WriteLine("gleich");
            //else
            //    Console.WriteLine("ungleich");

            //Kurznotation 

            //Syntax (Bedienung) ? (True-Block) : (False-Block) 
            string ergebnis = (a == b) ? "A und B sind gleich" : "A ist ungleich B";


            string name1 = "Hans";
            string name2 = "Hans";

            if (name1 == name2)
                Console.WriteLine($"name1 == name2");

            if (name1.Equals(name2)) //Equals prüft ob Name2 gleich Name1 ist
            {
                //wenn Werte gleich sind, kommen wir in diesen Block 
            }

        }
    }
}