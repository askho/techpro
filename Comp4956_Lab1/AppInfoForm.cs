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
    /// <summary>
    /// This class is for asking the user what information they want to put
    /// in the new application for the registry. 
    /// </summary>
    public partial class AppInfoForm : Form
    {
        /// <summary>
        /// The speciality entered by the user
        /// </summary>
        public string specialty = "";
        /// <summary>
        /// The application set by the user
        /// </summary>
        public string application = "";
        /// <summary>
        /// The owner set by the user
        /// </summary>
        public string owner = "";
        /// <summary>
        /// The year entered by the user 
        /// </summary>
        public string year = "2015";
        /// <summary>
        /// This is set to be true if the user presses
        /// ok to close the form. 
        /// </summary>
        public bool okPressed = false;
        /// <summary>
        /// The constructor not used.
        /// </summary>
        public AppInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Event handler for the the text for the specialty is changed
        /// Updates the specialty property.
        /// </summary>
        /// <param name="sender">The textbox that was changed</param>
        /// <param name="e">Event arguments</param>
        private void specialtyText_TextChanged(Object sender, EventArgs e)
        {
            specialty = ((TextBox)sender).Text;
        }
        /// <summary>
        /// Event handler for when the application text is changed
        /// updates the application property.
        /// </summary>
        /// <param name="sender">the application text box</param>
        /// <param name="e">event args</param>
        private void applicationText_TextChanged(object sender, EventArgs e)
        {
            application = ((TextBox)sender).Text;
        }
        /// <summary>
        /// Event handler for when the owner text is changed
        /// Updates the owner property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ownerText_TextChanged(object sender, EventArgs e)
        {
            owner = ((TextBox)sender).Text;
        }
        /// <summary>
        /// Event handler for when the year text is changed
        /// Updates the year property
        /// </summary>
        /// <param name="sender">The yeartext object</param>
        /// <param name="e">event args</param>
        private void yearText_ValueChanged(object sender, EventArgs e)
        {
            decimal temp = ((NumericUpDown)sender).Value;
            year = temp.ToString();
        }
        /// <summary>
        /// Event handler for when the cancel button gets clicked.
        /// Closes the form
        /// </summary>
        /// <param name="sender">The cancel button</param>
        /// <param name="e">event args</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Event handler for when the ok button gets clicked
        /// Validates the form and if its ok, it will close the form and set the ok
        /// pressed property to true
        /// </summary>
        /// <param name="sender">The ok button</param>
        /// <param name="e">event args</param>
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
        /// <summary>
        /// Validtes the specialty text field. If it fails to validate
        /// it will refocus the specialty text box. 
        /// </summary>
        /// <param name="sender">Sepcialty text box</param>
        /// <param name="e">event args</param>
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
        /// <summary>
        /// Validates the application text. If it fails to validate
        /// it will refocus the application text box.
        /// </summary>
        /// <param name="sender">application text box</param>
        /// <param name="e">object sender</param>
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
        /// <summary>
        /// Validates the owner text field. If it fails to validate it
        /// will refocus the owner text box. 
        /// </summary>
        /// <param name="sender">owner text field</param>
        /// <param name="e">event args</param>
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
        /// <summary>
        /// Validates the text, of a text box and makes sure that its not empty. 
        /// </summary>
        /// <param name="field">The text box.</param>
        /// <returns></returns>
        private bool fieldValid(TextBox field)
        {
            if (field.Text == String.Empty)
                return false;
            return true;
        }
    }
}
