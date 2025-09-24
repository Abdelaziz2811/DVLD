using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Applications.Licenses
{
    public static class clsInternationalLicense_DAL
    {
        public static DataTable LoadInternationalLicenses(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID, IssueDate,
                                    ExpirationDate, IsActive FROM InternationalLicenses
                             INNER JOIN Drivers ON Drivers.DriverID = InternationalLicenses.DriverID
                             WHERE Drivers.PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            DataTable DTInternationalLicenses = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTInternationalLicenses.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTInternationalLicenses;
        }

        public static DataTable LoadInternationalLicenses()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses;";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTInternationalLicenses = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTInternationalLicenses.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTInternationalLicenses;
        }

        public static bool Find(ref int InternationalLicenseID, int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID
            , ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses
                             WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    InternationalLicenseID = (int)Reader["LicenseID"];
                    DriverID = (int)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
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

        public static bool Find(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID
            , ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses
                             WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    IsActive = (bool)Reader["IsActive"];
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

        public static int Add(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID
            , DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO InternationalLicenses
                             VALUES
                                   (@ApplicationID
                                   ,@DriverID
                                   ,@IssuedUsingLocalLicenseID
                                   ,@IssueDate
                                   ,@ExpirationDate
                                   ,@IsActive
                                   ,@CreatedByUserID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int InternationalLicenseID = 0;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    InternationalLicenseID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return InternationalLicenseID;
        }

        public static bool Update(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID
            , DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE Licenses
                             SET                                   
                                   (ApplicationID = @ApplicationID
                                   ,DriverID = @DriverID
                                   ,IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID
                                   ,IssueDate = @IssueDate
                                   ,ExpirationDate = @ExpirationDate
                                   ,IsActive = @IsActive
                                   ,CreatedByUserID = @CreatedByUserID)
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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

        public static bool Exists(int LocalLicenseID, int ClassID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT IsExists = 1 FROM InternationalLicenses
                             INNER JOIN Licenses ON Licenses.LicenseID = InternationalLicenses.IssuedUsingLocalLicenseID
                             WHERE IssuedUsingLocalLicenseID = @LocalLicenseID AND Licenses.LicenseClass = @ClassID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@ClassID", ClassID);

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
    }
}
