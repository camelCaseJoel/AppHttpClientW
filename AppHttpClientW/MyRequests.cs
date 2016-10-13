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
    public static class MyRequests
    {
        public static JArray WikipediaRequest( string searchString )
        {

            string sURL = "https://en.wikipedia.org/w/api.php?action=opensearch&format=json&search=" + searchString;

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(sURL);



            // Making the request
            WebResponse response;
            response = wrGETURL.GetResponseAsync().Result;

            Stream respStream = response.GetResponseStream();


            //Reading and printing data to console -----------------------
            StreamReader objReader = new StreamReader(respStream);

            string jsonStringResponse = objReader.ReadLine();

            var infoObject = (JArray)JsonConvert.DeserializeObject(jsonStringResponse);

            return infoObject;
        }
    }
}
