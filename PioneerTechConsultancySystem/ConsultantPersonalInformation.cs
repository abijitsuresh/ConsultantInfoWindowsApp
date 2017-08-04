using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultancyApp1
{
    public partial class ConsultantPersonalInformation : Form
    {
        public ConsultantPersonalInformation()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string firstname = FNameTextBox.Text;
            string lastname = LNameTextBox.Text;
            string email = EmailIdTextBox.Text;
            string phno = PhNumTextBox.Text;

            InsertConsultantDetailsController insertConsultantObj = new InsertConsultantDetailsController();

            string retValue = insertConsultantObj.InsertConsultantValues(firstname, lastname, email, phno);
            if(retValue.Equals("success"))
            {
                MessageBox.Show("Successfully inserted the values...");
            }
            else
                MessageBox.Show(retValue);
        }

        private void ConsultantPersonalInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
