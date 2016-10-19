using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


            //=========================== Connection to Database
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=LAPTOP-3NG87PA6;Database=CoolConsoleAppClient;User Id=sa;Password = P@55w0rdP@55w0rd;";

            //==> Open
            conn.Open();

            //----------------------------------------------------------------------------------

            //int length = data[1].Count();
            //int index = 0;
            //while (index < length)
            //{

            //    Console.WriteLine("-----> " + index + " <-------------------------------------");
            //    Console.WriteLine("----->" + ((string)data[1][index]).ToUpper());
            //    //Console.WriteLine(" ");
            //    //Console.WriteLine(_data[2][index]);
            //    //Console.WriteLine(" ");
            //    Console.WriteLine(data[3][index]);
            //    Console.WriteLine(" ");

            //    index++;
            //}

            // use the connection here
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Articles (name, url, description) VALUES (@0, @1, @2)", conn);

            insertCommand.Parameters.Add(new SqlParameter("0", "From program XXX"));
            insertCommand.Parameters.Add(new SqlParameter("1", "www.fromprogram.com"));
            insertCommand.Parameters.Add(new SqlParameter("2", "From the program I'm building!, hahahahahahahah"));
        

            var rowsAffected = insertCommand.ExecuteNonQuery();
            Console.WriteLine("NUMBER OF RESULTS SAVED: " + rowsAffected);

            //-----------------------------------------------------------------------------------


            //==> Close
            conn.Close();
            conn.Dispose();

        }
       
    }
}





/*
// ------------------------------- Database stuff
// ------------------------------- Database stuff
// ------------------------------- Database stuff

SqlConnection conn = new SqlConnection();
conn.ConnectionString = "Server=LAPTOP-3NG87PA6;Database=CoolConsoleAppClient;User Id=sa;Password = P@55w0rdP@55w0rd;";



conn.Open();



// use the connection here
SqlCommand insertCommand = new SqlCommand("INSERT INTO Searches (name) VALUES ('from program')", conn);

var rowsAffected = insertCommand.ExecuteNonQuery();
Console.WriteLine(rowsAffected);

conn.Close();
conn.Dispose();
*/
