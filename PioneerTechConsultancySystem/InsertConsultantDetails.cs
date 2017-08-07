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
        public SqlConnection Con;
        public SqlCommand Cmd;
        public string InsertValues(string FName, string LName, string EmailID, string MobileNumber, string AlternateMobileNumber, string AddressLine1, string AddressLine2, string State, string Country, string ZipCode, string HomeCountry, string CompanyName, string CompanyContactNumber, string CompanyLocation, string CompanyWebsite, string PgmLanguages, string Databases, string ORMTechnologies, string UITechnologies, string ProjectName, string ClientName, string ProjectLocation, string ProjectRoles, string CourseType, string CourseSpecialization, string CourseYear)
        {
            try
            {
                Con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
                Con.Open();

                Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "uspInsertDetails";

                Cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FName;
                Cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LName;
                Cmd.Parameters.Add("@EmailID", SqlDbType.VarChar).Value = EmailID;
                Cmd.Parameters.Add("@MobileNumber", SqlDbType.VarChar).Value = MobileNumber;
                Cmd.Parameters.Add("@AlternateMobileNumber", SqlDbType.VarChar).Value = AlternateMobileNumber;
                Cmd.Parameters.Add("@AddressLine1", SqlDbType.VarChar).Value = AddressLine1;
                Cmd.Parameters.Add("@AddressLine2", SqlDbType.VarChar).Value = AddressLine2;
                Cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
                Cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = Country;
                Cmd.Parameters.Add("@ZipCode", SqlDbType.VarChar).Value = ZipCode;
                Cmd.Parameters.Add("@HomeCountry", SqlDbType.VarChar).Value = HomeCountry;
                Cmd.Parameters.Add("@ProjectName", SqlDbType.VarChar).Value = ProjectName;
                Cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = ClientName;
                Cmd.Parameters.Add("@ProjectLocation", SqlDbType.VarChar).Value = ProjectLocation;
                Cmd.Parameters.Add("@ProjectRoles", SqlDbType.VarChar).Value = ProjectRoles;
                Cmd.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = CompanyName;
                Cmd.Parameters.Add("@CompanyContactNumber", SqlDbType.VarChar).Value = CompanyContactNumber;
                Cmd.Parameters.Add("@CompanyLocation", SqlDbType.VarChar).Value = CompanyLocation;
                Cmd.Parameters.Add("@CompanyWebsite", SqlDbType.VarChar).Value = CompanyWebsite;
                Cmd.Parameters.Add("@ProgrammingLanguages", SqlDbType.VarChar).Value = PgmLanguages;
                Cmd.Parameters.Add("@Databases", SqlDbType.VarChar).Value = Databases;
                Cmd.Parameters.Add("@ORMTechnologies", SqlDbType.VarChar).Value = ORMTechnologies;
                Cmd.Parameters.Add("@UITechnologies", SqlDbType.VarChar).Value = UITechnologies;
                Cmd.Parameters.Add("@CourseType", SqlDbType.VarChar).Value = CourseType;
                Cmd.Parameters.Add("@CourseSpecialization", SqlDbType.VarChar).Value = CourseSpecialization;
                Cmd.Parameters.Add("@CourseYear", SqlDbType.VarChar).Value = CourseType;

                SqlParameter returnMessage = Cmd.CreateParameter();
                returnMessage.ParameterName = "Message";
                returnMessage.Direction = ParameterDirection.Output;
                returnMessage.DbType = DbType.String;
                returnMessage.Size = 100;
                Cmd.Parameters.Add(returnMessage);

                Cmd.ExecuteNonQuery();

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
                Con.Close();
            }
        }
    }
}
