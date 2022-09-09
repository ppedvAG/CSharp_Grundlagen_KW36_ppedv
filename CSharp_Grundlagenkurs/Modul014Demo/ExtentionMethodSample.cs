using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul014Demo.Extentions
{
    public static class ExtentionMethodSample
    {
        public static void SavePerson(this Person person, string savePath)
        {
            Console.WriteLine($"Personen-Objekt mit den Werten {person.Id} - {person.Name} - {person.Alter} wird in {savePath} gespeichert");
        }
    }
}
