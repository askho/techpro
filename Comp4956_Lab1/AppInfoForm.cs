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
            bool errorOccured = false;
            if (!fieldValid(specialtyText))
            {
                specialityError.SetError(this.specialtyText, "You must have this filled out");
                errorOccured = true;
            } else
            {
                specialityError.SetError(this.specialtyText, String.Empty);
            }
            if (!fieldValid(applicationText))
            {
                applicationError.SetError(this.applicationText, "You must have this filled out");
                errorOccured = true;
            } else
            {
                applicationError.SetError(this.applicationText, String.Empty);
            }
            if (!fieldValid(ownerText))
            {
                ownerError.SetError(this.ownerText, "You must have filled this out");
                errorOccured = true;
            } else
            {
                ownerError.SetError(this.ownerText, String.Empty);
            }
            if(errorOccured)
            {
                return;
            }
            okPressed = true;
            this.Close();
        }

        private void specialtyText_Leave(object sender, EventArgs e)
        {
            if (!fieldValid((TextBox)sender))
            {
                specialtyText.Focus();
                specialityError.SetError(this.specialtyText, "You must have this filled out");
            } else
            {
                specialityError.SetError(this.specialtyText, String.Empty);
            }
        }

        private void applicationText_Leave(object sender, EventArgs e)
        {
            if (!fieldValid((TextBox)sender))
            {
                applicationText.Focus();
                applicationError.SetError(this.applicationText, "You must fill this out.");
            } else
            {
                applicationError.SetError(this.applicationText, String.Empty);
            }
        }

        private void ownerText_Leave(object sender, EventArgs e)
        {
            if(!fieldValid((TextBox)sender))
            {
                ownerText.Focus();
                ownerError.SetError(this.ownerText, "You must fill this out");
            } else
            {
                ownerError.SetError(this.ownerText, String.Empty);
            }
        }

        private bool fieldValid(TextBox field)
        {
            if (field.Text == String.Empty)
                return false;
            return true;
        }
    }
}
