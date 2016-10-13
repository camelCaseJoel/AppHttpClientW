using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppHttpClientW
{
    public static class Render
    {
        public static void WikipediaPrintResults( JArray infoObject )
        {
            Console.WriteLine(infoObject[0]);
            Console.WriteLine(infoObject[1]);
            Console.WriteLine(infoObject[2]);

        }
    }

   
}
