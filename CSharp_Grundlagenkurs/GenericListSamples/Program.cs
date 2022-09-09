
namespace GenericListSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region generische Listen
            List<FootballClub> clubs = new List<FootballClub>();

            clubs.Add(new FootballClub("Schalke 04"));
            clubs.Add(new FootballClub("BVB"));


            //AddRange(IEnumerable<T> items) kann Arrays verarbeiten 
            FootballClub[] clubArray = new FootballClub[2];
            clubArray[0] = new FootballClub("1. FCK");
            clubArray[1] = new FootballClub("FSV Mainz 05");

            clubs.AddRange(clubArray);


            List<string> citiesA = new List<string>();


            //Loose Koppelung
            IList<string> citiesB = new List<string>();
            #endregion


            #region Dictionary


            Dictionary<int, FootballClub> dictionary = new Dictionary<int, FootballClub>();

            dictionary.Add(1, new FootballClub("1 FCN"));
            

            if (!dictionary.ContainsKey(2))
            {
                dictionary.Add(2, new FootballClub("1860"));
            }

            foreach (KeyValuePair<int, FootballClub> kvp in dictionary)
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Name}");


            IDictionary<int, FootballClub> footballClubDict = new Dictionary<int, FootballClub>();
            footballClubDict.Add(new KeyValuePair<int, FootballClub>(3, new FootballClub("SGE")));

            #endregion
        }
    }

    public class FootballClub
    {
       
        public string Name { get; set; }

        public FootballClub(string name)
        {
            this.Name = name;
        }

    }
}