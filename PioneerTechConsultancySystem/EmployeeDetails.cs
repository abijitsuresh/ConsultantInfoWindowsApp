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
    public partial class EmployeeDetails : Form
    {
        public Employee EmployeeObj;
        public Company CompanyObj;
        public Project ProjectObj;
        public Technical TechnicalObj;
        public Educational EducationalObj;        

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            EmployeeObj = new Employee();
            CompanyObj = new Company();
            ProjectObj = new Project();
            TechnicalObj = new Technical();
            EducationalObj = new Educational();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            EducationalObj.CourseType = CourseTypeTextBox.Text;
            EducationalObj.CourseSpecialization = CourseSpecializationTextBox.Text;
            EducationalObj.CourseYearofPassing = CourseYearTextBox.Text;
            try
            {
                
                EmployeeDataAccessLayer EmployeeDataAccessLayerObj = new EmployeeDataAccessLayer(); 
                string status = EmployeeDataAccessLayerObj.InsertConsultantDetails(EmployeeObj, ProjectObj, CompanyObj, TechnicalObj, EducationalObj);
                if(status.Equals("success"))
                {
                    if (MessageBox.Show("Successfully Inserted values!!", "OK", MessageBoxButtons.OK) == DialogResult.OK)
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
            EmployeeObj.FirstName = FNameTextBox.Text;            
            EmployeeObj.LastName = LNameTextBox.Text;
            EmployeeObj.EmailID = EmailIDTextBox.Text;
            EmployeeObj.MobileNumber = MobileNumberTextBox.Text;
            EmployeeObj.AlternateMobileNumber = AlternateMobNumTextBox.Text;
            EmployeeObj.AddressLine1 = AddressLine1TextBox.Text;
            EmployeeObj.AddressLine2 = AddressLine2TextBox.Text;
            EmployeeObj.AddressState = StateTextBox.Text;
            EmployeeObj.AddressCountry = CountryTextBox.Text;
            EmployeeObj.HomeCountry = HomeCountryTextBox.Text;
            EmployeeObj.AddressZipCode = ZipCodeTextBox.Text;
            selectTab(1);
        }

        private void CompanyBackButton_Click(object sender, EventArgs e)
        {
            selectTab(0);
        }

        private void CompanyDetailsResetButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CompanyObj.CompanyName);
            reset(CompanyDetailsTab.Controls);            
        }

        private void CompanyDetailsContinueButton_Click(object sender, EventArgs e)
        {
            CompanyObj.CompanyName = EmployerNameTextBox.Text;
            CompanyObj.CompanyContactNumber = CompanyContactNumberTextBox.Text;
            CompanyObj.CompanyLocation = CompanyLocationTextBox.Text;
            CompanyObj.CompanyWebsite = CompanyWebsiteTextBox.Text;
            selectTab(2);           
        }

        private void TechBackButton_Click(object sender, EventArgs e)
        {
            selectTab(1);            
        }

        private void TechContinueButton_Click(object sender, EventArgs e)
        {
            TechnicalObj.ProgrammingLanguages = PgmLangTextBox.Text;
            TechnicalObj.DatabasesKnown = DbTextBox.Text;
            TechnicalObj.ORMTechnologies = ORMTechTextBox.Text;
            TechnicalObj.UITechnologies = UITextBox.Text;
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
            ProjectObj.ProjectName = ProjectNameTextBox.Text;
            ProjectObj.ClientName = ClientNameTextBox.Text;
            ProjectObj.ProjectLocation = ProjectLocationTextBox.Text;
            ProjectObj.ProjectRoles = ProjectRolesTextBox.Text;
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
