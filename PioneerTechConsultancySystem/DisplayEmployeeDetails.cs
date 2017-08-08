using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PioneerTechSystem.DAL;

namespace PioneerTechConsultancySystem
{
    public partial class DisplayEmployeeDetails : Form
    {
        private void SearchButton_Click(object sender, EventArgs e)
        {
            var height = 0;
            string EmployeeID = SearchIDTextBox.Text.ToString();
            try
            {
                EmployeeDataAccessLayer EmployeeDataAccessLayerObj = new EmployeeDataAccessLayer();
                PersonalDetailsGridView.DataSource = EmployeeDataAccessLayerObj.ViewConsultantData(EmployeeID, "DisplayPersonal");
                height = 25;
                foreach (DataGridViewRow dr in PersonalDetailsGridView.Rows)
                {
                    height += dr.Height;
                }
                PersonalDetailsGridView.Height = height;
                height = 0;

                CompanyDetailsGridView.DataSource = EmployeeDataAccessLayerObj.ViewConsultantData(EmployeeID, "DisplayCompany"); ;
                height = 25;
                foreach (DataGridViewRow dr in CompanyDetailsGridView.Rows)
                {
                    height += dr.Height;
                }
                CompanyDetailsGridView.Height = height;
                height = 0;
                
                ProjectDetailsGridView.DataSource = EmployeeDataAccessLayerObj.ViewConsultantData(EmployeeID, "DisplayProject");
                height = 25;
                foreach (DataGridViewRow dr in ProjectDetailsGridView.Rows)
                {
                    height += dr.Height;
                }
                ProjectDetailsGridView.Height = height;
                height = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayEmployeeDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeScreen home = new HomeScreen();
            home.Show();
        }
        public DisplayEmployeeDetails()
        {
            InitializeComponent();
        }
    }
}
