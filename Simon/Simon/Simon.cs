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

namespace Simon
{
    public partial class frmSimon : Form
    {
        public frmSimon()
        {
            InitializeComponent();
        }

        int currentStep = 0;
        List<int> pattern = new List<int>();
        Random rand = new Random();
        bool animation = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            int level = 1;
            lblLevelValue.Text = level.ToString();

            pattern.Add(rand.Next(0, 4));
            new Thread(animate).Start();
        }

        void animate()
        {
            animation = true;
            foreach(int color in pattern)
            {
                switch(color)
                {
                    case 0:
                        btnRed.BackColor = Color.Red;
                        Thread.Sleep(200);
                        btnRed.BackColor = Color.Transparent;
                        break;

                    case 1:
                        break;

                    case 2:
                        break;
                }
            }
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {

        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {

        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {

        }
    }
}
