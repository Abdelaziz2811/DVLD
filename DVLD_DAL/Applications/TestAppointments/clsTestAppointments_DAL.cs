using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Applications.TestAppointments
{
    public static class clsTestAppointments_DAL
    {
        public static DataTable LoadTestAppointments(int TestType, int LocalDrivingLicenseID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments
                             WHERE TestTypeID = @TestType AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);

            DataTable DTTestAppointments = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTTestAppointments.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTTestAppointments;
        }
    }
}
