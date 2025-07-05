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
        public static bool Find(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased,
                                             ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    DetainID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = (decimal)Reader["FineFees"];
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = (bool)Reader["IsReleased"];

                    ReleaseDate = (Reader["ReleaseDate"] != DBNull.Value)? (DateTime)Reader["ReleaseDate"] : DateTime.MinValue;
                    ReleasedByUserID = (Reader["ReleasedByUserID"] != DBNull.Value) ? (int)Reader["ReleasedByUserID"] : 0;
                    ReleaseApplicationID = (Reader["ReleaseApplicationID"] != DBNull.Value) ? (int)Reader["ReleaseApplicationID"] : 0;
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

        public static int Add(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO DetainedLicenses
                             VALUES
                                   (@LicenseID
                                   ,@DetainDate
                                   ,@FineFees
                                   ,@CreatedByUserID
                                   ,@IsReleased
                                   ,@ReleaseDate
                                   ,@ReleasedByUserID
                                   ,@ReleaseApplicationID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate == DateTime.MinValue)
            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            if (ReleasedByUserID == 0)
            command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            if (ReleaseApplicationID == 0)
            command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            int DetainID = 0;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    DetainID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DetainID;
        }

        public static bool Update(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
                                  bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE DetainedLicenses
                             SET                                   
                                    LicenseID = @LicenseID,
                                    DetainDate = @DetainDate,
                                    FineFees = @FineFees,
                                    CreatedByUserID = @CreatedByUserID,
                                    IsReleased = @IsReleased,
                                    ReleaseDate = @ReleaseDate,
                                    ReleasedByUserID = @ReleasedByUserID,
                                    ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);

            if (ReleaseDate == DateTime.MinValue)
                command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

            if (ReleasedByUserID == 0)
                command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            if (ReleaseApplicationID == 0)
                command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static bool IsDetained(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT DetainID FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID AND IsReleased = 0";

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
