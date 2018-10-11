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
        int currentStep = 0;
        List<int> pattern = new List<int>();
        Random rand = new Random();
        bool playing = false;

        void ColorFlash(int color)
        {
            switch (color)
            {
                case 0:
                    BtnRed.BackColor = Color.Red;
                    Thread.Sleep(100);
                    BtnRed.BackColor = Color.Transparent;
                    break;

                case 1:
                    BtnBlue.BackColor = Color.Blue;
                    Thread.Sleep(100);
                    BtnBlue.BackColor = Color.Transparent;
                    break;

                case 2:
                    BtnGreen.BackColor = Color.Green;
                    Thread.Sleep(100);
                    BtnGreen.BackColor = Color.Transparent;
                    break;

                case 3:
                    BtnYellow.BackColor = Color.Yellow;
                    Thread.Sleep(100);
                    BtnYellow.BackColor = Color.Transparent;
                    break;
            }
        }

        void Animate()
        {
            playing = true;
            foreach (int color in pattern)
            {
                switch (color)
                {
                    //Highlights button with its color for 200ms to show next step in the pattern
                    case 0:
                        BtnRed.BackColor = Color.Red;
                        Thread.Sleep(200);
                        BtnRed.BackColor = Color.Transparent;
                        break;

                    case 1:
                        BtnBlue.BackColor = Color.Blue;
                        Thread.Sleep(200);
                        BtnBlue.BackColor = Color.Transparent;
                        break;

                    case 2:
                        BtnGreen.BackColor = Color.Green;
                        Thread.Sleep(200);
                        BtnGreen.BackColor = Color.Transparent;
                        break;

                    case 3:
                        BtnYellow.BackColor = Color.Yellow;
                        Thread.Sleep(200);
                        BtnYellow.BackColor = Color.Transparent;
                        break;
                }

                //200ms delay between color flashes when playing pattern
                Thread.Sleep(200);
            }
            playing = false;
        }

        void TestCorrect(int color)
        {
            if (playing)
                return;

            if (pattern[currentStep] == color)
                currentStep++;
            else
            {
                MessageBox.Show("You lose! Score: " + pattern.Count.ToString());
                currentStep = 0;
                pattern = new List<int>();
                new Thread(Animate).Start();

            }

            if (currentStep >= pattern.Count)
            {
                pattern.Add(rand.Next(0, 4));
                currentStep = 0;
                new Thread(Animate).Start();
            }
            lblLevel.Text = ("Level: " + pattern.Count.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public frmSimon()
        {
            InitializeComponent();
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o => ColorFlash(0));

            TestCorrect(0);
        }

        private void BtnBlue_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o => ColorFlash(1));
            TestCorrect(1);
        }

        private void BtnGreen_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o => ColorFlash(2));
            TestCorrect(2);
        }

        private void BtnYellow_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o => ColorFlash(3));
            TestCorrect(3);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            pattern.Add(rand.Next(0, 4));
            new Thread(Animate).Start();
        }
    }
}
