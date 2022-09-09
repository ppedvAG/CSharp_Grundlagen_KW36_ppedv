namespace StructVsClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CPerson classPerson = new CPerson("Anna", 33);

            SPerson structPerson = new SPerson("Lisa", 33);

            CPersonAltern(classPerson);
            SPersonAltern(structPerson);

            Console.WriteLine(classPerson.Age);
            Console.WriteLine(structPerson.Age);

            SPersonAlternWithRef(ref structPerson);
            Console.WriteLine(structPerson.Age);
        }

        static void CPersonAltern(CPerson person)
        {
            person.Age++;
        }

        static void SPersonAltern(SPerson person)
        {
            person.Age++;
        }

        static void SPersonAlternWithRef(ref SPerson person)
        {
            person.Age++;
        }
    }

    public class CPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public CPerson(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public struct SPerson
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public SPerson(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}