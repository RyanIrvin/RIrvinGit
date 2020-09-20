using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemLookUpGUI
{
    public partial class UserControl1: UserControl
    {
        ItemLookup ItemLookup;

        public UserControl1()
        {
            InitializeComponent();
            ItemLookup = new ItemLookup();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = ItemLookup.FindItem(InputTextBox.Text);
        }
    }
}
