using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MeteoApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello in api meteo");
            Console.ReadLine();
            CallWebAPIAsync().Wait();
        }
        static async Task CallWebAPIAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://data.mobilites-m.fr/api/routers/default/index/routes");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("?reseaux=TRAM&codes=SEM_A");
                if (response.IsSuccessStatusCode)
                {
                    List<Tram> trams = await response.Content.ReadAsAsync<List<Tram>>();
                    Console.WriteLine("Id:{0}\tName:{1}", trams[0].LongName, trams[0].ShortName);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }
    }
}
