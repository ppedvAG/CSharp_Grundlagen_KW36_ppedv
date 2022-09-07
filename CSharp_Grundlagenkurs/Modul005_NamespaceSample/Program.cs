using Lib = Modul005_NamespaceSample.Library;

namespace Modul005_NamespaceSample
{

    //Innerhalb eines Namespace können wir für eine Typdefinition nur einmalig einen Namen verwenden

    internal class Program
    {
        static void Main(string[] args)
        {
            //Bei doppelten Klassennamen, muss man mit einem absoluten Klassen-Pfad Angabe arbeiten
            Modul005_NamespaceSample.Library.Car carFromDLL;
            Modul005_NamespaceSample.Car carFromProgramm;

            Lib.Car carWithAlias; //Modul005_NamespaceSample.Library.Car
        }
    }
}