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



            //--Continue?
            Console.WriteLine( "Want to continue? ( yes  or  no )" );
            string wantToContinue = Console.ReadLine();
            askIfContinue( wantToContinue );

            //---------------------------------------

            DatabaseManager.saveDataToDataBase( result.getData() );

            
        }


        //--------------------------------------------------------------
        //-> App methods ==============================================|
        //--------------------------------------------------------------
        private static void askIfContinue( string wantToContinue )
        {
            if (wantToContinue == "yes")
            {
                Console.Clear();
            }
            else if (wantToContinue == "no")
            {
                Environment.Exit( 0 );
            }
            else
            {

                Console.WriteLine("Sorry, what?");
                string answer = Console.ReadLine();
                askIfContinue( answer );
            }
        } 
    }
}
