using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Character_Loader
{

    public partial class CharacterSearchForm : Form
    {
        public CharacterSearchForm()
        {
            CenterToScreen();
            InitializeComponent();
        }

        //Close all forms if program is closed via X button
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            Application.Exit();
        }

        private void CharacterSearchForm_Load(object sender, EventArgs e)
        {
            LoadServerRegionComboBoxValues();

        }

        private void CbServerRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadServerDataCenterComboBoxValues();
        }

        private void CbServerDataCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadServerWorldComboBoxValues();
        }

        private void LoadServerRegionComboBoxValues()
        {
            cbServerRegion.Items.Add("NA");
            cbServerRegion.Items.Add("EU");
            cbServerRegion.Items.Add("JP");
        }

        private void LoadServerDataCenterComboBoxValues()
        {
            cbServerDataCenter.Items.Clear();

            switch (cbServerRegion.Text)
            {
                case "NA":
                    cbServerDataCenter.Items.Add("Aether");
                    cbServerDataCenter.Items.Add("Primal");
                    cbServerDataCenter.Items.Add("Crystal");
                    break;

                case "EU":
                    cbServerDataCenter.Items.Add("Chaos");
                    cbServerDataCenter.Items.Add("Light");
                    break;

                case "JP":
                    cbServerDataCenter.Items.Add("Elemental");
                    cbServerDataCenter.Items.Add("Gaia");
                    cbServerDataCenter.Items.Add("Mana");
                    break;
            }
        }

        private void LoadServerWorldComboBoxValues()
        {
            cbServerWorld.Items.Clear();

            switch (cbServerDataCenter.Text)
            {
                case "Aether":
                    cbServerWorld.Items.Add("Adamantoise");
                    cbServerWorld.Items.Add("Cactuar");
                    cbServerWorld.Items.Add("Faerie");
                    cbServerWorld.Items.Add("Gilgamesh");
                    cbServerWorld.Items.Add("Jenova");
                    cbServerWorld.Items.Add("Midgardsormr");
                    cbServerWorld.Items.Add("Sargatanas");
                    cbServerWorld.Items.Add("Siren");
                    break;

                case "Primal":
                    cbServerWorld.Items.Add("Behemoth");
                    cbServerWorld.Items.Add("Excalibur");
                    cbServerWorld.Items.Add("Exodus");
                    cbServerWorld.Items.Add("Famfrit");
                    cbServerWorld.Items.Add("Hyperion");
                    cbServerWorld.Items.Add("Lamia");
                    cbServerWorld.Items.Add("Leviathan");
                    cbServerWorld.Items.Add("Ultros");
                    break;

                case "Crystal":
                    cbServerWorld.Items.Add("Balmung");
                    cbServerWorld.Items.Add("Brynhildr");
                    cbServerWorld.Items.Add("Coeurl");
                    cbServerWorld.Items.Add("Diabolos");
                    cbServerWorld.Items.Add("Goblin");
                    cbServerWorld.Items.Add("Malboro");
                    cbServerWorld.Items.Add("Mateus");
                    cbServerWorld.Items.Add("Zalera");
                    break;

                case "Chaos":
                    cbServerWorld.Items.Add("Cerberus");
                    cbServerWorld.Items.Add("Louisoix");
                    cbServerWorld.Items.Add("Moogle");
                    cbServerWorld.Items.Add("Omega");
                    cbServerWorld.Items.Add("Ragnarok");
                    cbServerWorld.Items.Add("Spriggan");
                    break;

                case "Light":
                    cbServerWorld.Items.Add("Lich");
                    cbServerWorld.Items.Add("Odin");
                    cbServerWorld.Items.Add("Phoenix");
                    cbServerWorld.Items.Add("Shiva");
                    cbServerWorld.Items.Add("Twintania");
                    cbServerWorld.Items.Add("Zodiark");
                    break;

                case "Elemental":
                    cbServerWorld.Items.Add("Aegis");
                    cbServerWorld.Items.Add("Atomos");
                    cbServerWorld.Items.Add("Carbuncle");
                    cbServerWorld.Items.Add("Garuda");
                    cbServerWorld.Items.Add("Gungnir");
                    cbServerWorld.Items.Add("Kujata");
                    cbServerWorld.Items.Add("Ramuh");
                    cbServerWorld.Items.Add("Tonberry");
                    cbServerWorld.Items.Add("Typhon");
                    cbServerWorld.Items.Add("Unicorn");
                    break;

                case "Gaia":
                    cbServerWorld.Items.Add("Alexander");
                    cbServerWorld.Items.Add("Bahamut");
                    cbServerWorld.Items.Add("Durandal");
                    cbServerWorld.Items.Add("Fenrir");
                    cbServerWorld.Items.Add("Ifrit");
                    cbServerWorld.Items.Add("Ridill");
                    cbServerWorld.Items.Add("Tiamat");
                    cbServerWorld.Items.Add("Ultima");
                    cbServerWorld.Items.Add("Valefor");
                    cbServerWorld.Items.Add("Yojimbo");
                    cbServerWorld.Items.Add("Zeromus");
                    break;

                case "Mana":
                    cbServerWorld.Items.Add("Anima");
                    cbServerWorld.Items.Add("Asura");
                    cbServerWorld.Items.Add("Belias");
                    cbServerWorld.Items.Add("Chocobo");
                    cbServerWorld.Items.Add("Hades");
                    cbServerWorld.Items.Add("Ixion");
                    cbServerWorld.Items.Add("Mandragora");
                    cbServerWorld.Items.Add("Masamune");
                    cbServerWorld.Items.Add("Pandaemonium");
                    cbServerWorld.Items.Add("Shinryu");
                    cbServerWorld.Items.Add("Titan");
                    break;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbServerWorld.Text))
            {
                //Submits entered character name and selected world for search
                FFXIVClient.SearchCharacterName(txtCharacterName.Text, cbServerWorld.Text);
                CharacterPickerForm form = new CharacterPickerForm();
                form.Show();
                Hide();
            }
            else
                MessageBox.Show("Please select your world.");
         }
    }
}
