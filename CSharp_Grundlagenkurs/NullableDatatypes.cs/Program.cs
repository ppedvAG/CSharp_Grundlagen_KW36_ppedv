namespace NullableDatatypes.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integerValue;

            int? nullableIntegerValue = 123;

            if (nullableIntegerValue.HasValue)
            {
                Console.WriteLine(nullableIntegerValue.Value);
            }


            DateTime? geburtadatum = null;

            if (geburtadatum.HasValue)
            {
                Console.WriteLine(geburtadatum.Value.ToShortTimeString());
            }
            

        }
    }
}