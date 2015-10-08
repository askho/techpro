namespace Lab3_CS
{
    partial class ThreadDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.threadCount = new System.Windows.Forms.NumericUpDown();
            this.secondCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of threads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of seconds";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(31, 182);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(176, 182);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // threadCount
            // 
            this.threadCount.Location = new System.Drawing.Point(150, 55);
            this.threadCount.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.threadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadCount.Name = "threadCount";
            this.threadCount.Size = new System.Drawing.Size(120, 22);
            this.threadCount.TabIndex = 4;
            this.threadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // secondCount
            // 
            this.secondCount.Location = new System.Drawing.Point(150, 99);
            this.secondCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.secondCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondCount.Name = "secondCount";
            this.secondCount.Size = new System.Drawing.Size(120, 22);
            this.secondCount.TabIndex = 5;
            this.secondCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ThreadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.secondCount);
            this.Controls.Add(this.threadCount);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThreadDialog";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.threadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown threadCount;
        private System.Windows.Forms.NumericUpDown secondCount;
    }
}