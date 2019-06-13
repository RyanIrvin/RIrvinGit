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
using Newtonsoft.Json;

namespace FFXIV
{
    public partial class Form1 : Form
    {
        static string Url;
        static string APIKey;
        static HttpClient client;

        public Form1()
        {
            InitializeComponent();

            Url = "https://xivapi.com/character/2760399";
            client = new HttpClient();

            Character character = GetCharacterData(Url);
            PopulateCharacterData(character);

        }

        private void PopulateCharacterData(Character character)
        {
            PopulateCharacterPortrait(character.Portrait.ToString());
            PopulateCharacterName(character.Name.ToString());
            PopulateCharacterTitle(character.Title);
        }

        private void PopulateCharacterPortrait(string Url) => pbCharacter.Load(Url);

        private void PopulateCharacterName(string characterName) => lblCharacterName.Text = characterName;

        private void PopulateCharacterTitle(int characterTitle)
        {
            Title title = GetTitleData("https://xivapi.com/Title/", characterTitle);
            lblCharacterTitle.Text = title.Name;
        }

        private Character GetCharacterData(string url)
        {
            Account account = JsonConvert.DeserializeObject<Account>(MakeRequest(url));
            return account.Character;
        }

        private Title GetTitleData(string url, int titleId)
        {
            url += titleId;
            Title title = JsonConvert.DeserializeObject<Title>(MakeRequest(url));
            return title;
        }

        

        private string MakeRequest(string url)
        {
            using (HttpResponseMessage response = client.GetAsync(url).Result)
            using (HttpContent content = response.Content)
            {
                return content.ReadAsStringAsync().Result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
