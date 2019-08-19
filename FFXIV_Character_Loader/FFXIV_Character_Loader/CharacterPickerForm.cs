using Newtonsoft.Json;
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
    public partial class CharacterPickerForm : Form
    {
        public CharacterPickerForm()
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

        private void ResizeFormWindow()
        {
            if (FFXIVClient.CharacterSearchResults.Count > 0 && FFXIVClient.CharacterSearchResults.Count <= 5)
            {
                this.Height = 135;
            }
            else if (FFXIVClient.CharacterSearchResults.Count > 5 && FFXIVClient.CharacterSearchResults.Count <= 10)
            {
                this.Height = 237;
            }
            else if ((FFXIVClient.CharacterSearchResults.Count > 10 && FFXIVClient.CharacterSearchResults.Count <= 15))
            {
                this.Height = 340;
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void CharacterPickerForm_Load(object sender, EventArgs e)
        {
            List<PictureBox> avatarPictureBoxes = new List<PictureBox> { pbAvatar0, pbAvatar1, pbAvatar2, pbAvatar3, pbAvatar4, pbAvatar5, pbAvatar6, pbAvatar7, pbAvatar8, pbAvatar9, pbAvatar10, pbAvatar11, pbAvatar12, pbAvatar13, pbAvatar14};
            ResizeFormWindow();

            for (int i = 0; i < FFXIVClient.CharacterSearchResults.Count; i++)
            {
                if (i == avatarPictureBoxes.Count)
                    break;

                avatarPictureBoxes[i].Load(FFXIVClient.CharacterSearchResults[i].Avatar.ToString());
                avatarPictureBoxes[i].Visible = true;
            }
        }

        private void PbAvatar0_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[0]);

        private void PbAvatar1_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[1]);

        private void PbAvatar2_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[2]);

        private void PbAvatar3_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[3]);

        private void PbAvatar4_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[4]);

        private void PbAvatar5_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[5]);

        private void PbAvatar6_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[6]);

        private void PbAvatar7_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[7]);

        private void PbAvatar8_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[8]);

        private void PbAvatar9_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[9]);

        private void PbAvatar10_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[10]);

        private void PbAvatar11_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[11]);

        private void PbAvatar12_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[12]);

        private void PbAvatar13_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[13]);

        private void PbAvatar14_Click(object sender, EventArgs e) => SelectCharacter(FFXIVClient.CharacterSearchResults[14]);

        private void SelectCharacter(Result result)
        {
            FFXIVClient.SetCharacterInfo(result);
            CharacterLoadoutForm form = new CharacterLoadoutForm();
            form.Show();
            Hide();
        }
    }
}
