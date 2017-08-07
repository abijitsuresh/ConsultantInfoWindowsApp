namespace PioneerTechConsultancySystem
{
    partial class HomeScreen
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
            this.InsertHomeButton = new System.Windows.Forms.Button();
            this.DisplayHomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertHomeButton
            // 
            this.InsertHomeButton.Location = new System.Drawing.Point(188, 94);
            this.InsertHomeButton.Name = "InsertHomeButton";
            this.InsertHomeButton.Size = new System.Drawing.Size(201, 27);
            this.InsertHomeButton.TabIndex = 0;
            this.InsertHomeButton.Text = "Insert Employee Details";
            this.InsertHomeButton.UseVisualStyleBackColor = true;
            this.InsertHomeButton.Click += new System.EventHandler(this.InsertHomeButton_Click);
            // 
            // DisplayHomeButton
            // 
            this.DisplayHomeButton.Location = new System.Drawing.Point(188, 155);
            this.DisplayHomeButton.Name = "DisplayHomeButton";
            this.DisplayHomeButton.Size = new System.Drawing.Size(201, 27);
            this.DisplayHomeButton.TabIndex = 1;
            this.DisplayHomeButton.Text = "Display Employee Details";
            this.DisplayHomeButton.UseVisualStyleBackColor = true;
            this.DisplayHomeButton.Click += new System.EventHandler(this.DisplayHomeButton_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 423);
            this.Controls.Add(this.DisplayHomeButton);
            this.Controls.Add(this.InsertHomeButton);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeScreen_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InsertHomeButton;
        private System.Windows.Forms.Button DisplayHomeButton;
    }
}