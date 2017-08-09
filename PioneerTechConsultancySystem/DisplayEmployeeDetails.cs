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
using PioneerTechSystem.Models;

namespace PioneerTechConsultancySystem
{
    public partial class DisplayEmployeeDetails : Form
    {
        private string EmployeeID;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            EmployeeID = SearchIDTextBox.Text.ToString();
            try
            {
                EmployeeDataAccessLayer EmployeeDataAccessLayerObj = new EmployeeDataAccessLayer();

                PersonalDetailsGridView.DataSource = EmployeeDataAccessLayerObj.ViewEmployeeData(EmployeeID);                
                PersonalDetailsGridView.Columns.RemoveAt(0);
                for (int i = 0; i < PersonalDetailsGridView.ColumnCount; i++)
                {
                    var cellValue = PersonalDetailsGridView.Rows[0].Cells[i].Value;
                    if (cellValue == null)
                    {
                        PersonalDetailsGridView.Columns.RemoveAt(i);
                        i = 0;
                    }
                }
                
                CompanyDetailsGridView.DataSource = EmployeeDataAccessLayerObj.ViewCompanyData(EmployeeID);

                CompanyDetailsGridView.Columns.RemoveAt(0);
                for (int i = 0; i < CompanyDetailsGridView.ColumnCount; i++)
                {
                    var cellValue = CompanyDetailsGridView.Rows[0].Cells[i].Value;
                    if (cellValue == null)
                    {
                        CompanyDetailsGridView.Columns.RemoveAt(i);
                        i = 0;
                    }
                }

                ProjectDetailsGridView.DataSource = EmployeeDataAccessLayerObj.ViewProjectData(EmployeeID);

                ProjectDetailsGridView.Columns.RemoveAt(0);
                ProjectDetailsGridView.Columns.RemoveAt(0);
                for (int i = 0; i < ProjectDetailsGridView.ColumnCount; i++)
                {
                    var cellValue = ProjectDetailsGridView.Rows[0].Cells[i].Value;
                    if (cellValue == null)
                    {
                        ProjectDetailsGridView.Columns.RemoveAt(i);
                        i = 0;
                    }
                }
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
