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
using System.Globalization;
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
        const string CHAMP_LIST = "http://ddragon.leagueoflegends.com/cdn/8.21.1/data/en_US/champion.json";
        const string CHAMP_ICONS = "http://ddragon.leagueoflegends.com/cdn/8.21.1/img/champion/";
        const string SUMMONER_SPELL_LIST = "http://ddragon.leagueoflegends.com/cdn/8.21.1/data/en_US/summoner.json";
        const string SUMMONER_SPELL_ICONS = "http://ddragon.leagueoflegends.com/cdn/8.21.1/img/spell/";
        const string ITEM_ICONS = "http://ddragon.leagueoflegends.com/cdn/8.21.1/img/item/";

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
            lblSummonerLevel.Text = data.SummonerLevel.ToString();

            picChampionicon.Enabled = true;
            //picProfileIcon.ImageLocation = ;


            MatchList matchList = GetMatchData(summonerId);

            string lastPlayedChampion = GetChampionData(Client.GetAsync(CHAMP_LIST).Result.Content.ReadAsStringAsync().Result, matchList.Matches[0].Champion).Id;
            lblLastPlayedChampion.Text = lastPlayedChampion;

            RankInfo rankData = GetRankData(data.Id);
            lblSummonerRank.Text = $"{rankData.Tier} {rankData.Rank} ({rankData.Wins}/{rankData.Losses}) {rankData.WinPercentage}%";

            //long lastGameId = 2892431075; //matchList.Matches[0].GameId;
            long lastGameId = matchList.Matches[0].GameId;

            MatchStats matchStats = GetMatchStats(lastGameId);

            int participantId = 0;

            foreach (ParticipantIdentity participant in matchStats.ParticipantIdentities)
            {
                if (participant.Player.SummonerName == data.Name)
                {
                    participantId = participant.ParticipantId;
                    break;
                }
            }

            //lblLastGameStats.Text = matchStats.ParticipantIdentities[participantId - 1].Player.SummonerName;
            lblKda.Text = $"{matchStats.Participants[participantId - 1].Stats.Kills}/{matchStats.Participants[participantId - 1].Stats.Deaths}/{matchStats.Participants[participantId - 1].Stats.Assists}";
            lblVisionScore.Text = matchStats.Participants[participantId - 1].Stats.VisionScore.ToString();

            SetDataDragonChampionUrl(lastPlayedChampion);
            picChampionicon.Load(Url);
            picChampionicon.Visible = true;


            string summonerSpell1 = GetSummonerSpell(Client.GetAsync(SUMMONER_SPELL_LIST).Result.Content.ReadAsStringAsync().Result, matchStats.Participants[participantId - 1].Spell1Id).Id;
            SetDataDragonSummonerSpellUrl(summonerSpell1);
            picSummonerSpell1.Load(Url);
            picSummonerSpell1.Visible = true;

            string summonerSpell2 = GetSummonerSpell(Client.GetAsync(SUMMONER_SPELL_LIST).Result.Content.ReadAsStringAsync().Result, matchStats.Participants[participantId - 1].Spell2Id).Id;
            SetDataDragonSummonerSpellUrl(summonerSpell2);
            picSummonerSpell2.Load(Url);
            picSummonerSpell2.Visible = true;

            int[] items = new int[] {
                matchStats.Participants[participantId - 1].Stats.Item0,
                matchStats.Participants[participantId - 1].Stats.Item1,
                matchStats.Participants[participantId - 1].Stats.Item2,
                matchStats.Participants[participantId - 1].Stats.Item3,
                matchStats.Participants[participantId - 1].Stats.Item4,
                matchStats.Participants[participantId - 1].Stats.Item5,
                matchStats.Participants[participantId - 1].Stats.Item6,
            };

            int counter = 0;

            List<PictureBox> itemPictures = new List<PictureBox>() { picItem0, picItem1, picItem2, picItem3, picItem4, picItem5, picItem6 };
            foreach (PictureBox picture in itemPictures)
            {
                SetDataDragonSummonerItemUrl(items[counter]);
                picture.Load(Url);
                picture.Visible = true;
                counter++;
            }
            


            SetDataDragonSummonerItemUrl(matchStats.Participants[participantId - 1].Stats.Item6);
            picItem6.Load(Url);

        }

        static public MatchStats GetMatchStats(long matchId)
        {
            SetUrl($"match/v3/matches/", matchId);

            return JsonConvert.DeserializeObject<MatchStats>(MakeRequest());

        }

        public Champion GetChampionData(string jsonResult, int championKey)
        {
            JToken jToken = JToken.Parse(jsonResult);
            List<Champion> allChampions = new List<Champion>();
            foreach (JToken jsonChampion in jToken["data"])
            {
                allChampions.Add(JsonConvert.DeserializeObject<Champion>(jsonChampion.First().ToString()));
            }
            return allChampions.Where(champion => champion.Key.CompareTo(championKey) == 0).FirstOrDefault();
        }

        public SummonerSpell GetSummonerSpell(string jsonResult, int summonerSpellKey)
        {
            JToken jToken = JToken.Parse(jsonResult);
            List<SummonerSpell> allSummonerSpells = new List<SummonerSpell>();
            foreach (JToken jsonSummonerSpell in jToken["data"])
            {
                allSummonerSpells.Add(JsonConvert.DeserializeObject<SummonerSpell>(jsonSummonerSpell.First().ToString()));
            }
            return allSummonerSpells.Where(summonerSpell => summonerSpell.Key.CompareTo(summonerSpellKey) == 0).FirstOrDefault();
        }


        public SummonerNameData GetSummonerProfileData(string userName)
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

            string jsonResult = Client.GetAsync(Url).Result.Content.ReadAsStringAsync().Result;

            JToken jTokenRank = JToken.Parse(jsonResult);
            List<RankInfo> allRankQueues = new List<RankInfo>();

            foreach (JToken jsonRankQueue in jTokenRank)
            {
                allRankQueues.Add(JsonConvert.DeserializeObject<RankInfo>(jsonRankQueue.ToString()));
            }

            return allRankQueues.Where(queue => queue.QueueType == "RANKED_SOLO_5x5").FirstOrDefault();
        }

        static private void SetDataDragonChampionUrl(string championName)
        {
            Url = string.Format(@"{0}{1}.png", CHAMP_ICONS, championName);
        }

        static private void SetDataDragonSummonerSpellUrl(string summonerSpell)
        {
            Url = string.Format(@"{0}{1}.png", SUMMONER_SPELL_ICONS, summonerSpell);
        }

        static private void SetDataDragonSummonerItemUrl(int item)
        {
            Url = string.Format(@"{0}{1}.png", ITEM_ICONS, item);
        }

        static private void SetUrl(string url, string userName)
        {
            Url = String.Format(@"{0}{1}{2}{3}", RIOT_API_URL, url, userName, APIKey);
        }

        static private void SetUrl(string url, int summonderId)
        {
            Url = String.Format(@"{0}{1}{2}{3}", RIOT_API_URL, url, summonderId, APIKey);
        }

        static private void SetUrl(string url, long gameId)
        {
            Url = String.Format(@"{0}{1}{2}{3}", RIOT_API_URL, url, gameId, APIKey);
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
