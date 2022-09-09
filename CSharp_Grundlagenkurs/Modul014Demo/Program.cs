using Modul014Demo.Extentions;
namespace Modul014Demo
{
    internal class Program
    {

        

        private static IList<Person> personenListe = new List<Person>();

        static void Main(string[] args)
        {


            Person person = new Person(1, "Otto", 44);



            #region Erweiterungsmethoden
            person.SavePerson("Person.dat");
            #endregion


            #region Linq und Lambda 
            personenListe.Add(new Person(1, "Otto", 44));
            personenListe.Add(new Person(2, "Eva", 21));
            personenListe.Add(new Person(3, "Karl", 34));

            personenListe.Add(new Person(4, "Hannes", 56));
            personenListe.Add(new Person(5, "Andre", 78));
            personenListe.Add(new Person(6, "Bill", 12));

            personenListe.Add(new Person(7, "James", 32));
            personenListe.Add(new Person(8, "Anna", 23));
            personenListe.Add(new Person(9, "Lena", 29));


            //Was ist ein Linq-Statement? -> 101 Samples -> https://github.com/dotnet/try-samples/tree/main/101-linq-samples
            IList<Person> personenUnter30 = (from p in personenListe
                                             where p.Alter < 30
                                             orderby p.Name
                                             select p).ToList();

            //Linq-Functions + Ausdrücke in den Functions nennt man LAMBDA ->  https://linqsamples.com/

            personenUnter30 = personenListe.Where(p => p.Alter < 30)
                                           .OrderBy(p => p.Name)
                                           .ToList();

            personenUnter30 = GetPersonsByWhereStatment(abc => abc.Alter < 30);



            #region Linq-Functionen -> Mathematische Funktionen

            double altersdurschnittAllePersonen = personenListe.Average(p => p.Alter);

            double altersdurschnittAllerPersonenUeber30 = personenListe.Where(p => p.Alter > 30)
                                                                       .Average(p => p.Alter);

            int gesamtesAlterAllerPersonen = personenListe.Sum(p => p.Alter);
            #endregion

            #region EinzeleneDatensätze ermitteln

            Person erstePersonInListe = personenListe.First();
            Person? erstePersonOderDefault = personenListe.FirstOrDefault();
            Person letztePersonInListe = personenListe.Last();

            Person person1 = personenListe.Where(p => p.Alter > 40).First();
            person1 = personenListe.First(p => p.Alter > 40);


            Person nurEinePerson = personenListe.Single(p => p.Id == 1);

            #endregion

            #region Anzahl von Datensätze

            //Schnelleste Variante um Datensatzanzahl in einer Liste zu ermitteln ist immer noch 
            //die Count-Property von Liste
            int count = personenListe.Count;

            count = personenListe.Count(p => p.Alter > 40);

            bool jemandDa = personenListe.Any(p => p.Alter > 200);



            #endregion

            #region Paging
            IList<Person> seite1 = PagingMethode(1, 3);
            IList<Person> seite2 = PagingMethode(2, 3);
            IList<Person> seite3 = PagingMethode(3, 3);


            IList<Person> seite1Aber5Datensätze = PagingMethode(1, 5);
            #endregion


            #endregion
        }

        public static IList<Person> GetPersonsByWhereStatment (Func<Person, bool> predicate)
        {
            return personenListe.Where(predicate).ToList();
        }

        public static IList<Person> PagingMethode(int pagingNumber, int pagingSize = 3)
            => personenListe.Skip((pagingNumber - 1) * pagingSize).Take(pagingSize).ToList();
    }

    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Alter { get; set; }

        public Person(int id, string name, int alter)
        {
            Id = id;
            Name = name;
            Alter = alter;
        }
    }
}