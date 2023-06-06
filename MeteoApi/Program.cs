using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TagApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello in api meteo");
            Console.ReadLine();
            ITag tagApi = new ApiCall();
            Display.DisplayInfo(tagApi.GetTrams());
        }

    }
}
