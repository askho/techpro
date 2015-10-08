namespace Lab3_CS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBox = new System.Windows.Forms.RichTextBox();
            this.thread1 = new System.Windows.Forms.RichTextBox();
            this.thread2 = new System.Windows.Forms.RichTextBox();
            this.thread3 = new System.Windows.Forms.RichTextBox();
            this.thread4 = new System.Windows.Forms.RichTextBox();
            this.thread5 = new System.Windows.Forms.RichTextBox();
            this.thread6 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timerBox
            // 
            this.timerBox.Location = new System.Drawing.Point(12, 31);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(117, 509);
            this.timerBox.TabIndex = 1;
            this.timerBox.Text = "";
            // 
            // thread1
            // 
            this.thread1.Location = new System.Drawing.Point(135, 31);
            this.thread1.Name = "thread1";
            this.thread1.Size = new System.Drawing.Size(117, 509);
            this.thread1.TabIndex = 2;
            this.thread1.Text = "";
            // 
            // thread2
            // 
            this.thread2.Location = new System.Drawing.Point(258, 31);
            this.thread2.Name = "thread2";
            this.thread2.Size = new System.Drawing.Size(117, 509);
            this.thread2.TabIndex = 3;
            this.thread2.Text = "";
            // 
            // thread3
            // 
            this.thread3.Location = new System.Drawing.Point(381, 31);
            this.thread3.Name = "thread3";
            this.thread3.Size = new System.Drawing.Size(117, 509);
            this.thread3.TabIndex = 4;
            this.thread3.Text = "";
            // 
            // thread4
            // 
            this.thread4.Location = new System.Drawing.Point(504, 31);
            this.thread4.Name = "thread4";
            this.thread4.Size = new System.Drawing.Size(117, 509);
            this.thread4.TabIndex = 5;
            this.thread4.Text = "";
            // 
            // thread5
            // 
            this.thread5.Location = new System.Drawing.Point(627, 31);
            this.thread5.Name = "thread5";
            this.thread5.Size = new System.Drawing.Size(117, 509);
            this.thread5.TabIndex = 6;
            this.thread5.Text = "";
            // 
            // thread6
            // 
            this.thread6.Location = new System.Drawing.Point(750, 31);
            this.thread6.Name = "thread6";
            this.thread6.Size = new System.Drawing.Size(117, 509);
            this.thread6.TabIndex = 7;
            this.thread6.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 552);
            this.Controls.Add(this.thread6);
            this.Controls.Add(this.thread5);
            this.Controls.Add(this.thread4);
            this.Controls.Add(this.thread3);
            this.Controls.Add(this.thread2);
            this.Controls.Add(this.thread1);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox timerBox;
        private System.Windows.Forms.RichTextBox thread1;
        private System.Windows.Forms.RichTextBox thread2;
        private System.Windows.Forms.RichTextBox thread3;
        private System.Windows.Forms.RichTextBox thread4;
        private System.Windows.Forms.RichTextBox thread5;
        private System.Windows.Forms.RichTextBox thread6;
    }
}