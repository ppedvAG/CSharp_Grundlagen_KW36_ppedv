namespace Modul004bDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Was sind Wertetype?
            //> bool, int, byte, short, long, float, decimal, double, struct


            //Was ist ein Referenztyp?
            //string, Klassen, Interface...

            int alterPersonA = 33;
            int alterPersonB = 33;

            PersonAltertUmEinJahrA(alterPersonA);
            PersonAltertUmEinJahrB(ref alterPersonB);

            Console.WriteLine(alterPersonA);
            Console.WriteLine(alterPersonB);

            string eingabe = "123";

            int numberInput;

            if (int.TryParse(eingabe, out numberInput))
            {

            }
        }



        static void PersonAltertUmEinJahrA(int age)
        {
            age++;
        }

        static void PersonAltertUmEinJahrB(ref int age)
        {
            age++;
        }

        static void PersonAltertUmEinJahrC(in int age)
        {
            //in ist readonly

            age++;
        }

        static void PersonAltertUmIrgendwas(out int age)
        {
            age = 123; //Out 
        }
    }
}