using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LeagueReports
{
    public partial class Form1 : Form
    {
        static string Url;
        static string APIKey;
        static HttpClient Client;
        const string RIOT_API_URL = "https://na1.api.riotgames.com/lol/";
        const string CHAMP_LIST = "http://ddragon.leagueoflegends.com/cdn/8.19.1/data/en_US/champion.json";

        public Form1()
        {
            InitializeComponent();
            APIKey = ConfigurationManager.AppSettings["APIKey"];
            Client = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SummonerNameData data = GetSummonerProfileData(txtSummonerName.Text);
            int summonerId = data.AccountId;

            lblSummonerName.Text = data.Name;
            //lblTitle.Text = data.Name;
            lblTitle.Text = data.Id.ToString();
            lblSummonerLevel.Text = data.SummonerLevel.ToString();
            
            
            MatchList matchList = GetMatchData(summonerId);
            lblLastPlayedChampion.Text = GetChampionData(Client.GetAsync(CHAMP_LIST).Result.Content.ReadAsStringAsync().Result, matchList.Matches[0].Champion).Id;

            RankInfo rankData = GetRankData(data.Id);
            lblSummonerRank.Text = rankData.Rank;

        }
         public Champion GetChampionData(string jsonResult, int championKey)
        {
            JToken jToken = JToken.Parse(jsonResult);
            List<Champion> allChampions = new List<Champion>();
            foreach(JToken jsonChampion in jToken["data"])
            {
                allChampions.Add(JsonConvert.DeserializeObject<Champion>(jsonChampion.First().ToString()));
            }
            return allChampions.Where(champion => champion.Key.CompareTo(championKey) == 0).FirstOrDefault();
        }

        static public SummonerNameData GetSummonerProfileData(string userName)
        {
            SetUrl("summoner/v3/summoners/by-name/", userName);
            return JsonConvert.DeserializeObject<SummonerNameData>(MakeRequest());
        }

        static public MatchList GetMatchData(int summonerId)
        {
            SetUrl("match/v3/matchlists/by-account/", summonerId);
            return JsonConvert.DeserializeObject<MatchList>(MakeRequest());
        }
        static public RankInfo GetRankData(int summonerId)
        {
            SetUrl("league/v3/positions/by-summoner/", summonerId);
            //return JsonConvert.DeserializeObject<RankInfo>(MakeRequest());

            string jsonResult = Client.GetAsync(Url).Result.Content.ReadAsStringAsync().Result;

            JToken jTokenRank = JToken.Parse(jsonResult);
            List<RankInfo> allRankQueues = new List<RankInfo>();
                        
            foreach (JToken jsonRankQueue in jTokenRank)
            {
                allRankQueues.Add(JsonConvert.DeserializeObject<RankInfo>(jsonRankQueue.First.ToString()));
            }

            return allRankQueues.Where(queue => queue.QueueType == "RANKED_SOLO_5x5").FirstOrDefault();
        }

        static private void SetUrl(string url, string userName)
        {
            Url = String.Format(@"{0}{1}{2}{3}", RIOT_API_URL, url, userName, APIKey);
        }

        static private void SetUrl(string url, int summonderId)
        {
            Url = String.Format(@"{0}{1}{2}{3}", RIOT_API_URL, url, summonderId, APIKey);
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
