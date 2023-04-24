using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace APIRequest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "http://api.marketstack.com/v1/eod/2023-04-14?access_key=050ee6db389b4320ed90d015a28a4a9d&symbols=AAPL";
            HttpClient httpClient = new HttpClient();
            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                
                Root marketData = JsonConvert.DeserializeObject<Root>(jsonResponse);

                foreach (var item in marketData.Data)
                {
                    Console.WriteLine($"Kurs {item.Symbol} z dnia {item.Date.ToString("dd-MM-yyyy")}: cena otwarcia: {item.Open}$, cena zamknięcia: {item.Close}$");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
