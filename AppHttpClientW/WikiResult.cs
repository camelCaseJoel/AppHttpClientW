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
            int length = _data[1].Count();
            int index = 0;
            while(index < length)
            {
                
                Console.WriteLine("-----> " + index + " <-------------------------------------");
                Console.WriteLine("----->" + ((string)_data[1][index]).ToUpper() );
                //Console.WriteLine(" ");
                //Console.WriteLine(_data[2][index]);
                //Console.WriteLine(" ");
                Console.WriteLine(_data[3][index]);
                Console.WriteLine(" ");
                
                index++;
            }

        }
        
    }
}
