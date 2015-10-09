using System;
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
            this.Invoke(new updateUIDelegate(cleanUI), new ThreadEventArgs());
            Task.Run(() => startTimer(secondsToRun));
            for (int i = 1; i < threadsToExec + 1; i++)
            {
                int temp = i - 1;
                Task.Run(() => count(temp));
            }
        }

        private void startTimer(int length)
        {
            stop = false;
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

        private void cleanUI(ThreadEventArgs e)
        {
            foreach(RichTextBox box in threadBoxes)
            {
                box.Clear();
            }
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
    public ThreadEventArgs() { }
}