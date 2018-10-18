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

namespace LeagueReports
{
    public partial class Form1 : Form
    {
        static string Url;
        static string APIKey;
        static HttpClient Client;
        const string RIOT_API_URL = "https://na1.api.riotgames.com/lol/";

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

            lblSummonerName.Text = data.SummonerName;
            lblTitle.Text = data.SummonerName;
            lblSummonerLevel.Text = data.SummonerLevel.ToString();
        }

        static public SummonerNameData GetSummonerProfileData(string userName)
        //static public string GetSummonerProfileData(string userName)
        {
            SetUrl("summoner/v3/summoners/by-name/", userName);

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
