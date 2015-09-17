using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp4956_Lab1
{
    public partial class AppInfoForm : Form
    {
        public string specialty = "";
        public string application = "";
        public string owner = "";
        public string year = "2015";
        public bool okPressed = false;
        public AppInfoForm()
        {
            InitializeComponent();
        }

        private void specialtyText_TextChanged(Object sender, EventArgs e)
        {
            specialty = ((TextBox)sender).Text;
        }

        private void applicationText_TextChanged(object sender, EventArgs e)
        {
            application = ((TextBox)sender).Text;
        }

        private void ownerText_TextChanged(object sender, EventArgs e)
        {
            owner = ((TextBox)sender).Text;
        }

        private void yearText_ValueChanged(object sender, EventArgs e)
        {
            decimal temp = ((NumericUpDown)sender).Value;
            year = temp.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            okPressed = true;
            this.Close();
        }
    }
}
