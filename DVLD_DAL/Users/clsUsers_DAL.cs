using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Users
{
    public static class clsUsers_DAL
    {
        public static DataTable GetUsersRecords()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT Users.UserID, Users.UserName, Users.IsActive, NationalNo, FirstName, SecondName, ThirdName,
                             LastName, BirthDate, Gender, Address, Phone, Email, NationalityCountryID, ImagePath  FROM People
                             INNER JOIN Users on People.PersonID = Users.PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTUsers = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTUsers.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTUsers;
        }

        public static bool Find(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Users
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    UserName = Reader["UserName"].ToString();
                    Password = Reader["Password"].ToString();
                    IsActive = (bool)Reader["IsActive"];
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

        public static bool Find(ref int UserID, ref int PersonID, string UserName, ref string Password, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM Users
                             WHERE UserName = @UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    Password = Reader["Password"].ToString();
                    IsActive = (bool)Reader["IsActive"];
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

        public static int Add(int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO Users
                             VALUES(
                                   @PersonID,
                                   @UserName,
                                   @Password,
                                   @IsActive)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            int UserID = -1;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    UserID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool Update(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE Users
                             SET
                                   PersonID = @PersonID,
                                   UserName = @UserName,
                                   Password = @Password,
                                   IsActive = @IsActive
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);

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

        public static bool Delete(int UserID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"DELETE FROM Users
                             WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

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
