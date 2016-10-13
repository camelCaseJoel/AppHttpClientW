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

            WikiResult result;
            WikiResult result2;

            result =  MyRequests.WikipediaRequest("dogs");
            result.Render();


            result2 = MyRequests.WikipediaRequest("paper");
            result2.Render();


           
            
            
        }
    }
}
