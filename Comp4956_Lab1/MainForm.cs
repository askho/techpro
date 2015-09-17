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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            /*
            User the info form to get data from the user, when its closed update the registry.
            */
            AppInfoForm infoForm = new AppInfoForm();
            infoForm.Show();
            infoForm.FormClosing += InfoForm_FormClosing;
        }

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

        private void diskInfoButton_Click(object sender, EventArgs e)
        {
            
            this.textBox.Text = "Local Disks:\n";
            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
            foreach(ManagementObject drive in searcher.Get())
            {
                double driveSize = double.Parse(drive["Size"].ToString());
                double freeSpace = double.Parse(drive["FreeSpace"].ToString());
                driveSize = Math.Round(driveSize * Math.Pow(2, -20)); // Convert to MB
                freeSpace = Math.Round(freeSpace * Math.Pow(2, -20));
                double usedSpace = driveSize - freeSpace;

                //Console.WriteLine(drive["ConfigManagerErrorCode"]);
                textBox.Text += String.Format("Name: {0}\n", drive["Name"].ToString());
                textBox.Text += String.Format("Description: {0}\n", drive["Description"].ToString());
                //textBox.Text += String.Format("Error Code: {0}\n", drive["ConfigManagerErrorCode"].ToString());
                textBox.Text += String.Format("Device ID: {0}\n", drive["DeviceID"].ToString());
                textBox.Text += String.Format("FileSystem: {0}\n", drive["FileSystem"].ToString());
                textBox.Text += String.Format("Size: {0} MB\n", driveSize.ToString("#.#"));
                textBox.Text += String.Format("Used: {0} MB\n", usedSpace.ToString("#.#"));
                textBox.Text += String.Format("Used Percentage: {0}%\n", Math.Round(((usedSpace / driveSize) * 100)).ToString());
                textBox.Text += String.Format("Free: {0} MB\n", freeSpace.ToString());
                textBox.Text += String.Format("Free Percentage: {0}%\n", Math.Round(((freeSpace / driveSize) * 100)).ToString());
                textBox.Text += "\n";
            }

        }

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
