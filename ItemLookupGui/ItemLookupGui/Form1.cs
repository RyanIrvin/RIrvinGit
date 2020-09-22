using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemLookupGui
{
    public partial class Form1 : Form
    {
        ItemLookup ItemLookup;
        public Form1()
        {
            InitializeComponent();
            ItemLookup = new ItemLookup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Join($"{Environment.NewLine}",ItemLookup.FindId(textBox1.Text));
        }
    }
}
