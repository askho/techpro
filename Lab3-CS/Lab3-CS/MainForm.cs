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
    public partial class MainForm : Form
    {
        private int threadsToExec, secondsToRun;
        private bool stop = false;
        private RichTextBox[] threadBoxes;
        private delegate void updateUIDelegate(ThreadEventArgs e);
        public MainForm()
        {
            InitializeComponent();
            threadBoxes = new RichTextBox[6] {thread1,
                thread2,
                thread3,
                thread4,
                thread5,
                thread6 };

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new ThreadDialog();


            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                threadsToExec = dialog.threadsToExec;
                secondsToRun = dialog.secondsToRun;
                startThreads();
            }
        }

        private void startThreads()
        {
            Task[] tasks = new Task[6];
            tasks[0] = Task.Factory.StartNew(() => startTimer(secondsToRun));
            for (int i = 1; i < threadsToExec + 1; i++)
            {
                int temp = i - 1;
                //tasks[i] = Task.Factory.StartNew(() => count(temp));
                Task.Run(() => count(temp));
            }
        }

        private void startTimer(int length)
        {
            this.Invoke(new updateUIDelegate(updateTimer), new ThreadEventArgs("Timer Started"));
            System.Threading.Thread.Sleep(length * 1000);
            stop = true;
            this.Invoke(new updateUIDelegate(updateTimer), new ThreadEventArgs("Timer Stoped"));

        }
        private void count(int threadNo)
        {
            Console.WriteLine(threadNo);
            int count = 0;
            while(!stop)
            {
                ThreadEventArgs e = new ThreadEventArgs(threadNo, (count++).ToString());             
                this.Invoke(new updateUIDelegate(updateUI), e);
            }
        }
        private void updateUI(ThreadEventArgs e) {
            threadBoxes[e.threadNo].AppendText(e.text + "\n");
            threadBoxes[e.threadNo].ScrollToCaret();
        }
        private void updateTimer(ThreadEventArgs e)
        {
            timerBox.AppendText(e.text + "\n");
        }

    }
}

public class ThreadEventArgs : EventArgs
{
    public int threadNo;
    public string text;
    public ThreadEventArgs (int threadNo, string text)
    {
        this.threadNo = threadNo;
        this.text = text;
    }
    public ThreadEventArgs(string text)
    {
        this.text = text;
    }
}