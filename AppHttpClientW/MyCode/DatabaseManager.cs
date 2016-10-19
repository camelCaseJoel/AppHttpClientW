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
            

            //=========================== Connection to Database
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=LAPTOP-3NG87PA6;Database=CoolConsoleAppClient;User Id=sa;Password = P@55w0rdP@55w0rd;";

            //==> Open
            conn.Open();

            //----------------------------------------------------------------------------------
            int totalSuccessRows = 0;
            int length = data[1].Count();
            int index = 0;
            while (index < length)
            {

                Console.WriteLine("-----> " + index + " <-------------------------------------");
                Console.WriteLine("----->" + ((string)data[1][index]).ToUpper());


                // use the connection here
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Articles (name, url, description) VALUES (@0, @1, @2)", conn);

                insertCommand.Parameters.Add(   new SqlParameter( "0", (string)data[1][index] )   );
                insertCommand.Parameters.Add(   new SqlParameter( "1", (string)data[3][index] )   );
                insertCommand.Parameters.Add(   new SqlParameter( "2", (string)data[2][index] )   );


                bool success;
                var rowsAffected = insertCommand.ExecuteNonQuery();
                if ( rowsAffected == 1 )
                {
                    success = true;
                    totalSuccessRows++;
                }
                else
                {
                    success = false;
                }
                Console.WriteLine("RESULT SAVED? --> : " + success);



                index++;
            }



            //-----------------------------------------------------------------------------------

            Console.WriteLine( "Number of Total rows affected: " + totalSuccessRows );


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
