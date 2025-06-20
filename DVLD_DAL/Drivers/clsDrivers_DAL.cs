using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Drivers
{
    public static class clsDrivers_DAL
    {
        public static DataTable LoadTestAppointments(int DriverID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Drivers;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            DataTable DTDrivers = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTDrivers.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTDrivers;
        }

        //public static bool Find(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate
        //    , ref decimal PaidFees, ref int CreatedByUserID, ref bool IsLocked)
        //{
        //    SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

        //    string query = @"SELECT * FROM TestAppointments
        //                     WHERE TestAppointmentID = @TestAppointmentID";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

        //    bool IsFound = false;

        //    try
        //    {
        //        connection.Open();

        //        SqlDataReader Reader = command.ExecuteReader();

        //        if (Reader.Read())
        //        {
        //            IsFound = true;
        //            TestTypeID = (int)Reader["TestTypeID"];
        //            LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"];
        //            AppointmentDate = (DateTime)Reader["AppointmentDate"];
        //            PaidFees = (decimal)Reader["PaidFees"];
        //            CreatedByUserID = (int)Reader["CreatedByUserID"];
        //            IsLocked = (bool)Reader["IsLocked"];
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return IsFound;
        //}

        public static int Add(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO Drivers
                             VALUES(                                  
                                   @PersonID,
                                   @CreatedByUserID,
                                   @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            int DriverID = 0;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    DriverID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DriverID;
        }

        public static bool Update(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE Drivers
                             SET                                   
                                   PersonID = @PersonID,
                                   CreatedByUserID = @CreatedByUserID,
                                   CreatedDate = @CreatedDate
                             WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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

    }
}
