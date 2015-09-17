namespace Comp4956_Lab1
{
    partial class AppInfoForm
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
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.applicationLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.specialtyText = new System.Windows.Forms.TextBox();
            this.applicationText = new System.Windows.Forms.TextBox();
            this.ownerText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearText)).BeginInit();
            this.SuspendLayout();
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.AutoSize = true;
            this.specialtyLabel.Location = new System.Drawing.Point(13, 24);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(65, 17);
            this.specialtyLabel.TabIndex = 0;
            this.specialtyLabel.Text = "Specialty";
            // 
            // applicationLabel
            // 
            this.applicationLabel.AutoSize = true;
            this.applicationLabel.Location = new System.Drawing.Point(12, 52);
            this.applicationLabel.Name = "applicationLabel";
            this.applicationLabel.Size = new System.Drawing.Size(77, 17);
            this.applicationLabel.TabIndex = 1;
            this.applicationLabel.Text = "Application";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(13, 80);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(49, 17);
            this.ownerLabel.TabIndex = 2;
            this.ownerLabel.Text = "Owner";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(13, 109);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // specialtyText
            // 
            this.specialtyText.Location = new System.Drawing.Point(97, 24);
            this.specialtyText.Name = "specialtyText";
            this.specialtyText.Size = new System.Drawing.Size(303, 22);
            this.specialtyText.TabIndex = 4;
            this.specialtyText.TextChanged += new System.EventHandler(this.specialtyText_TextChanged);
            // 
            // applicationText
            // 
            this.applicationText.Location = new System.Drawing.Point(97, 52);
            this.applicationText.Name = "applicationText";
            this.applicationText.Size = new System.Drawing.Size(303, 22);
            this.applicationText.TabIndex = 5;
            this.applicationText.TextChanged += new System.EventHandler(this.applicationText_TextChanged);
            // 
            // ownerText
            // 
            this.ownerText.Location = new System.Drawing.Point(97, 80);
            this.ownerText.Name = "ownerText";
            this.ownerText.Size = new System.Drawing.Size(303, 22);
            this.ownerText.TabIndex = 6;
            this.ownerText.TextChanged += new System.EventHandler(this.ownerText_TextChanged);
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(97, 109);
            this.yearText.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.yearText.Minimum = new decimal(new int[] {
            1955,
            0,
            0,
            0});
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(120, 22);
            this.yearText.TabIndex = 7;
            this.yearText.Tag = "";
            this.yearText.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.yearText.ValueChanged += new System.EventHandler(this.yearText_ValueChanged);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(12, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(167, 43);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(233, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 43);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AppInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 246);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.ownerText);
            this.Controls.Add(this.applicationText);
            this.Controls.Add(this.specialtyText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.applicationLabel);
            this.Controls.Add(this.specialtyLabel);
            this.Name = "AppInfoForm";
            this.Text = "Register New Application";
            ((System.ComponentModel.ISupportInitialize)(this.yearText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox specialtyText;
        private System.Windows.Forms.TextBox applicationText;
        private System.Windows.Forms.TextBox ownerText;
        private System.Windows.Forms.NumericUpDown yearText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}