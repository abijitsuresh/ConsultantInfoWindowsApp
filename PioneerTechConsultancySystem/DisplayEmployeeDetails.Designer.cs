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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PersonalDetailsGridView = new System.Windows.Forms.DataGridView();
            this.CompanyDetailsGridView = new System.Windows.Forms.DataGridView();
            this.ProjectDetailsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Project Details";
            // 
            // SearchIDTextBox
            // 
            this.SearchIDTextBox.Location = new System.Drawing.Point(510, 4);
            this.SearchIDTextBox.Name = "SearchIDTextBox";
            this.SearchIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.SearchIDTextBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(628, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PersonalDetailsGridView
            // 
            this.PersonalDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalDetailsGridView.Location = new System.Drawing.Point(2, 68);
            this.PersonalDetailsGridView.Name = "PersonalDetailsGridView";
            this.PersonalDetailsGridView.RowTemplate.Height = 24;
            this.PersonalDetailsGridView.Size = new System.Drawing.Size(747, 150);
            this.PersonalDetailsGridView.TabIndex = 6;
            // 
            // CompanyDetailsGridView
            // 
            this.CompanyDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDetailsGridView.Location = new System.Drawing.Point(2, 252);
            this.CompanyDetailsGridView.Name = "CompanyDetailsGridView";
            this.CompanyDetailsGridView.RowTemplate.Height = 24;
            this.CompanyDetailsGridView.Size = new System.Drawing.Size(747, 111);
            this.CompanyDetailsGridView.TabIndex = 7;
            // 
            // ProjectDetailsGridView
            // 
            this.ProjectDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectDetailsGridView.Location = new System.Drawing.Point(2, 399);
            this.ProjectDetailsGridView.Name = "ProjectDetailsGridView";
            this.ProjectDetailsGridView.RowTemplate.Height = 24;
            this.ProjectDetailsGridView.Size = new System.Drawing.Size(747, 122);
            this.ProjectDetailsGridView.TabIndex = 8;
            // 
            // DisplayEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 614);
            this.Controls.Add(this.ProjectDetailsGridView);
            this.Controls.Add(this.CompanyDetailsGridView);
            this.Controls.Add(this.PersonalDetailsGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayEmployeeDetails";
            this.Text = "Pioneer Tech Consultancy System - Employee Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayEmployeeDetails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchIDTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView PersonalDetailsGridView;
        private System.Windows.Forms.DataGridView CompanyDetailsGridView;
        private System.Windows.Forms.DataGridView ProjectDetailsGridView;
    }
}