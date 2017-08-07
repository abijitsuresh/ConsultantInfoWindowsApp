namespace PioneerTechConsultancySystem
{
    partial class DisplayEmployeeDetails
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
            this.SearchIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PersonalDetailsGridView = new System.Windows.Forms.DataGridView();
            this.CompanyDetailsGridView = new System.Windows.Forms.DataGridView();
            this.ProjectDetailsGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Dash Board";
            // 
            // SearchIDTextBox
            // 
            this.SearchIDTextBox.Location = new System.Drawing.Point(578, 10);
            this.SearchIDTextBox.Name = "SearchIDTextBox";
            this.SearchIDTextBox.Size = new System.Drawing.Size(111, 22);
            this.SearchIDTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(709, 9);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PersonalDetailsGridView
            // 
            this.PersonalDetailsGridView.AllowUserToAddRows = false;
            this.PersonalDetailsGridView.AllowUserToDeleteRows = false;
            this.PersonalDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalDetailsGridView.Location = new System.Drawing.Point(1, 75);
            this.PersonalDetailsGridView.Name = "PersonalDetailsGridView";
            this.PersonalDetailsGridView.ReadOnly = true;
            this.PersonalDetailsGridView.RowTemplate.Height = 24;
            this.PersonalDetailsGridView.Size = new System.Drawing.Size(795, 62);
            this.PersonalDetailsGridView.TabIndex = 3;
            // 
            // CompanyDetailsGridView
            // 
            this.CompanyDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDetailsGridView.Location = new System.Drawing.Point(1, 206);
            this.CompanyDetailsGridView.Name = "CompanyDetailsGridView";
            this.CompanyDetailsGridView.RowTemplate.Height = 24;
            this.CompanyDetailsGridView.Size = new System.Drawing.Size(795, 89);
            this.CompanyDetailsGridView.TabIndex = 4;
            // 
            // ProjectDetailsGridView
            // 
            this.ProjectDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDetailsGridView.Location = new System.Drawing.Point(1, 353);
            this.ProjectDetailsGridView.Name = "ProjectDetailsGridView";
            this.ProjectDetailsGridView.RowTemplate.Height = 24;
            this.ProjectDetailsGridView.Size = new System.Drawing.Size(795, 92);
            this.ProjectDetailsGridView.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee Personal Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Employee Project Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee Company Details";
            // 
            // DisplayEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 665);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProjectDetailsGridView);
            this.Controls.Add(this.CompanyDetailsGridView);
            this.Controls.Add(this.PersonalDetailsGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchIDTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DisplayEmployeeDetails";
            this.Text = "DisplayEmployeeDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayEmployeeDetails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchIDTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView PersonalDetailsGridView;
        private System.Windows.Forms.DataGridView CompanyDetailsGridView;
        private System.Windows.Forms.DataGridView ProjectDetailsGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}