using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHttpClientW
{
    static class DatabaseManager
    {
        public static void saveDataToDataBase( JArray data )
        {
            Console.WriteLine(data);
        }

        private static void makeConnection()
        {
            /*
            // ------------------------------- Database stuff
            // ------------------------------- Database stuff
            // ------------------------------- Database stuff

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=LAPTOP-3NG87PA6;Database=CoolConsoleAppClient;User Id=sa;Password = P@55w0rdP@55w0rd;";

            //debug
            Console.WriteLine(conn);

            conn.Open();

            //debug
            Console.WriteLine(conn.State);

            // use the connection here
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Searches (name) VALUES ('from program')", conn);

            var rowsAffected = insertCommand.ExecuteNonQuery();
            Console.WriteLine(rowsAffected);

            conn.Close();
            conn.Dispose();
            */
        }
    }
}
