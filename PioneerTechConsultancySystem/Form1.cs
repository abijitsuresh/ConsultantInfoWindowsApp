using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PioneerTechConsultancySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string loginId = LoginIdTextBox.Text;
            string password = PasswordTextBox.Text;

            if (loginId.Equals("admin") && password.Equals("abc@123"))
            {
                MessageBox.Show("Login Success");
                this.Hide();
                EmployeeDetails EmployeeDetailsObj = new EmployeeDetails();
                EmployeeDetailsObj.Show();
            }
            else
                MessageBox.Show("Login Failed. Enter Correct details.");
        }
    }
}
