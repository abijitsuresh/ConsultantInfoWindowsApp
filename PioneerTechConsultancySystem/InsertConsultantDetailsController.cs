using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyApp1
{
    class InsertConsultantDetailsController
    {
        public string ConnectionString = "Data Source=ABIJIT;Initial Catalog=pioneertech;Trusted_Connection=true;";
        public SqlConnection sqlConn;
        public SqlCommand sqlCmd;
         
        public string InsertConsultantValues(string fname, string lname, string emailid, string phno)
        {
            try
            {

                sqlConn = new SqlConnection(ConnectionString);
                sqlConn.Open();

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "InsertConsultantPersonalDetails";

                sqlCmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = fname;
                sqlCmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lname;
                sqlCmd.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = emailid;
                sqlCmd.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = phno;

                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                sqlConn.Close();
            }

            return "success";
        }
    }
}
