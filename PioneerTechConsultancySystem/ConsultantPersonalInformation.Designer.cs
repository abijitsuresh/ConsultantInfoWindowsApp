namespace PioneerTechConsultancySystem
{
    partial class ConsultantPersonalInformation
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
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.FNameLbl = new System.Windows.Forms.Label();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhNumLbl = new System.Windows.Forms.Label();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailIdTextBox = new System.Windows.Forms.TextBox();
            this.PhNumTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Location = new System.Drawing.Point(304, 50);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(117, 17);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Employee Details";
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Location = new System.Drawing.Point(87, 115);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(76, 17);
            this.FNameLbl.TabIndex = 2;
            this.FNameLbl.Text = "First Name";
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Location = new System.Drawing.Point(87, 151);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(76, 17);
            this.LNameLbl.TabIndex = 3;
            this.LNameLbl.Text = "Last Name";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(87, 188);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(59, 17);
            this.EmailLbl.TabIndex = 4;
            this.EmailLbl.Text = "Email ID";
            // 
            // PhNumLbl
            // 
            this.PhNumLbl.AutoSize = true;
            this.PhNumLbl.Location = new System.Drawing.Point(87, 225);
            this.PhNumLbl.Name = "PhNumLbl";
            this.PhNumLbl.Size = new System.Drawing.Size(103, 17);
            this.PhNumLbl.TabIndex = 5;
            this.PhNumLbl.Text = "Phone Number";
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.Location = new System.Drawing.Point(307, 110);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.FNameTextBox.TabIndex = 1;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Location = new System.Drawing.Point(307, 151);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.LNameTextBox.TabIndex = 2;
            // 
            // EmailIdTextBox
            // 
            this.EmailIdTextBox.Location = new System.Drawing.Point(307, 188);
            this.EmailIdTextBox.Name = "EmailIdTextBox";
            this.EmailIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailIdTextBox.TabIndex = 3;
            // 
            // PhNumTextBox
            // 
            this.PhNumTextBox.Location = new System.Drawing.Point(307, 225);
            this.PhNumTextBox.Name = "PhNumTextBox";
            this.PhNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhNumTextBox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(307, 275);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(114, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit Details";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ConsultantPersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 524);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PhNumTextBox);
            this.Controls.Add(this.EmailIdTextBox);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.FNameTextBox);
            this.Controls.Add(this.PhNumLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.LNameLbl);
            this.Controls.Add(this.FNameLbl);
            this.Controls.Add(this.HeaderLbl);
            this.Name = "ConsultantPersonalInformation";
            this.Text = "ConsultantPersonalInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsultantPersonalInformation_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PhNumLbl;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.TextBox EmailIdTextBox;
        private System.Windows.Forms.TextBox PhNumTextBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}