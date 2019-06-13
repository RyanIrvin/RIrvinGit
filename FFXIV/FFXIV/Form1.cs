using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace FFXIV
{
    public partial class Form1 : Form
    {
        static string Base_Url;
        static string Character_Url;
        static string Title_Url;
        static string Class_Url;
        static string APIKey;
        static HttpClient client;

        public Form1()
        {
            InitializeComponent();

            Base_Url = "https://xivapi.com";
            Character_Url = "https://xivapi.com/character/";
            Title_Url = "https://xivapi.com/Title/";
            Class_Url = "https://xivapi.com/classjob/";
            client = new HttpClient();

            Character character = GetCharacterData(Character_Url, 2760399);
            PopulateCharacterData(character);
        }

        private Character GetCharacterData(string url, int characterId)
        {
            url += characterId;
            Account account = JsonConvert.DeserializeObject<Account>(MakeRequest(url));
            return account.Character;
        }

        private void PopulateCharacterData(Character character)
        {
            PopulateCharacterPortrait(character.Portrait.ToString());
            PopulateCharacterName(character.Name.ToString());
            PopulateCharacterTitle(character.Title);
            PopulateCurrentClassInfo(character);
        }

        private void PopulateCharacterPortrait(string url) => pbCharacter.Load(url);

        private void PopulateCharacterName(string characterName) => lblCharacterName.Text = characterName;

        private void PopulateCharacterTitle(int characterTitle)
        {
            Title title = GetTitleData(Title_Url, characterTitle);
            lblCharacterTitle.Text = title.Name;
        }

        private Title GetTitleData(string url, int titleId)
        {
            url += titleId;
            Title title = JsonConvert.DeserializeObject<Title>(MakeRequest(url));
            return title;
        }

        private void PopulateCurrentClassInfo(Character character)
        {
            ClassJobInfo classInfo = GetCurrentClassData(Class_Url, character.ActiveClassJob.JobId);
            PopulateCurrentClassIcon(Base_Url, classInfo.Icon);
            PopulateCurrentClassAbbreviation(classInfo.Abbreviation);
            PopulateCurrentClassName(classInfo.Name);
            PopulateCurrentClassLevel(character.ActiveClassJob.Level);
        }

        private ClassJobInfo GetCurrentClassData(string url, int classId)
        {
            url += classId;
            ClassJobInfo classInfo = JsonConvert.DeserializeObject<ClassJobInfo>(MakeRequest(url));
            return classInfo;
        }

        private void PopulateCurrentClassIcon(string url, string iconUrl)
        {
            url += iconUrl;
            pbCurrentClassIcon.Load(url);
        }

        private void PopulateCurrentClassAbbreviation(string abbreviation)
        {
            lblClassAbbreviation.Text = abbreviation;
        }

        private void PopulateCurrentClassName(string className)
        {
            lblCurrentClassName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(className);
        }

        private void PopulateCurrentClassLevel(int classLevel)
        {
            lblCurrentClassLevel.Text = "Level: " + classLevel.ToString();
        }

        private void PopulateAllClassInfo(Character character) //TO-DO
        {
            ClassJobInfo classInfo = GetCurrentClassData(Class_Url, character.ActiveClassJob.JobId);
            PopulateAllClassIcon();
            PopulateAllClassAbbreviation();
            PopulateAllClassName();
            PopulateAllClassLevel();
        }

        private void PopulateAllClassIcon()
        {

        }
        private void PopulateAllClassAbbreviation()
        {

        }
        private void PopulateAllClassName()
        {

        }
        private void PopulateAllClassLevel()
        {

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
