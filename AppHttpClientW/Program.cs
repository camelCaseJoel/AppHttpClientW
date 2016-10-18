using System;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AppHttpClientW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.SetWindowSize(60, 50);

            Console.WriteLine("===============================================");
            Console.WriteLine("------------- INTERNET AWESOMENESS ------------");
            Console.WriteLine("===============================================");
            Console.WriteLine("Please enter your search terms and PRESS ENTER");
            

            string searchString;
            searchString = Console.ReadLine();


            WikiResult result;
            result =  MyRequests.WikipediaRequest(searchString);
            result.Render();


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

            var rowsAffected =  insertCommand.ExecuteNonQuery();
            Console.WriteLine(rowsAffected);

            conn.Close();
            conn.Dispose();
        }
    }
}
