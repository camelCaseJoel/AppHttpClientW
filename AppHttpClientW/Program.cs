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


            
        }
    }
}
