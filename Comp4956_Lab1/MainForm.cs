using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Comp4956_Lab1
{
    /// <summary>
    /// The main window of the application 
    /// </summary>
    public partial class mainWindow : Form
    {
        /// <summary>
        /// Constructor, not used. 
        /// </summary>
        public mainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens the app info form, and will update the registry with a new application 
        /// when the app info form is closed
        /// </summary>
        /// <param name="sender">The register button</param>
        /// <param name="e">Event args</param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            /*
            User the info form to get data from the user, when its closed update the registry.
            */
            AppInfoForm infoForm = new AppInfoForm();
            infoForm.Show();
            infoForm.FormClosing += InfoForm_FormClosing;
        }
        /// <summary>
        /// Opens a color picker, when closed will update the registry
        /// </summary>
        /// <param name="sender">Title button </param>
        /// <param name="e">Event args</param>
        private void titleColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                string selectedColorString = String.Format("{0} {1} {2}", 
                    selectedColor.R, 
                    selectedColor.G,
                    selectedColor.B);
                RegistryKey controlPanelKey = Registry.CurrentUser.OpenSubKey("Control Panel", true);
                RegistryKey colorKey = controlPanelKey.OpenSubKey("Colors", true);
                colorKey.SetValue("ActiveTitle", selectedColorString);

                
            }
        }
        /// <summary>
        /// Shows the disk info on the text box. 
        /// </summary>
        /// <param name="sender">The disk button</param>
        /// <param name="e">Event args</param>
        private void diskInfoButton_Click(object sender, EventArgs e)
        {
            
            this.textBox.Text = "Local Disks:\n";
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            foreach(ManagementObject drive in searcher.Get())
            {
                string name = (!Object.ReferenceEquals(null, drive["Name"]) ? drive["Name"] : "Unkown").ToString();
                string description = (!Object.ReferenceEquals(null, drive["Description"]) ? drive["Description"] : "Unknown").ToString();
                UInt32 errorCode = UInt32.Parse((!Object.ReferenceEquals(null, drive["ConfigManagerErrorCode"]) ? drive["ConfigManagerErrorCode"] : 0).ToString());
                string deviceId = (!Object.ReferenceEquals(null, drive["DeviceId"]) ? drive["deviceId"] : "Unknown").ToString();
                string fileSystem = (!Object.ReferenceEquals(null, drive["FileSystem"]) ? drive["FileSystem"] : "Unkown").ToString();
                double driveSize = double.Parse((!Object.ReferenceEquals(null, drive["Size"]) ? drive["Size"] : 0).ToString());
                double freeSpace = double.Parse((!Object.ReferenceEquals(null, drive["FreeSpace"]) ? drive["FreeSpace"] : 0).ToString());

                driveSize = Math.Round(driveSize * Math.Pow(2, -20)); // Convert to MB
                freeSpace = Math.Round(freeSpace * Math.Pow(2, -20));
                double usedSpace = driveSize - freeSpace;
                Console.WriteLine(Double.IsNaN(Math.Round((usedSpace / driveSize) * 100)));
                string usedPercentage = Double.IsNaN(Math.Round((usedSpace / driveSize) * 100)) ? "0" : Math.Round(((usedSpace / driveSize) * 100)).ToString();
                string freePercentage = Double.IsNaN(Math.Round((freeSpace / driveSize) * 100)) ? "0" : Math.Round(((freeSpace / driveSize) * 100)).ToString();

                //Console.WriteLine(drive["ConfigManagerErrorCode"]);
                textBox.Text += String.Format("Name: {0}\n", name);
                textBox.Text += String.Format("Description: {0}\n", description);
                textBox.Text += String.Format("Error Code: {0}\n", errorCode);
                textBox.Text += String.Format("Device ID: {0}\n", deviceId);
                textBox.Text += String.Format("FileSystem: {0}\n", fileSystem);
                textBox.Text += String.Format("Size: {0} MB\n", driveSize.ToString("#.#"));
                textBox.Text += String.Format("Used: {0} MB\n", usedSpace.ToString("#.#"));
                textBox.Text += String.Format("Used Percentage: {0}%\n", usedPercentage);
                textBox.Text += String.Format("Free: {0} MB\n", freeSpace.ToString());
                textBox.Text += String.Format("Free Percentage: {0}%\n", freePercentage);
                textBox.Text += "\n";
            }

        }
        /// <summary>
        /// Shows the processes in the text box. 
        /// </summary>
        /// <param name="sender">Process button</param>
        /// <param name="e">event args</param>
        private void processInfoButton_Click(object sender, EventArgs e)
        {
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process");
            
            this.textBox.Text = "";
            foreach (ManagementObject process in searcher.Get())
            {
                Double userModeTime = UInt64.Parse(process["UserModeTime"].ToString());
                userModeTime = userModeTime * 0.0001;
                Double kernelModeTime = UInt64.Parse(process["kernelModeTime"].ToString());
                kernelModeTime = kernelModeTime * 0.0001;
                this.textBox.Text += String.Format("Name: {0}\n", process["Name"].ToString());
                this.textBox.Text += String.Format("Description: {0}\n", process["Description"].ToString());
                this.textBox.Text += String.Format("Handle: {0}\n", process["Handle"].ToString());
                this.textBox.Text += String.Format("UserModeTime: {0}msec\n", userModeTime.ToString("#.#"));
                this.textBox.Text += String.Format("KernelModeTime: {0}msec\n", kernelModeTime.ToString("#"));
                this.textBox.Text += "\n";
            }
        }
       /// <summary>
       /// Fires when the appinfo form is closed and will update registry button. 
       /// </summary>
       /// <param name="sender">appInfoForm</param>
       /// <param name="e">Event args</param>
        private void InfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppInfoForm infoForm = (AppInfoForm)sender;
            if(infoForm.okPressed)
            {
                RegistryKey softwareKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                RegistryKey appKey = softwareKey.CreateSubKey("Technical Programming");
                appKey.SetValue("Year", infoForm.year);
                appKey.SetValue("Specialty", infoForm.specialty);
                appKey.SetValue("Owner", infoForm.owner);
                appKey.SetValue("Application", infoForm.application);
            }
        }
    }

}
