using System.Data.SqlClient;

namespace Modul010Demo_Interfaces_In_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Das PROBLEM 
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=MovieDbContext-0002;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            //Import passiert 
            //Und ein Fehler entsteht


            //ALTE Variante, wie man mit einer SQLConnection umgegangen ist oder immer noch kann
            SqlConnection sqlConnection2 = new SqlConnection(connectionString);
            try
            {
                //kritischer Code, bei dem Fehler passieren können
                sqlConnection2.Open();

                //SQL Import Befehle 
                //Es passiert ein Fehler 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally //wird immer ausgeführt
            {
                sqlConnection2.Close(); //Schließe die Verbindung
                sqlConnection2.Dispose(); //Baue das Objekt ab
            }


            using (SqlConnection sqlConnection3 = new SqlConnection(connectionString))
            {
                //try - catch 
            } //disopse wird hier immer auferufen

            // Das ist eine neue Variante von using und Dispose wird am Ende der MEthode auferufen 
            using SqlConnection sqlConnection5 = new SqlConnection(connectionString);


            //
            using (Lebewesen lebewesen = new Lebewesen()) 
            {

            }

        }
    }

    public class Lebewesen : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose von Lebewesen wurde aufgerufen");
        }
    }
}