using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DAL.Applications.New_Local_License_Application
{
    public static class clsLocalLicenseApplication_DAL
    {
        public static DataTable GetLocalLicenseApplications()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DT_LocalLicenseApplications = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DT_LocalLicenseApplications.Load(Reader);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return DT_LocalLicenseApplications;
        }

        public static bool Find(int LocalDrivingLicenseApplicationID, ref string ClassName, ref string NationalNo, ref string FullName,
            ref DateTime ApplicationDate, ref byte PassedTestCount, ref string Status)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;
                    ClassName = Reader["ClassName"].ToString();
                    NationalNo = Reader["NationalNo"].ToString();
                    FullName = Reader["FullName"].ToString();
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    PassedTestCount = (byte)Reader["PassedTestCount"];
                    Status = Reader["Status"].ToString();
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int Add(int ApplicationID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
                             VALUES (
                             @ApplicationID,
                             @LicenseClassID )                      
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            
            int LocalDrivingLicenseApplicationID = 0;

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int ID))
                    LocalDrivingLicenseApplicationID = ID;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool IsLocalLicenseApplicationExists(int ApplicantID, int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT Result = 1
                             WHERE EXISTS (
                             SELECT * FROM LocalDrivingLicenseApplications
                             iNNER JOIN Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                             WHERE ApplicantPersonID = @ApplicantID AND LicenseClassID = @LicenseClassID AND ApplicationStatus = 3 );";
            // we still didn't figure the condition that prevent addition of an active application.
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantID", ApplicantID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            bool IsFound = false;

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int Result))
                    if (Result == 1)
                        IsFound = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

    }
}
    
