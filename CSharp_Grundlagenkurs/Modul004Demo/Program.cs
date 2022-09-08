namespace Modul004Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Einfache Methode + Überladen von Methoden
            //Erstes Beispiel - Methodenaufruf
            double summe = Addiere(3, 5);
            Console.WriteLine(summe);

            //Zweites Beispiel - Überladene Methode von Addiere
            double summe2 = Addiere(4.5, 5.5);
            int ergebnis = Addiere(2, 4, 6, 8);
            #endregion

            #region Params
            summe2 = BildeSumme(1, 2, 3, 4, 5, 6, 7, 3, 4, 23, 23);
            #endregion

            #region Optionale Parameter
            ergebnis = Subtrahiere(10, 3, 2, 1);
            ergebnis = Subtrahiere(10, 3, 2);
            ergebnis = Subtrahiere(10, 3);

            #endregion


        }

        //Jede Funktion/Methode besteht aus einem Funktions-Kopf und Funktions-Körper

        //Funktion kann einen Rückgabewert haben, und kann Funktions/Methoden - Parameter verwenden

        //SYNTAX Returntyp Addiere (Parameterliste) 


        public static int Addiere (int a, int b)
        {
            return a + b;
        }

       

        public static int Addiere(int a, int b, int c)
        {
            return a + b + c;
        }

        //Variante, wie man bestehende Methode verwendet und zusätzliche Logik stellt
        public static int Addiere(int a, int b, int c, int d)
        {
            return Addiere(a, b, c) + d;
        }

        //Überladen einer Methode
        public static double Addiere (double a, double b)
        {
            return a + b;
        }

        public static void VersionsInformation()
        {
            Console.WriteLine("Version 1.2");
        }

        public static int[] Lottoziehung()
        {
            int[] lottoziehung = new int[7];
            lottoziehung[0] = 5;
            lottoziehung[1] = 6;
            lottoziehung[2] = 7;

            //...
            return lottoziehung;
        }


        static int BildeSumme(params int[] summanden)
        {
            int summe = 0;

            foreach (int summand in summanden)
                summe += summand;

            return summe;
        }

        static int Subtrahiere(int a, int b, int c = 0, int d = 0)
            => a - b - c - d;
        

        public double Multiplizieren(int a, int b, int c)
            => a * b * c;

    }
}