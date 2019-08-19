using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Character_Loader
{
    public partial class CharacterLoadoutForm : Form
    {
        Dictionary<string, PictureBox> dictClassIcons;
        Dictionary<string, Label> dictClassLevels;

        public CharacterLoadoutForm()
        {
            CenterToScreen();
            InitializeComponent();
            PopulateClassIconsDictionary();
            PopulateClassLevelsDictionary();
        }

        private void PopulateClassIconsDictionary()
        {
            dictClassIcons = new Dictionary<string, PictureBox>()
            {
                { "gladiator", pbClassIconGladiator },
                { "paladin", pbClassIconPaladin },
                { "marauder", pbClassIconMarauder },
                { "warrior", pbClassIconWarrior },
                { "dark knight", pbClassIconDarkKnight },
                { "gunbreaker", pbClassIconGunbreaker },
                { "pugilist", pbClassIconPugilist },
                { "monk", pbClassIconMonk },
                { "lancer", pbClassIconLancer },
                { "dragoon", pbClassIconDragoon },
                { "rogue", pbClassIconRogue },
                { "ninja", pbClassIconNinja },
                { "samurai", pbClassIconSamurai },
                { "conjurer", pbClassIconConjurer },
                { "white mage", pbClassIconWhiteMage },
                { "arcanist", pbClassIconArcanist },
                { "scholar", pbClassIconScholar },
                { "astrologian", pbClassIconAstrologian },
                { "archer", pbClassIconArcher },
                { "bard", pbClassIconBard },
                { "machinist", pbClassIconMachinist },
                { "dancer", pbClassIconDancer },
                { "thaumaturge", pbClassIconThaumaturge  },
                { "black mage", pbClassIconBlackMage },
                { "summoner", pbClassIconSummoner },
                { "red mage", pbClassIconRedMage },
                { "blue mage", pbClassIconBlueMage },
                { "carpenter", pbClassIconCarpenter },
                { "blacksmith", pbClassIconBlacksmith },
                { "armorer", pbClassIconArmorer },
                { "goldsmith", pbClassIconGoldsmith },
                { "leatherworker", pbClassIconLeatherworker },
                { "weaver", pbClassIconWeaver },
                { "alchemist", pbClassIconAlchemist },
                { "culinarian", pbClassIconCulinarian },
                { "miner", pbClassIconMiner  },
                { "botanist", pbClassIconBotanist  },
                { "fisher", pbClassIconFisher },
            };
        }

        private void PopulateClassLevelsDictionary()
        {
            //Note that resulting job uses prereqruisite class' label to display level
            dictClassLevels = new Dictionary<string, Label>()
            {
                { "gladiator", lblClassLevelGladiator },
                { "paladin", lblClassLevelGladiator },
                { "marauder", lblClassLevelMarauder },
                { "warrior", lblClassLevelMarauder },
                { "dark knight", lblClassLevelDarkKnight },
                { "gunbreaker", lblClassLevelGunbreaker },
                { "pugilist", lblClassLevelPugilist },
                { "monk", lblClassLevelPugilist },
                { "lancer", lblClassLevelLancer },
                { "dragoon", lblClassLevelLancer },
                { "rogue", lblClassLevelRogue },
                { "ninja", lblClassLevelRogue },
                { "samurai", lblClassLevelSamurai },
                { "conjurer", lblClassLevelConjurer },
                { "white mage", lblClassLevelConjurer },
                { "arcanist", lblClassLevelArcanist },
                { "scholar", lblClassLevelScholar },
                { "astrologian", lblClassLevelAstrologian },
                { "archer", lblClassLevelArcher },
                { "bard", lblClassLevelArcher },
                { "machinist", lblClassLevelMachinist },
                { "dancer", lblClassLevelDancer },
                { "thaumaturge", lblClassLevelThaumaturge  },
                { "black mage", lblClassLevelThaumaturge },
                { "summoner", lblClassLevelArcanist },
                { "red mage", lblClassLevelRedMage },
                { "blue mage", lblClassLevelBlueMage },
                { "carpenter", lblClassLevelCarpenter },
                { "blacksmith", lblClassLevelBlacksmith },
                { "armorer", lblClassLevelArmorer },
                { "goldsmith", lblClassLevelGoldsmith },
                { "leatherworker", lblClassLevelLeatherworker },
                { "weaver", lblClassLevelWeaver },
                { "alchemist", lblClassLevelAlchemist },
                { "culinarian", lblClassLevelCulinarian },
                { "miner", lblClassLevelMiner  },
                { "botanist", lblClassLevelBotanist  },
                { "fisher", lblClassLevelFisher },
            };
        }

        //Close all forms if program is closed via X button
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            Application.Exit();
        }

        private void CharacterLoadoutForm_Load(object sender, EventArgs e)
        {
            CharacterData characterData = FFXIVClient.GetCharacterData();
            Character character = characterData.Character;
            LoadCharacterData(character);
        }

        private void LoadCharacterData(Character character)
        {
            lblCharacterName.Text = character.Name;
            pbCharacterPortrait.Load(character.Portrait.ToString());

            LoadCharacterClassInfo(character.ClassJobs);
        }

        private void LoadCharacterClassInfo(ClassJob[] characterClasses)
        {
            //Load Character Levels
            foreach (ClassJob classJob in characterClasses)
            {
                string className = classJob.Name;
                string[] classJobName = className.Replace(" ","").Split('/');

                //Checks if the base class changes to resulting job by comparing names in string
                bool classHasResultingJob = classJobName[0].Equals(classJobName[1]) ? false : true;

                //Default display for level 0 is -, do not overwrite unless class has a level
                if (classJob.Level != 0)
                    dictClassLevels[classJobName[0]].Text = classJob.Level.ToString();

                //Check if class results in a job and display job icon if level 30+
                if(classHasResultingJob && classJob.Level >= 30)
                    dictClassIcons[classJobName[1]].Visible = true;
            }
        }
    }
}