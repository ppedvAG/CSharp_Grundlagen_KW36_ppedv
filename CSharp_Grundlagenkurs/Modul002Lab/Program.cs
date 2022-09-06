namespace Modul002Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lösung 1
            Console.Write("Gebe eine Jahreszahl ein: ");
            int year = int.Parse(Console.ReadLine());
            bool istSchaltjahr = false;

            if (year % 4 == 0)
            {
                istSchaltjahr = true;
                if (year % 100 == 0)
                {
                    istSchaltjahr = false;
                    if (year % 400 == 0)
                    {
                        istSchaltjahr = true; 
                    }
                }
            }

            if (istSchaltjahr)
                Console.WriteLine("Schaltjahr");
            else
                Console.WriteLine("kein Schaltjahr");
            #endregion

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Schaltjahr");
            }
            else
            {
                Console.WriteLine("Kein SChaltjahr");
            }

            #region SourceCode von IsLeapYear
            //public static bool IsLeapYear(int year)
            //{
            //    if (year < 1 || year > 9999)
            //    {
            //        throw new ArgumentOutOfRangeException("year", Environment.GetResourceString("ArgumentOutOfRange_Year"));
            //    }
            //    Contract.EndContractBlock();
            //    return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            //}
            #endregion

        }
    }
}