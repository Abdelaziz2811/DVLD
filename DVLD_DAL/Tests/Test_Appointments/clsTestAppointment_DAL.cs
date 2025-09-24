using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Applications.TestAppointments
{
    public static class clsTestAppointment_DAL
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

        public static bool Find(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate
            , ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments
                             WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)Reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];
                    PaidFees = (decimal)Reader["PaidFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsLocked = (bool)Reader["IsLocked"];
                    RetakeTestApplicationID = (Reader["RetakeTestApplicationID"] == DBNull.Value) ? 0 : (int)Reader["RetakeTestApplicationID"];
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static DateTime TestAppointmentDate(int LocalDrivingLicenseApplicationID, byte TestType)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT AppointmentDate FROM TestAppointments
                             WHERE TestTypeID = @TestTypeID AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            DateTime AppointmentDate = DateTime.Now;

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null)
                    AppointmentDate = Convert.ToDateTime(obj);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return AppointmentDate;
        }

        public static int Add(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO TestAppointments
                             VALUES(                                   
                                   @TestTypeID,
                                   @LocalDrivingLicenseApplicationID,
                                   @AppointmentDate,
                                   @PaidFees,
                                   @CreatedByUserID,
                                   @IsLocked,
                                   @RetakeTestApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == 0)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            int TestAppointmentID = 0;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    TestAppointmentID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return TestAppointmentID;
        }

        public static bool Update(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE TestAppointments
                             SET                                   
                                   TestTypeID = @TestTypeID,
                                   LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                   AppointmentDate = @AppointmentDate,
                                   PaidFees = @PaidFees,
                                   CreatedByUserID = @CreatedByUserID,
                                   IsLocked = @IsLocked,
                                   RetakeTestApplicationID = @RetakeTestApplicationID
                             WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            if (RetakeTestApplicationID == 0)
                command.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

            int RowsAffected = 0;

            try
            {
                connection.Open();

                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowsAffected > 0;
        }
       
        public static bool IsExists(byte TestType, int LocalDrivingLicenseID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM TestAppointments
                             WHERE TestTypeID = @TestType AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID AND IsLocked = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);

            bool Exists = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    Exists = true;
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

        public static int TrialCount(byte TestType, int LocalDrivingLicenseID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT COUNT(*) FROM TestAppointments
                             WHERE TestTypeID = @TestType AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID AND IsLocked = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestType", TestType);
            command.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);

            int Trial = 0;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int T))
                    Trial = T;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Trial;
        }
    }
}
