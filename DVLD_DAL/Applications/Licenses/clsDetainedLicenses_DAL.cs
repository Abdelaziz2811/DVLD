using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DAL.Applications.Licenses
{
    public static class clsDetainedLicenses_DAL
    {
        public static bool IsExists(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT DetainID FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID ", LicenseID);

            bool Exists = false;

            try
            {
                connection.Open();

                object Obj = command.ExecuteScalar();
                if (Obj != null) Exists = true;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Exists;

        }
    }
}
