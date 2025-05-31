using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.License_Classes
{
    public static class clsLicenseClasses_DAL
    {
        public static DataTable GetLicenseClasses()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTLicenseClasses = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTLicenseClasses.Load(Reader);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTLicenseClasses;
        }

        public static int LicenseClassID(string ClassName)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT LicenseClassID FROM LicenseClasses
                             WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            int ClassID = 0;

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int ID))
                    ClassID = ID;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return ClassID;
        }
    }
}
