using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_DAL
{
    public static class clsPersons_DAL
    {
        public static DataTable GetPeopleRecords()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = "SELECT * FROM People";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTPersons = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTPersons.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTPersons;
        }

        public static bool Find(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime BirthDate,
                ref char Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM People
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
                    NationalNo = Reader["NationalNo"].ToString();
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    BirthDate = (DateTime)Reader["BirthDate"];
                    Gender = Convert.ToChar(Reader["Gender"]);
                    Address = Reader["Address"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = Reader["ImagePath"].ToString();
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
        
        public static bool Find(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime BirthDate,
                ref char Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM People
                             WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    FirstName = Reader["FirstName"].ToString();
                    SecondName = Reader["SecondName"].ToString();
                    ThirdName = Reader["ThirdName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    BirthDate = (DateTime)Reader["BirthDate"];
                    Gender = Convert.ToChar(Reader["Gender"]); 
                    Address = Reader["Address"].ToString();
                    Phone = Reader["Phone"].ToString();
                    Email = Reader["Email"].ToString();
                    NationalityCountryID = (int)Reader["NationalityCountryID"];
                    ImagePath = Reader["ImagePath"].ToString();
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

        public static int Add(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime BirthDate,
                char Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"INSERT INTO People
                             VALUES(
                                   @NationalNo,
                                   @FirstName,
                                   @SecondName,
                                   @ThirdName,
                                   @LastName,
                                   @BirthDate,
                                   @Gender,
                                   @Address,
                                   @Phone,
                                   @Email,
                                   @NationalityCountryID,
                                   @ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            int PersonID = -1;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    PersonID = ID;
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return PersonID;
        }

        public static bool Update(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime BirthDate,
                char Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE People
                             SET
                                   NationalNo = @NationalNo,
                                   FirstName = @FirstName,
                                   SecondName = @SecondName,
                                   ThirdName = @ThirdName,
                                   LastName = @LastName,
                                   BirthDate = @BirthDate,
                                   Gender = @Gender,
                                   Address = @Address,
                                   Phone = @Phone,
                                   Email = @Email,
                                   NationalityCountryID = @NationalityCountryID,
                                   ImagePath = @ImagePath
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

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

        public static bool Delete(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"DELETE FROM People
                             WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static bool IsNationalNoExists(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT NationalNo FROM People
                             WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            bool IsFound = false;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    IsFound = true;

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
    }
}
