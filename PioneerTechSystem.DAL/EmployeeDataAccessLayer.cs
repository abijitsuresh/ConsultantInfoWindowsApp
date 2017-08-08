using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.DAL
{
    public class EmployeeDataAccessLayer
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter DataAdapter;
        private DataTable dataTable;      

        // Opening Connection
        private SqlConnection OpenConnection()
        {
            SqlConnection sqlConnection = new SqlConnection("server =.; Initial Catalog = PioneerTechConsultancySystem; Integrated Security = true");
            sqlConnection.Open();
            return sqlConnection;
        }

        // Close Connection
        private void CloseConnection(SqlConnection sqlConnection)
        {
            sqlConnection.Close();
        }

        //Checking Login
        public int loginCheck(string LoginID, string password)
        {
            int returnValue = 0;
            if (LoginID.Equals("admin") && password.Equals("abc@123"))
            {
                returnValue = 1;
            }
            else
                returnValue = 0;

            return returnValue;
        }

        // Insert Consultant Values
        public string InsertConsultantDetails(string FName, string LName, string EmailID, string MobileNumber, string AlternateMobileNumber, string AddressLine1, string AddressLine2, string State, string Country, string ZipCode, string HomeCountry, string CompanyName, string CompanyContactNumber, string CompanyLocation, string CompanyWebsite, string PgmLanguages, string Databases, string ORMTechnologies, string UITechnologies, string ProjectName, string ClientName, string ProjectLocation, string ProjectRoles, string CourseType, string CourseSpecialization, string CourseYear)
        {
            
            try
            {
                sqlConnection = OpenConnection();

                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspInsertDetails";

                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FName;
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LName;
                sqlCommand.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = EmailID;
                sqlCommand.Parameters.Add("@MobileNumber", SqlDbType.VarChar).Value = MobileNumber;
                sqlCommand.Parameters.Add("@AlternateMobileNumber", SqlDbType.VarChar).Value = AlternateMobileNumber;
                sqlCommand.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = AddressLine1;
                sqlCommand.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = AddressLine2;
                sqlCommand.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
                sqlCommand.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
                sqlCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = ZipCode;
                sqlCommand.Parameters.Add("@HomeCountry", SqlDbType.VarChar).Value = HomeCountry;
                sqlCommand.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = ProjectName;
                sqlCommand.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = ClientName;
                sqlCommand.Parameters.Add("@ProjectLocation", SqlDbType.VarChar).Value = ProjectLocation;
                sqlCommand.Parameters.Add("@ProjectRoles", SqlDbType.VarChar).Value = ProjectRoles;
                sqlCommand.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = CompanyName;
                sqlCommand.Parameters.Add("@CompanyContactNumber", SqlDbType.VarChar).Value = CompanyContactNumber;
                sqlCommand.Parameters.Add("@CompanyLocation", SqlDbType.VarChar).Value = CompanyLocation;
                sqlCommand.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar).Value = CompanyWebsite;
                sqlCommand.Parameters.Add("@ProgrammingLanguages", SqlDbType.VarChar).Value = PgmLanguages;
                sqlCommand.Parameters.Add("@Databases", SqlDbType.VarChar).Value = Databases;
                sqlCommand.Parameters.Add("@ORMTechnologies", SqlDbType.VarChar).Value = ORMTechnologies;
                sqlCommand.Parameters.Add("@UITechnologies", SqlDbType.VarChar).Value = UITechnologies;
                sqlCommand.Parameters.Add("@CourseType", SqlDbType.VarChar).Value = CourseType;
                sqlCommand.Parameters.Add("@CourseSpecialization", SqlDbType.VarChar).Value = CourseSpecialization;
                sqlCommand.Parameters.Add("@CourseYear", SqlDbType.VarChar).Value = CourseType;

                SqlParameter returnMessage = sqlCommand.CreateParameter();
                returnMessage.ParameterName = "Message";
                returnMessage.Direction = ParameterDirection.Output;
                returnMessage.DbType = DbType.String;
                returnMessage.Size = 100;
                sqlCommand.Parameters.Add(returnMessage);

                sqlCommand.ExecuteNonQuery();
                string returnValue = returnMessage.Value.ToString();
                sqlCommand.Dispose();
                return returnValue;

                //return "success";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                CloseConnection(sqlConnection);
            }
        }

        // To Display values        
        public DataTable ViewConsultantData(string EmployeeID, string Operation)
        {
            sqlConnection = OpenConnection();
            dataTable = new DataTable();
            string DisplayPersonalQuery = "SELECT FirstName, LastName, EmailID, MobileNumber, AddressState as State FROM EmployeePersonalDetails where EmployeeID = '" + EmployeeID + "'";
            string DisplayCompanyQuery = "SELECT CompanyName as [Company Name], CompanyContactNumber as [Company Contact Number], CompanyLocation as Location, CompanyWebsite as Website FROM EmployeeCompanyDetails where EmployeeID = '" + EmployeeID + "'";
            string DisplayProjectQuery = "SELECT ProjectName as [Project Name], ClientName as [Client Name], ProjectLocation as [Project Location], ProjectRoles as [Project Roles] FROM EmployeeProjectDetails where EmployeeID = '" + EmployeeID + "'";
            if (Operation.Equals("DisplayPersonal"))
            {                
                DataAdapter = new SqlDataAdapter(DisplayPersonalQuery, sqlConnection);
                DataAdapter.Fill(dataTable);
            }
            else if (Operation.Equals("DisplayCompany"))
            {
                dataTable.Clear();
                DataAdapter.Dispose();
                DataAdapter = new SqlDataAdapter(DisplayCompanyQuery, sqlConnection);
                DataAdapter.Fill(dataTable);
            }
            else
            {
                dataTable.Clear();
                DataAdapter.Dispose();
                DataAdapter = new SqlDataAdapter(DisplayProjectQuery, sqlConnection);
                DataAdapter.Fill(dataTable);
            }
            CloseConnection(sqlConnection);
            return dataTable;
        }
    }
}
