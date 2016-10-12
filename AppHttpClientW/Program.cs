using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AppHttpClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------- INTERNET AWESOMENESS -------");
            Console.WriteLine("------------------------------------");
            
            string sURL = "https://en.wikipedia.org/w/api.php?action=opensearch&format=json&search=space";

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);





            //WebProxy myProxy = new WebProxy("myproxy", 80);
            //myProxy.BypassProxyOnLocal = true;

            //wrGETURL.Proxy = myProxy;



            // Making the request
            WebResponse response;
            response = wrGETURL.GetResponseAsync().Result;

            Stream respStream = response.GetResponseStream();

            //Console.WriteLine(respStream);





            //Reading and printing data to console -----------------------
            StreamReader objReader = new StreamReader(respStream);

            string jsonStringResponse = objReader.ReadLine();

            var infoObject = (JArray)JsonConvert.DeserializeObject( jsonStringResponse );

            Console.WriteLine( infoObject );



            Console.ReadLine();
            //string sLine = "";
            //int i = 0;

            //while (sLine != null)
            //{
            //    i++;
            //    sLine = objReader.ReadLine();


            //    if (sLine != null)
            //        Console.WriteLine("{0}:{1}", i, sLine);
            //}



        }
    }
}
