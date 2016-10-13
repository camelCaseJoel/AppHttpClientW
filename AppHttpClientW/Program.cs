using System;
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
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------- INTERNET AWESOMENESS -------");
            Console.WriteLine("------------------------------------");

            JArray wikiResult;
            wikiResult =  MyRequests.WikipediaRequest("dogs");
            Render.WikipediaPrintResults( wikiResult );

           
            
            
        }
    }
}
