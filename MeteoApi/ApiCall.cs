using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TagApi
{
    public class ApiCall : ITag
    {
    public static async Task<List<Tram>> CallWebAPIAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://data.mobilites-m.fr/api/routers/default/index/routes");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("?reseaux=TRAM&codes=SEM_A");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Tram>>();
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                    return null;
                }
            }
        }


        public List<Tram> GetTrams()
        {
            return CallWebAPIAsync().Result;
        }
    }
}
