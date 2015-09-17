namespace Comp4956_Lab1
{
    partial class mainWindow
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
            this.registerButton = new System.Windows.Forms.Button();
            this.titleColorButton = new System.Windows.Forms.Button();
            this.diskInfoButton = new System.Windows.Forms.Button();
            this.processInfoButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(17, 15);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(208, 28);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Register Application";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // titleColorButton
            // 
            this.titleColorButton.Location = new System.Drawing.Point(17, 50);
            this.titleColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.titleColorButton.Name = "titleColorButton";
            this.titleColorButton.Size = new System.Drawing.Size(208, 28);
            this.titleColorButton.TabIndex = 1;
            this.titleColorButton.Text = "Change Window Title Color";
            this.titleColorButton.UseVisualStyleBackColor = true;
            this.titleColorButton.Click += new System.EventHandler(this.titleColorButton_Click);
            // 
            // diskInfoButton
            // 
            this.diskInfoButton.Location = new System.Drawing.Point(16, 128);
            this.diskInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.diskInfoButton.Name = "diskInfoButton";
            this.diskInfoButton.Size = new System.Drawing.Size(209, 28);
            this.diskInfoButton.TabIndex = 2;
            this.diskInfoButton.Text = "Get Disk Info";
            this.diskInfoButton.UseVisualStyleBackColor = true;
            this.diskInfoButton.Click += new System.EventHandler(this.diskInfoButton_Click);
            // 
            // processInfoButton
            // 
            this.processInfoButton.Location = new System.Drawing.Point(17, 164);
            this.processInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.processInfoButton.Name = "processInfoButton";
            this.processInfoButton.Size = new System.Drawing.Size(208, 28);
            this.processInfoButton.TabIndex = 3;
            this.processInfoButton.Text = "Get Process Info";
            this.processInfoButton.UseVisualStyleBackColor = true;
            this.processInfoButton.Click += new System.EventHandler(this.processInfoButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(235, 15);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(415, 438);
            this.textBox.TabIndex = 4;
            this.textBox.Text = "";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 469);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.processInfoButton);
            this.Controls.Add(this.diskInfoButton);
            this.Controls.Add(this.titleColorButton);
            this.Controls.Add(this.registerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainWindow";
            this.Text = "Comp4956 Lab 1 Leon Ho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button titleColorButton;
        private System.Windows.Forms.Button diskInfoButton;
        private System.Windows.Forms.Button processInfoButton;
        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

