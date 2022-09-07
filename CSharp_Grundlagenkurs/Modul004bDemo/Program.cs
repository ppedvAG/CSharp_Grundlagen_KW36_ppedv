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
        }

        static void PersonAltertUmEinJahrA(int age)
        {
            age++;
        }

        static void PersonAltertUmEinJahrB(ref int age)
        {
            age++;
        }
    }
}