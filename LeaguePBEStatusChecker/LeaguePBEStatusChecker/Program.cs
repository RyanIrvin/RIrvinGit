using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http;
using Newtonsoft.Json;

namespace LeaguePBEStatusChecker
{
    class Program
    {
        static HttpClient Client;
        static string Url;
        static string APIKey;

        static void Main(string[] args)
        {
            Url = "https://pbe1.api.riotgames.com/lol/status/v3/shard-data?api_key=";
            APIKey = "RGAPI-eadf789a-7373-4f84-b8d6-a97fd75e0c5d"; //Riot API Key, expires every few days, must be updated to read API
            Url += APIKey;
            Client = new HttpClient();
            var alarm = new System.Media.SoundPlayer(@"C:\Users\Ryan\Desktop\ALARM.wav");  //Alarm sound file to play when server is online
            bool serverIsOffline = true;

            while (serverIsOffline)
            {
                string serverStatus = GetServerStatus(Url);
                Console.WriteLine("[" + DateTime.Now + "]: " + serverStatus);
                if (serverStatus.Equals("offline"))
                    System.Threading.Thread.Sleep(30000);
                else
                {
                    serverIsOffline = false;
                    alarm.Play();
                }
            }

            Console.ReadKey();
        }

        static private string GetServerStatus(string url)
        {
            StatusInfo serverStatus = JsonConvert.DeserializeObject<StatusInfo>(MakeRequest(url));
            return serverStatus.Services[0].Status.ToString();
        }

        static private string MakeRequest(string url)
        {
            using (HttpResponseMessage response = Client.GetAsync(url).Result)
            using (HttpContent content = response.Content)
            {
                return content.ReadAsStringAsync().Result;
            }
        }
    }
}
