using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DiceRoller
{
    public partial class DiceRoller : Form
    {
        Random rnd = new Random();
        
        private string Roll(int maxNumber)
        {
            RollAnimation(maxNumber);
            return rnd.Next(1, maxNumber).ToString();
        }

        private void RollAnimation(int maxNumber)
        {
            for (int i = 0; i < 10; i++)
            {
                lblDiceRoll.Text = rnd.Next(1, maxNumber).ToString();
                Thread.Sleep(20);
                Refresh();
            }
        }

        private bool IsNumberValid(string number)
        {
            Int32.TryParse(txtCustom.Text, out int numberValidate);
            if (numberValidate < 2)
            { 
                MessageBox.Show("Please enter a valid whole number between 2 and 9999.");
                return false;
            }
            else
                return true;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (IsNumberValid(txtCustom.Text))
            {
                int customNumber = Convert.ToInt32(txtCustom.Text);
                lblDiceRoll.Text = Roll(customNumber += 1);
            }
        }

        public DiceRoller()
        {
            InitializeComponent();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {

            lblDiceRoll.Text = Roll(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblDiceRoll.Text = Roll(7);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblDiceRoll.Text = Roll(9);
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblDiceRoll.Text = Roll(11);
        }

        private void btnTwelve_Click(object sender, EventArgs e)
        {
            lblDiceRoll.Text = Roll(13);
        }

        private void btnTwenty_Click(object sender, EventArgs e)
        {
            lblDiceRoll.Text = Roll(21);
        }
    }
}
