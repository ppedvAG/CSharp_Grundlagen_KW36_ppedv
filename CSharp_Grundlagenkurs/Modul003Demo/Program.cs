namespace Modul003Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Schleife

            int a = 0;
            int b = 10;

            //Kopfgesteuerte Schleife: While-Schleife
            //Die Schleife wird so lange ausgeführt, solange a < b ist 
            while (a < b)
            {
                Console.WriteLine("A ist kleiner B");
                a++;
            }
            Console.WriteLine("Schleifenende");


            //Kopfgesteuerte Schleife: for-Schleife
            //

            List<int> lottozahlen = new List<int>();
            lottozahlen.Add(10);
            lottozahlen.Add(20);
            lottozahlen.Add(30);


            
            //for (int i = 0; i <= lottozahlen.Count; i++)
            //    Console.WriteLine(lottozahlen[i]); //Blättern durch eine Liste

            for (int i = 0; i < lottozahlen.Count; i++)
                Console.WriteLine(lottozahlen[i]); //Blättern durch eine Liste

            for (a=0; a < b; a++)
            {
                Console.WriteLine("A ist kleiner als B");
            }


            //foreach blättert durch jeden Datensatz
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            foreach(int currentIntegerValue in array)
            {
                Console.WriteLine(currentIntegerValue);
            }


            a = 0;
            b = 10;

            for (/*keine Initialisierung*/;a < b; /*Inkrementierung fällt aus*/)
            {
                a++;
            }



            //Fussgesteuerte Schleife

            //Zuerst wird die Logik ausgeführt!
            //Danach wird geprüft
            a = 0;
            do
            {
                a++;

            } while (a < 100);

            #endregion


            #region Schleife mit Break / Schleife mit Continue


            //Break
            a = 0;
            b = 10;

            while (a > b)
            {
                if (a == 5)
                    break; //wenn break aufgerufen wird, verlassen wir sofort eine Schleife
                a++;
            } // bei einem Break verlasse ich die Schleife und lande hier 


            //Continue

            a = 0;
            b = 10;

            while (a < b)
            {
                a++;

                if (a % 2 == 0)
                {
                    continue; // er startet den nächsten Schleifendurchlauf
                }

                Console.WriteLine(a); //ungerade Zahlen sollen ausgegeben werden 
            }


            for (int x = 0; x < 100; x++)
            {


                if (x % 2 == 0)
                    continue; 

                //Interne Schleife
                for (int y = 0; y < 100; y++)
                {
                    if (y % 2 == 0)
                        continue; //bricht internen Schleifen-Intervall ab 

                    if (y % 19 == 0)
                        break; //bricht nur interne Schleife ab
                }
            }


            #endregion

            #region Enums

            #region Beispiel 1
            Wochentag wochentag = Wochentag.Dienstag; //Dienstag wird ausgewählt

            Console.WriteLine($"Heute ist also {wochentag}");

            #region Beispiel 2
            for (int weekDay = 1; weekDay < 8; weekDay++)
            {

                //Wochentagnummer (1..7) WelcherTagAlsName 

                Console.WriteLine($"{weekDay}: {(Wochentag)weekDay}");
            }
            #endregion

            
            //Speichern einer Benutzereingabe (Int) als Enumerator
            //Cast: Int -> Wochentag
            
            
            
            //durch Eingabe (1..7) wird Variable wochentag ein Tag zugeordnet 
            wochentag = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Lieblingstag ist {wochentag}");
            #endregion

            #region Beispiel3 

            //Sehr selten, kann aber möglich sein 
            wochentag = (Wochentag)Enum.Parse(typeof(Wochentag), "Freitag");
            #endregion

            #endregion

            #region Enums vs Arrays
            string[] WeekDays = new string[7];
            //Achtung Old School -> Naturkundemuseum 
            WeekDays[0] = "Montag";
            WeekDays[1] = "Dienstag";
            WeekDays[2] = "Mittwoch";
            WeekDays[3] = "Donnerstag";
            WeekDays[4] = "Freitag";
            WeekDays[5] = "Samstag";
            WeekDays[6] = "Sonntag";


            string favoriteDayInWeek = WeekDays[2];

            Wochentag wochentag1 = Wochentag.Sonntag;

            if (WeekDays[2] == "Samstag")
            {
                //Strings Vergleich ist langsamer als
            }

            if (wochentag1 == Wochentag.Dienstag)
            {
                //Integer werden Verglichen
            }


            #endregion

            #region Switch mit Enums

            if (wochentag1 == Wochentag.Montag)
            {
                //...
                Console.WriteLine("Montag");
            }
            else if(wochentag1 == Wochentag.Dienstag || wochentag1 == Wochentag.Mittwoch || wochentag1 == Wochentag.Donnerstag)
            {
                Console.WriteLine("Normaler Wochentag (Di/Mi/Do)");
            }
            else if (wochentag1 == Wochentag.Freitag || wochentag1 == Wochentag.Samstag || wochentag1 == Wochentag.Sonntag)
            {
                Console.WriteLine("Wochenende");
            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe");
            }

            switch (wochentag1)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochenstart");
                    break;
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Normaler Wochentag (Di/Mi/Do)");
                    break;
                case Wochentag.Freitag:
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                default:
                    Console.WriteLine("Fehlerhafte Eingabe");
                    break;
            }
            #endregion

            #region BitFlag
            FischssortenInMeinenSee selektierteFischSorten = FischssortenInMeinenSee.Zander | FischssortenInMeinenSee.Karpfen | FischssortenInMeinenSee.Hecht;


            foreach (FischssortenInMeinenSee currentFischSorte in Enum.GetValues(typeof(FischssortenInMeinenSee)))
            {
                if (selektierteFischSorten.HasFlag(currentFischSorte) && currentFischSorte != FischssortenInMeinenSee.KeineFische)
                {
                    Console.WriteLine($"{currentFischSorte} befindet sich in deinem See");
                }
            }
            #endregion

        }
    }


    //Optional können wir bei dem ersten Enum-Eintrag den Start-Wert definieren -> siehe Montag = 1
    public enum Wochentag { Montag=1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag }


    [Flags]
    public enum FischssortenInMeinenSee
    {
        KeineFische = 0,
        Forelle = 1,
        Hecht = 2,
        Zander = 4, 
        Karpfen = 8,
        Barsch = 16,
        Wels = 32
    }





}