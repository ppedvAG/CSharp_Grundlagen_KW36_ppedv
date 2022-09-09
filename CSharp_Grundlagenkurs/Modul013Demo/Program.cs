namespace Modul013Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Grundlagen

            //Das Delegate merkt sich die Adresse der Methode 'Addieren'
            CalculatorDelegate calculatorDelegate = new CalculatorDelegate(Addieren);

            double erg = calculatorDelegate(11, 22); //Methode Addieren wird aufgerufen
            Console.WriteLine(erg); //33

            //Wir fügen nochmals eine weitere Methode hinzu
            calculatorDelegate += Subtrahieren;

            
            //Gehe alle angehängten Methoden eines Delegates durch
            erg = 0;
            foreach (Delegate item in calculatorDelegate.GetInvocationList())
            {
                erg = Convert.ToInt32(item.DynamicInvoke(erg, new Random().Next(0, 10)));
            }

            calculatorDelegate -= Addieren;
            erg = calculatorDelegate(11, 22);

            AusgabeDelegate ausgabeDelegate = new AusgabeDelegate(Ausgabe);
            ausgabeDelegate();
            #endregion

            #region Action-Delegate Grundlagen
            //Action Delegate kann nur mit Methoden zusammenarbeiten, die ein VOID als Return zurückgeben. 

            Action actionDelegate = new Action(Ausgabe);
            Action<string> logDelegate = new Action<string>(LogDbMessage);
            logDelegate += LogFileMessage;
            logDelegate("Vorgang erfolgreich");

            foreach (Delegate item in logDelegate.GetInvocationList())
            {
                item.DynamicInvoke("Vorgang erfolgreich");
            }


            #endregion

            #region Func-Delegate Grundlagen
            Func<double, double, double> func1 = new Func<double, double, double>(Addieren);

            erg = func1(11, 22);

            #endregion

            #region Use Case -> Was ist ein Callback
            PercentChangedDelegate percentChangedDelegate = new PercentChangedDelegate(DisplayPercentValue);
            FinishDelegate finishDelegate = new FinishDelegate(ShowMessage);

            Component component = new Component();
            component.Process(percentChangedDelegate, finishDelegate);
            #endregion

            //Komponenten Entwicklung

            #region event delegate 

            BusinessComponentA businessComponentA = new BusinessComponentA();
            businessComponentA.ChangePercentValueDelegae += BusinessComponentA_ChangePercentValueDelegae;
            businessComponentA.ResultDelegate += BusinessComponentA_ResultDelegate;
            businessComponentA.Process();
            #endregion

            #region EventHandler

            BusinessComponentB businessComponentB = new();
            
            businessComponentB.PercentValueChanged += BusinessComponentB_PercentValueChanged;
            businessComponentB.ProcessCompleted += BusinessComponentB_ProcessCompleted;

            businessComponentB.PercentValueChanged2 += BusinessComponentB_PercentValueChanged2;
            businessComponentB.ProcessCompleted2 += BusinessComponentB_ProcessCompleted2;
            #endregion
        }

        private static void BusinessComponentB_ProcessCompleted2(object? sender, FinishEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private static void BusinessComponentB_PercentValueChanged2(object? sender, PercentEventArgs e)
        {
            Console.WriteLine(e.PercentValue);
        }

        private static void BusinessComponentB_ProcessCompleted(object? sender, EventArgs e)
        {
            FinishEventArgs finishEventArgs = (FinishEventArgs)e;

            Console.WriteLine(finishEventArgs.Message);
        }

        private static void BusinessComponentB_PercentValueChanged(object? sender, EventArgs e)
        {
            PercentEventArgs percentEventArgs = (PercentEventArgs)e;
            Console.WriteLine(percentEventArgs.PercentValue);
        }

        private static void BusinessComponentA_ResultDelegate(string msg)
        {
            Console.WriteLine("Wir sind fertig und müde");
        }

        private static void BusinessComponentA_ChangePercentValueDelegae(int newPercentValue)
        {
            Console.WriteLine(newPercentValue.ToString());
        }


        #region Delegate Grundlagen ( Funktionen)
        public static double Addieren(double z1, double z2)
            => z1 + z2;

        public static double Subtrahieren(double z1, double z2)
            => z1 - z2;


        public static void Ausgabe()
            => Console.WriteLine("Hallo Welt");

        public static void LogDbMessage(string msg)
            => Console.WriteLine(msg);
        public static void LogFileMessage(string msg)
           => Console.WriteLine(msg);

        #endregion

        #region UseCase -> Callback
        public static void DisplayPercentValue(int percentValue)
        {
            Console.WriteLine(percentValue);
        }

        public static void ShowMessage(string message)
            => Console.WriteLine(message);
        #endregion



    }

    //Delegates ist ein Datentyp und arbeitet mit Methoden zusammen 
    public delegate double CalculatorDelegate(double nummer1, double nummer2);

    public delegate void AusgabeDelegate();


    #region Beispiel Callback mit Delegate
    public delegate void PercentChangedDelegate(int percentValue);
    public delegate void FinishDelegate(string msg);

    public class Component
    {
        public void Process(PercentChangedDelegate percentChangedDelegate, FinishDelegate finishDelegate)
        {
            for (int i = 0; i <= 100; i++)
            {
                //Hier wird etwas bearbeitet und wollen nach außen mitteilen, bei wieviel Prozent wir gerade stehen
                percentChangedDelegate(i);
            }


            //Wir wollen mitteilen, das wir fertig sind. 
            finishDelegate("Process ist fertig");
        }
    }

    #endregion



}