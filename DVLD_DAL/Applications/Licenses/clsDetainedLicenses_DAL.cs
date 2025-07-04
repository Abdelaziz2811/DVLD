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

            string query = @"UPDATE Licenses
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
