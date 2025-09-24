using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Applications.Tests
{
    public static class clsTest_DAL
    {
        public static DataTable LoadTests()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Tests";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static bool Find(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Tests
                                 WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)Reader["TestAppointmentID"];
                    TestResult = (bool)Reader["TestResult"];
                    Notes = Reader["Notes"] != DBNull.Value ? Reader["Notes"].ToString() : null;
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
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

        public static int Add(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO Tests
                             VALUES(                                   
                                   @TestAppointmentID,
                                   @TestResult,
                                   @Notes,
                                   @CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);

            if (Notes == string.Empty)
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Notes", Notes);

            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int TestID = 0;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    TestID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return TestID;
        }

        public static bool Update(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE Tests
                             SET                                   
                                   TestAppointmentID = @TestAppointmentID,
                                   TestResult = @TestResult,
                                   Notes = @Notes,
                                   CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool IsPass(int TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT TOP 1 Tests.TestResult FROM TestAppointments
                                INNER JOIN Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                WHERE TestTypeID = @TestTypeID AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                                ORDER BY TestResult DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            
            bool Pass = false;

            try
            {
                connection.Open();

                object TestResult = command.ExecuteScalar();

                if (TestResult != null)
                    Pass = Convert.ToBoolean(TestResult);
                    
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return Pass;
        }
    }
}
