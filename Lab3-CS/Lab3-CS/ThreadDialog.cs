using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CS
{
    public partial class ThreadDialog : Form
    {
        public int threadsToExec
        {
            get
            {
                return int.Parse(threadCount.Value.ToString());
            }
        }
        public int secondsToRun
        {
            get
            {
                return int.Parse(secondCount.Value.ToString());
            }
        }
        public int closeReason {
            get; set;
        }

        public ThreadDialog()
        {
            InitializeComponent();
            closeReason = 1;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            closeReason = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
