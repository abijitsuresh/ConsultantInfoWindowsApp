using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PioneerTechSystem.DAL;
using PioneerTechSystem.Models;

namespace PioneerTechConsultancySystem
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //HomeScreen HomeScreenObj = new HomeScreen();
            //HomeScreenObj.Show(); 
            Login LoginObj = new Login();
            LoginObj.LoginID = LoginIdTextBox.Text;
            LoginObj.Password = PasswordTextBox.Text;

            string loginId = LoginIdTextBox.Text;
            string password = PasswordTextBox.Text;

            EmployeeDataAccessLayer EmployeeDataAccessLayerObj = new EmployeeDataAccessLayer();

            if (EmployeeDataAccessLayerObj.loginCheck(LoginObj) == 1)
            {
                MessageBox.Show("Login Success");
                this.Hide();
                HomeScreen HomeScreenObj = new HomeScreen();
                HomeScreenObj.Show();
            }
            else
                MessageBox.Show("Login Failed. Enter Correct details.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
