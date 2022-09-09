using System.Diagnostics;

namespace MathLibrary
{
    public class Calculator
    {
        public double Addition(double zahl1, double zahl2)
            => zahl1 + zahl2;

        public double Multiplikation(int zahl1, int zahl2)
        {
            return zahl1 * zahl2;
        }

        public double Division(double zahl1, double zahl2)
        {
            try
            {
                //kritischer Quellcode, der einen Fehler verursachen kann
                Validate(zahl2);

                return zahl1 / zahl2;
            }
            catch(TeileDurchNullException ex)
            {

                //Debug ist jetzt unser "Logger"
                Debug.WriteLine("NUR FEHLERMERLDUNG" + ex.Message); //Fehlermeldung in Text
                Debug.WriteLine("NUR STACKTRACE" + ex.StackTrace); // Wo ist Fehler passiert
                Debug.WriteLine("NUR ToString()" + ex.ToString()); //Fehlermeldung in Text + Wo ist Fehler passiert

                throw new TeileDurchNullException("Bitte rufen Sie Ihren Administrator oder melden Sich bei unserem Support");
            }

            
        }

        private void Validate(double zahl2)
        {
            if (zahl2 == 0)
                throw new TeileDurchNullException("Zahl2 darf nicht 0 sein");
        }
    }

    public class MathLibraryException : Exception
    {
        public MathLibraryException(string msg)
            :base(msg)
        {

        }
    }

    public class TeileDurchNullException : MathLibraryException
    {
        public TeileDurchNullException(string msg)
            : base(msg)
        {

        }
    }
}