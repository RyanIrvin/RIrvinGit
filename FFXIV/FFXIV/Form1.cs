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
            pbCharacter.Load(character.Portrait.ToString());

        }

        private Character GetCharacterData(string Url)
        {
            string testRequest = MakeRequest();
            var account =  JsonConvert.DeserializeObject<Account>(testRequest);
            return account.Character;
        }

        private string MakeRequest()
        {
            using (HttpResponseMessage response = client.GetAsync(Url).Result)
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
