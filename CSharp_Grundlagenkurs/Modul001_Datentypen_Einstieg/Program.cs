namespace Modul001_Datentypen_Einstieg
{
    internal class Program
    {

        //Startpunkt des Programm 
        static void Main(string[] args)
        {

            #region Einstieg
            int Alter;  //Deklaration -> Hier wird Arbeitsspeicher für die Variable reserviert
                        //Default-Wert von int ist der Wert '0'

            Alter = 20; //Eine Zuweisung -> Im Arbeitsspeicher wird der Wert 20 zugewiesen 
            int DoppeltesAlter = Alter * 2; // DoppeltesAlter reserviert Variable UND bekommt den Wert 40

            //var bekommt den Datentyp zur Laufzeit -> Im Design-Modus wird der Datentyp auch schon aufgelöst
            var hälfteDesAlters = DoppeltesAlter / 2;


            //Datentyp für Zeichenketten 
            string stadt = "München";

            string halloVonStadt = "Liebe Grüße aus " + stadt; //Liebe Grüße aus München

            //Ausgabe einer Variable -> Ausgabe wir in Konsole geschrieben 

            Console.WriteLine(halloVonStadt);
            #endregion


            #region Datentypen Übersicht
            //byte - short - int - long
            int ganzZahl = 123;

            //Consolen.WriteLine -> Shortcut

            Console.WriteLine(ganzZahl);
            Console.WriteLine($"Maximale Integer-Wert {int.MaxValue} und minimaler Integer-Wert {int.MinValue}");

            uint unsignedInteger = 123;

            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            
            //Zuweisung
            //Leer-String Zuweisung
            string stringOhneTextVariante = "";
            string stringOhneTextVariante2 = string.Empty;

            //Zuweisung mit Text 
            string myName = "Alf";


            //Gegenüber dem String benötigt ein Char nur ein Hochkomma 
            char charZeichen = 'A'; //Hier wird im Hintergrund auch der Wert der Ascii-Tabelle abgelegt. //65



            decimal money = 123m; //suffix mit m 

            DateTime dateTime = DateTime.Now;   //Aktuelle Urhzeit
            DateTime dateTime1 = DateTime.UtcNow;
            #endregion

            #region String und Konsolenausgaben 

            string string1 = "Hallo " + myName; //Strings mit dem + - Operator ist die langsamste Variante  

            Console.WriteLine("Hallo " + myName);
            Console.WriteLine("Hallo {0}. Wohnt in {1} ", myName, stadt);




            //Best Practise:

            string ausgabe = $"Hallo {myName}. Wohnt in {stadt}";
            Console.WriteLine($"Hallo {myName}. Wohnt in {stadt}");
            #endregion

            #region Formatierung von Strings
            //String können Escape-Zeichen verwenden 
            //https://docs.microsoft.com/de-de/dotnet/standard/base-types/character-escapes-in-regular-expressions

            string multiLineText = "Hallo, Liebe Teilnehmer \n ich hoffe die ersten Stunden des C#-Kurses gefallen \n Mit freundlichen Grüßen, \t Kevin Winter";
            Console.WriteLine(multiLineText);


            //Escape Zeichen haben ein Problem und das sind Windows-Pfade oder andere Angaben mit einem  '\' 

            string filePath = "C:\\Windows\\Temp"; //Wir benötigen 2x Backslash um zu zeigen, dass wir kein Escape-Zeichen darstellen wollen. 


            //Mit dem @-Zeichen vor einem String, schalten wir die Escape-Zeichen aus

            string filePath2 = @"C:\Windows\Temp";

            //Wir können @ und $ kombinieren -> Reihenfolge was zuerst steht, ist egal

            string filePath3 = $@"C:\User\{myName}";
            string filePath4 = @$"C:\User\{myName}";
            #endregion

            #region Konsoleneingabe + Konventierung

            Console.Write("Bitte gebe Sie Ihren Namen ein: ");
            string nameDesTeilnehmers = Console.ReadLine();

            Console.Write("Gebe deine Lieblingszahl bitte ein: ");


            //STRING -> INT 

            //Sehr alte Variante um aus einem String-Datentyp ein Zahlen-Datentyp umzuwandeln (konventieren) 


            Console.Write("Zahleingabe: ");
            int lieblingsZahl = Convert.ToInt32(Console.ReadLine());
            int lieblingzahl2 = int.Parse(Console.ReadLine());

            Console.Write("Bitte gebe Sie Ihren Namen ein: ");
            string alterAlsString = Console.ReadLine();

           
            //if (Condition) -> Condition muss wahr sein 
            if (int.TryParse(alterAlsString, out int alter))
            {
                //wenn das Konventieren geklappt hat, wird die Variable 'alter' mit dem Wert 'alterAlsString' befüllt sein
                Console.WriteLine(alter); //123
            }


            //Zahl zu Zahl - Konventierung (Impliziet und Expliziet) 
            //Impliziet = er konventiert automatisch um
            //Expliziet = wir müssen angeben in welchen Format konventiert wird. 

            //Impliziete Konventierung (automatische Umwandlung) 
            int ganzeZahl = 25;
            Console.WriteLine(ganzeZahl);


            //Ganz Zahl in Gleitkommazahl
            double kommaZahl = ganzeZahl; //25.0 
            Console.WriteLine(kommaZahl);

            double gleitKommaZahl = 25.33;
            //Was hinter dem Komma steht wird abgeschnitten
            ganzeZahl = (int)gleitKommaZahl;


            decimal decimalZahl = 3.87654323234234m;

            //decimal ist der genauste Datentyp.
            //Beim Konventieren in double werden nicht alle Kommastellen konventiert (verlust an Infos) 
            double gleitKommaZahlDouble = (double) decimalZahl;

            #endregion


            #region Mathematische Operatoren 

            int a = 10;
            int b = 20;

            //c = 30 
            int c = a + b;

            //Ausgeschrieben
            a = a + 10; //a wird zu 20;
            //Kurzschreibweise
            a += 10; //a wird zu 30 

            //Inkrementieren (um den Wert 1 wird erhöht) 
            a++; //a wird zu 31

            b *= 10; //200

            b /= 5; //40

            b--; //39


            //Ein Unterschied der wichtig ist a++ oder ++a
            a = 20;
            b = 20;

            Console.WriteLine(a++); // 20: hier gibt er zuerst den Wert aus und DANACH wird um den Wert 1 erhöht
            Console.WriteLine(++b); // 21: 


            //Runden von Werten

            gleitKommaZahl = 25.44;

            Console.WriteLine(Math.Round(gleitKommaZahl));

            gleitKommaZahl = 25.5;
            Console.WriteLine(Math.Round(gleitKommaZahl));

            #endregion

            //Ermitteln von Max-Wert zweier Zahlen
            int hoechsterWertMax = Math.Max(a, b);

            int niedrigsterWertMin = Math.Min(a, b);


            //Modulo

            if (100 % 4 == 0)
            {

                Console.WriteLine("100 ist in BinaryReader 4er Reihenfolge");
            }

        }
    }
}