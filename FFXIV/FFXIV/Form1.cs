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
        static HttpClient client;
        List<PictureBox> allClassIcons;
        List<Label> allClassLevels;

        public Form1()
        {
            InitializeComponent();

            Base_Url = "https://xivapi.com";
            Character_Url = "https://xivapi.com/character/";
            Title_Url = "https://xivapi.com/Title/";
            Class_Url = "https://xivapi.com/classjob/";
            ClassIcon_Url = "https://xivapi.com/cj/1/";
            ClassIconAlt_Url = "https://xivapi.com/cj/companion/";

            client = new HttpClient();

            //allClassIcons = new List<PictureBox> { pbMarWar, pbGladPal, pbDarkKnight, pbCnjWhm, pbAcnSch, pbAstrologian, pbLncDrg, pbPugMnk, pbRogNin, pbArcBrd, pbThmBlm, pbAcnSum, pbMachinist, pbSamurai, pbRedMage, pbBlueMage, pbCarpenter, pbBlacksmith, pbArmorer, pbGoldsmith, pbLeatherworker, pbWeaver, pbAlchemist, pbCulinarian, pbMiner, pbBotanist, pbFisher };
            allClassIcons = new List<PictureBox> { pbArmorer, pbGoldsmith, pbLeatherworker, pbWeaver, pbAlchemist, pbCulinarian, pbMiner, pbBotanist, pbFisher, pbGlaPal, pbAcnSum, pbAcnSch, pbRogNin, pbPugMnk, pbMachinist, pbDarkKnight, pbAstrologian, pbSamurai, pbRedMage, pbBlueMage, pbMrdWar, pbLncDrg, pbArcBrd, pbCnjWhm, pbThmBlm, pbCarpenter, pbBlacksmith };
            allClassLevels = new List<Label> { lblArmorerLevel, lblGoldsmithLevel, lblLeatherworkerLevel, lblWeaverLevel, lblAlchemistLevel, lblCulinarianLevel, lblMinerLevel, lblBotanistLevel, lblFisherLevel, lblGlaPalLevel, lblAcnSumLevel, lblAcnSchLevel, lblRogNinLevel, lblPugMnkLevel, lblMachinistLevel, lblDarkKnightLevel, lblAstrologianLevel, lblSamuraiLevel, lblRedMageLevel, lblBlueMageLevel, lblMrdWarLevel, lblLncDrgLevel, lblArcBrdLevel, lblCnjWhmLevel, lblThmBlmLevel, lblCarpenterLevel, lblBlacksmithLevel };

            //Ryan - 2760399  Sam - 25465442  Thomas - 8014946
            Character character = GetCharacterData(Character_Url, 8014946);
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
            PopulateAllClassAbbreviations();
            PopulateAllClassNames();
            PopulateAllClassLevels();
        }

        private ClassJobInfo GetAllClassData(string url, int classId)
        {
            url += classId;
            ClassJobInfo classInfo = JsonConvert.DeserializeObject<ClassJobInfo>(MakeRequest(url));
            return classInfo;
        }

        private void PopulateAllClassIcons(Dictionary<string, ClassJob> characterClasses)
        {
            int indexCounter = 0;

            foreach(var classJob in characterClasses)
            {
                string testString = classJob.Key;
                string[] classJobValues = testString.Split('_');
                
                if (classJobValues[0].Equals(classJobValues[1]))
                {
                    ClassJobInfo classInfo = GetClassData(Class_Url, classJob.Value.JobId);
                    string formattedClassName = classInfo.Name.Replace(" ", "");
                    allClassIcons[indexCounter].Load(ClassIconAlt_Url + formattedClassName +".png");
                    allClassLevels[indexCounter].Text = classJob.Value.Level.ToString();
                }
                else if(classJob.Value.Level > 30)
                {
                    ClassJobInfo classInfo = GetClassData(Class_Url, classJob.Value.JobId);
                    string formattedClassName = classInfo.Name.Replace(" ", "");
                    allClassIcons[indexCounter].Load(ClassIconAlt_Url + formattedClassName + ".png");
                    allClassLevels[indexCounter].Text = classJob.Value.Level.ToString();
                }
                else
                {
                    ClassJobInfo classInfo = GetClassData(Class_Url, classJob.Value.ClassId);
                    string formattedClassName = classInfo.Name.Replace(" ", "");
                    allClassIcons[indexCounter].Load(ClassIconAlt_Url + formattedClassName + ".png");
                    allClassLevels[indexCounter].Text = classJob.Value.Level.ToString();
                }
                indexCounter++;
            }
        }
        private void PopulateAllClassAbbreviations()
        {

        }
        private void PopulateAllClassNames()
        {

        }
        private void PopulateAllClassLevels()
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
