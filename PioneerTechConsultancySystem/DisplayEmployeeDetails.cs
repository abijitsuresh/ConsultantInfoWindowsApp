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

namespace PioneerTechConsultancySystem
{
    public partial class DisplayEmployeeDetails : Form
    {
        private SqlConnection sqlCon;
        //private SqlCommand sqlCmd;
        private string ConnectionString;
        private SqlDataAdapter PersonalDetails, CompanyDetails, ProjectDetails;
        private DataTable PersonalDataTable, CompanyDataTable, ProjectDataTable;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var height = 0;
            ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            string EmployeeID = SearchIDTextBox.Text.ToString();
            try
            {
                sqlCon = new SqlConnection(ConnectionString);
                sqlCon.Open();

                PersonalDataTable = new DataTable();
                PersonalDetails = new SqlDataAdapter("SELECT FirstName, LastName, EmailID, MobileNumber, AddressState as State FROM EmployeePersonalDetails where EmployeeID = '" + EmployeeID + "'", sqlCon);
                PersonalDetails.Fill(PersonalDataTable);
                PersonalDetailsGridView.DataSource = PersonalDataTable;
                height = 25;
                foreach (DataGridViewRow dr in PersonalDetailsGridView.Rows)
                {
                    height += dr.Height;
                }
                PersonalDetailsGridView.Height = height;
                height = 0;

                CompanyDataTable = new DataTable();
                CompanyDetails = new SqlDataAdapter("SELECT CompanyName as [Company Name], CompanyContactNumber as [Company Contact Number], CompanyLocation as Location, CompanyWebsite as Website FROM EmployeeCompanyDetails where EmployeeID = '" + EmployeeID + "'", sqlCon);
                CompanyDetails.Fill(CompanyDataTable);
                CompanyDetailsGridView.DataSource = CompanyDataTable;
                height = 25;
                foreach (DataGridViewRow dr in CompanyDetailsGridView.Rows)
                {
                    height += dr.Height;
                }
                CompanyDetailsGridView.Height = height;
                height = 0;

                ProjectDataTable = new DataTable();
                ProjectDetails = new SqlDataAdapter("SELECT ProjectName as [Project Name], ClientName as [Client Name], ProjectLocation as [Project Location], ProjectRoles as [Project Roles] FROM EmployeeProjectDetails where EmployeeID = '" + EmployeeID + "'", sqlCon);
                ProjectDetails.Fill(ProjectDataTable);
                ProjectDetailsGridView.DataSource = ProjectDataTable;
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
            finally
            {
                sqlCon.Close();
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
