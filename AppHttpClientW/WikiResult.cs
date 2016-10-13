using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AppHttpClientW
{
    class WikiResult
    {
        private JArray _data; 

        public WikiResult( JArray data )
        {
            _data = data;
        }

        public void Render()
        {
            Console.WriteLine(_data[0]);
            Console.WriteLine(_data[1]);
            Console.WriteLine(_data[2]);
        }
        //private _data = 
    }
}
