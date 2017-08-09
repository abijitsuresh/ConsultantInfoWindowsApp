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

namespace PioneerTechConsultancySystem
{
    public partial class EmployeeDetails : Form
    {
        private string FName, LName, EmailID, MobileNumber, AlternateMobileNumber, AddressLine1, AddressLine2, State, Country, HomeCountry, ZipCode;
        private string CompanyName, CompanyContactNumber, CompanyLocation, CompanyWebsite;
        private string ProjectName, ClientName, ProjectLocation, ProjectRoles;
        private string ProgrammingLanguages, Databases, ORMTechnologies, UITechnologies;
        private string CourseType, CourseSpecification, CourseYearOfPassing;

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            CourseType = CourseTypeTextBox.Text;
            CourseSpecification = CourseSpecializationTextBox.Text;
            CourseYearOfPassing = CourseYearTextBox.Text;
            try
            {
                EmployeeDataAccessLayer EmployeeDataAccessLayerObj = new EmployeeDataAccessLayer();  
                string status = EmployeeDataAccessLayerObj.InsertConsultantDetails(FName, LName, EmailID, MobileNumber, AlternateMobileNumber, AddressLine1, AddressLine2, State, Country, ZipCode, HomeCountry, CompanyName, CompanyContactNumber, CompanyLocation, CompanyWebsite, ProgrammingLanguages, Databases, ORMTechnologies, UITechnologies, ProjectName, ClientName, ProjectLocation, ProjectRoles, CourseType, CourseSpecification, CourseYearOfPassing);
                if(status.Equals("success"))
                {
                    if (MessageBox.Show("Successfully Inserted values!!", "OK", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        this.Hide();
                        HomeScreen HomeScreenObj = new HomeScreen();
                        HomeScreenObj.Show();
                    }
                }
                else
                    MessageBox.Show(status);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }  

        public EmployeeDetails()
        {
            InitializeComponent();
        }

        public void selectTab(int tabIndex)
        {
            EmplDetailsTabControl.SelectedIndex = tabIndex;
        }

        public void reset(Control.ControlCollection selectedTab)
        {
            foreach (var control in selectedTab)
            {
                if (control.GetType().Equals(typeof(TextBox)))
                {
                    TextBox TextBoxesInPage = control as TextBox;
                    TextBoxesInPage.Text = String.Empty;
                }
            }
        }

        private void EmployeeDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            HomeScreen HomeScreenObj = new HomeScreen();
            HomeScreenObj.Show();
        }

        private void PersonalResetButton_Click(object sender, EventArgs e)
        {
            reset(PersonalDetailsTab.Controls);         
        }

        private void PersonalContinueButton_Click(object sender, EventArgs e)
        {
            FName = FNameTextBox.Text;
            LName = LNameTextBox.Text;
            EmailID = EmailIDTextBox.Text;
            MobileNumber = MobileNumberTextBox.Text;
            AlternateMobileNumber = AlternateMobNumTextBox.Text;
            AddressLine1 = AddressLine1TextBox.Text;
            AddressLine2 = AddressLine2TextBox.Text;
            State = StateTextBox.Text;
            Country = CountryTextBox.Text;
            HomeCountry = HomeCountryTextBox.Text;
            ZipCode = ZipCodeTextBox.Text;
            selectTab(1);
        }

        private void CompanyBackButton_Click(object sender, EventArgs e)
        {
            selectTab(0);
        }

        private void CompanyDetailsResetButton_Click(object sender, EventArgs e)
        {
            reset(CompanyDetailsTab.Controls);            
        }

        private void CompanyDetailsContinueButton_Click(object sender, EventArgs e)
        {
            CompanyName = EmployerNameTextBox.Text;
            CompanyContactNumber = CompanyContactNumberTextBox.Text;
            CompanyLocation = CompanyLocationTextBox.Text;
            CompanyWebsite = CompanyWebsiteTextBox.Text;
            selectTab(2);           
        }

        private void TechBackButton_Click(object sender, EventArgs e)
        {
            selectTab(1);            
        }

        private void TechContinueButton_Click(object sender, EventArgs e)
        {
            ProgrammingLanguages = PgmLangTextBox.Text;
            Databases = DbTextBox.Text;
            ORMTechnologies = ORMTechTextBox.Text;
            UITechnologies = UITextBox.Text;
            selectTab(3);            
        }

        private void TechResetButton_Click(object sender, EventArgs e)
        {
            reset(TechnicalDetailsTab.Controls);
        }

        private void ProjectBackButton_Click(object sender, EventArgs e)
        {
            selectTab(2);
        }


        private void ProjectContinueButton_Click(object sender, EventArgs e)
        {
            ProjectName = ProjectNameTextBox.Text;
            ClientName = ClientNameTextBox.Text;
            ProjectLocation = ProjectLocationTextBox.Text;
            ProjectRoles = ProjectRolesTextBox.Text;
            selectTab(4);
        }

        private void ProjectResetButton_Click(object sender, EventArgs e)
        {
            reset(ProjectDetailsTab.Controls);
        }

        private void EducationBackButton_Click(object sender, EventArgs e)
        {
            selectTab(3);
        }

        private void EducationResetButton_Click(object sender, EventArgs e)
        {
            reset(EducationalDetailsTab.Controls);
        }
    }
}
