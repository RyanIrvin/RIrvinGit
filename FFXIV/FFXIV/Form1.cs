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
        static string ClassIcon_Url;
        static string ClassIconAlt_Url;
        static string APIKey;
        static HttpClient Client;
        List<PictureBox> AllClassIcons;
        List<Label> AllClassLevels;
        Dictionary<string, PictureBox> PictureBoxDictionary;
        Dictionary<string, Label> LabelDictionary;

        public Form1()
        {
            InitializeComponent();

            Base_Url = "https://xivapi.com";
            Character_Url = "https://xivapi.com/character/";
            Title_Url = "https://xivapi.com/Title/";
            Class_Url = "https://xivapi.com/classjob/";
            ClassIcon_Url = "https://xivapi.com/cj/1/";
            ClassIconAlt_Url = "https://xivapi.com/cj/companion/";

            Client = new HttpClient();

            PictureBoxDictionary = new Dictionary<string, PictureBox> { { "10", pbArmorer }, { "11", pbGoldsmith }, { "12", pbLeatherworker },{ "13", pbWeaver }, { "14", pbAlchemist }, { "15", pbCulinarian }, { "16", pbMiner }, { "17", pbBotanist }, { "18", pbFisher }, { "1", pbGlaPal },{ "19", pbGlaPal }, { "26", pbAcnSum }, { "27", pbAcnSum }, { "28", pbAcnSch }, { "29", pbRogNin }, { "30", pbRogNin }, { "2", pbPugMnk }, { "20", pbPugMnk }, { "31", pbMachinist },{ "32", pbDarkKnight }, { "33", pbAstrologian }, { "34", pbSamurai }, { "35", pbRedMage }, { "36", pbBlueMage }, { "3", pbMrdWar }, { "21", pbMrdWar }, { "4", pbLncDrg }, { "22", pbLncDrg }, { "5", pbArcBrd }, { "23", pbArcBrd }, { "6", pbCnjWhm }, { "24", pbCnjWhm }, { "7", pbThmBlm }, { "25", pbThmBlm }, { "8", pbCarpenter }, {"9",pbBlacksmith }};
            LabelDictionary = new Dictionary<string, Label> { { "10", lblArmorerLevel }, { "11", lblGoldsmithLevel }, { "12", lblLeatherworkerLevel }, { "13", lblWeaverLevel }, { "14", lblAlchemistLevel }, { "15", lblCulinarianLevel }, { "16", lblMinerLevel }, { "17", lblBotanistLevel }, { "18", lblFisherLevel }, { "1", lblGlaPalLevel }, { "19", lblGlaPalLevel }, { "26", lblAcnSumLevel }, { "27", lblAcnSumLevel }, { "28", lblAcnSchLevel }, { "29", lblRogNinLevel }, { "30", lblRogNinLevel }, { "2", lblPugMnkLevel }, { "20", lblPugMnkLevel }, { "31", lblMachinistLevel }, { "32", lblDarkKnightLevel }, { "33", lblAstrologianLevel }, { "34", lblSamuraiLevel }, { "35", lblRedMageLevel }, { "36", lblBlueMageLevel }, { "3", lblMrdWarLevel }, { "21", lblMrdWarLevel }, { "4", lblLncDrgLevel }, { "22", lblLncDrgLevel }, { "5", lblArcBrdLevel }, { "23", lblArcBrdLevel }, { "6", lblCnjWhmLevel }, { "24", lblCnjWhmLevel }, { "7", lblThmBlmLevel }, { "25", lblThmBlmLevel }, { "8", lblCarpenterLevel }, { "9", lblBlacksmithLevel }};

            //Ryan - 2760399  Sam - 25465442  Thomas - 8014946
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
            PopulateAllClassInfo(character);
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
            ClassJobInfo classInfo = GetClassData(Class_Url, character.ActiveClassJob.JobId);
            PopulateCurrentClassIcon(Base_Url, classInfo.Icon);
            PopulateCurrentClassAbbreviation(classInfo.Abbreviation);
            PopulateCurrentClassName(classInfo.Name);
            PopulateCurrentClassLevel(character.ActiveClassJob.Level);
        }

        private ClassJobInfo GetClassData(string url, int classId)
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
            //ClassJobInfo allClassInfo = GetAllClassData(Class_Url, character.ClassJobs);
            PopulateAllClassIcons(character.ClassJobs);
        }

        private ClassJobInfo GetAllClassData(string url, int classId)
        {
            url += classId;
            ClassJobInfo classInfo = JsonConvert.DeserializeObject<ClassJobInfo>(MakeRequest(url));
            return classInfo;
        }

        private void PopulateAllClassIcons(Dictionary<string, ClassJob> characterClasses)
        {

            foreach (var classJob in characterClasses)
            {
                bool job = classJob.Value.Level <= 30 ? false : true;
                string[] classJobValues = classJob.Key.Split('_');
                string classJobValue = job ? classJobValues[0] : classJobValues[1];
                ClassJobInfo classInfo = GetClassData(Class_Url, job ? classJob.Value.JobId : classJob.Value.ClassId);
                string formattedClassName = classInfo.Name.Replace(" ", "");

                PictureBoxDictionary[classJobValue].Load(ClassIconAlt_Url + formattedClassName + ".png");
                LabelDictionary[classJobValue].Text = classJob.Value.Level.ToString();
            }
        }

        private string MakeRequest(string url)
        {
            using (HttpResponseMessage response = Client.GetAsync(url).Result)
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
