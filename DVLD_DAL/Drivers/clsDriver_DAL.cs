using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Drivers
{
    public static class clsDriver_DAL
    {
        public static DataTable LoadDrivers()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT 
                                 Drivers.DriverID,
                                 Drivers.PersonID,
                                 People.NationalNo,
                                 (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName) AS FullName,
                                 Drivers.CreatedDate,
                                 COUNT(CASE WHEN Licenses.IsActive = 1 THEN 1 END) AS ActiveLicenses
                             FROM Drivers
                             INNER JOIN People ON People.PersonID = Drivers.PersonID
                             LEFT JOIN Licenses ON Licenses.DriverID = Drivers.DriverID
                             GROUP BY 
                                 Drivers.DriverID,
                                 Drivers.PersonID,
                                 People.NationalNo,
                                 People.FirstName,
                                 People.SecondName,
                                 People.ThirdName,
                                 People.LastName,
                                 Drivers.CreatedDate;";

            SqlCommand command = new SqlCommand(query, connection);

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

        public static bool Find(ref int DriverID, int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Drivers
                             WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    DriverID = (int)Reader["DriverID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
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

        public static bool Find(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Drivers
                             WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    CreatedDate = (DateTime)Reader["CreatedDate"];
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

        public static bool IsExists(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT DriverID FROM Drivers
                             WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            bool Exists = false;

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();
                if (obj != null) Exists = true;
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
