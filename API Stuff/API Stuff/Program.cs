using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Configuration;
using Newtonsoft.Json;

namespace API_Stuff
{
    class Program
    {
        static string Url;
        static string APIKey;
        static HttpClient Client;
        const string RIOT_API_URL = "https://na1.api.riotgames.com/lol/";

        static void Main(string[] args)
        {
            APIKey = ConfigurationManager.AppSettings["APIKey"];
            Client = new HttpClient();

            while (true)
            {
                string userName = Console.ReadLine();
                if (userName.Equals("x"))
                    break;
                SummonerNameData data = GetSummonerNameData(userName);
                Console.WriteLine();
            }

        } 

        static public SummonerNameData GetSummonerNameData(string userName)
        {
            SetUrl("platform/v3/champion-rotations/");
            return JsonConvert.DeserializeObject<SummonerNameData>(MakeRequest());
        }

        static private void SetUrl(string url, string userName)
        {
            Url = String.Format(@"{0}{1}{2}{3}", RIOT_API_URL, url, userName, APIKey);
        }

        static public string MakeRequest()
        {
            using (HttpResponseMessage response = Client.GetAsync(Url).Result)
            using (HttpContent content = response.Content)
            {
                return content.ReadAsStringAsync().Result;
            }
        }
    }
}

