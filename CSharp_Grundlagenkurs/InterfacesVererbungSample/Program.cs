namespace InterfacesVererbungSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Person> personenRepository = new PersonenRepository();
            personenRepository.GetAll();
            personenRepository.Add(new Person());
            personenRepository.Update(new Person());
            personenRepository.Delete(new Person());

            IReadonlyRepository<Person> personenRepository2 = new PersonenRepository();
            personenRepository2.GetAll();
        }
    }

    //Repository - Design Pattern 
    //eine Repository-Klasse kümmert sich um den Datenverkehr mit einer Tabelle

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    #region Interface-Vererbung
    public interface IReadonlyRepository<T>
    {
        List<T> GetAll();
    }

    public interface IRepository<T> : IReadonlyRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete (T item);   
    }

    #endregion
    public class PersonenRepository : IRepository<Person>
    {
        //CRUD sind alle 4 Grund-Queries
        //(C)reate
        //(R)ead
        //(U)pdate
        //(D)elete
        public void Add(Person item)
        {
            
        }

        public void Delete(Person item)
        {
            
        }

        public List<Person> GetAll()
        {
            return new List<Person>();
        }

        public void Update(Person item)
        {
            
        }
    }
}