using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechConsultancySystem
{

    class InsertConsultantDetails
    {
        public SqlConnection sqlCon;
        public SqlCommand sqlCmd;
        public string InsertValues(string FName, string LName, string EmailID, 
            string MobileNumber, string AlternateMobileNumber, string AddressLine1, 
            string AddressLine2, string State, string Country, string ZipCode, 
            string HomeCountry, string CompanyName, string CompanyContactNumber, 
            string CompanyLocation, string CompanyWebsite, string PgmLanguages, 
            string Databases, string ORMTechnologies, string UITechnologies, 
            string ProjectName, string ClientName, string ProjectLocation, 
            string ProjectRoles, string CourseType, string CourseSpecialization, 
            string CourseYear)
        {
            try
            {
                sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                sqlCon.Open();

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "uspInsertDetails";

                sqlCmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FName;
                sqlCmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LName;
                sqlCmd.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = EmailID;
                sqlCmd.Parameters.Add("@MobileNumber", SqlDbType.VarChar).Value = MobileNumber;
                sqlCmd.Parameters.Add("@AlternateMobileNumber", SqlDbType.VarChar).Value = AlternateMobileNumber;
                sqlCmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = AddressLine1;
                sqlCmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = AddressLine2;
                sqlCmd.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
                sqlCmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
                sqlCmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = ZipCode;
                sqlCmd.Parameters.Add("@HomeCountry", SqlDbType.VarChar).Value = HomeCountry;
                sqlCmd.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = ProjectName;
                sqlCmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = ClientName;
                sqlCmd.Parameters.Add("@ProjectLocation", SqlDbType.VarChar).Value = ProjectLocation;
                sqlCmd.Parameters.Add("@ProjectRoles", SqlDbType.VarChar).Value = ProjectRoles;
                sqlCmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = CompanyName;
                sqlCmd.Parameters.Add("@CompanyContactNumber", SqlDbType.VarChar).Value = CompanyContactNumber;
                sqlCmd.Parameters.Add("@CompanyLocation", SqlDbType.VarChar).Value = CompanyLocation;
                sqlCmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar).Value = CompanyWebsite;
                sqlCmd.Parameters.Add("@ProgrammingLanguages", SqlDbType.VarChar).Value = PgmLanguages;
                sqlCmd.Parameters.Add("@Databases", SqlDbType.VarChar).Value = Databases;
                sqlCmd.Parameters.Add("@ORMTechnologies", SqlDbType.VarChar).Value = ORMTechnologies;
                sqlCmd.Parameters.Add("@UITechnologies", SqlDbType.VarChar).Value = UITechnologies;
                sqlCmd.Parameters.Add("@CourseType", SqlDbType.VarChar).Value = CourseType;
                sqlCmd.Parameters.Add("@CourseSpecialization", SqlDbType.VarChar).Value = CourseSpecialization;
                sqlCmd.Parameters.Add("@CourseYear", SqlDbType.VarChar).Value = CourseType;

                SqlParameter returnMessage = sqlCmd.CreateParameter();
                returnMessage.ParameterName = "Message";
                returnMessage.Direction = ParameterDirection.Output;
                returnMessage.DbType = DbType.String;
                returnMessage.Size = 100;
                sqlCmd.Parameters.Add(returnMessage);

                sqlCmd.ExecuteNonQuery();

                if(returnMessage.Value.Equals("success"))
                {
                    return "success";
                }

                return returnMessage.Value.ToString();
                
                //return "success";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
