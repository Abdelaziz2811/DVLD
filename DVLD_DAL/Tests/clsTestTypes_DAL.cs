using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Tests
{
    public static class clsTestTypes_DAL
    {
        public static DataTable GetTestTypes()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = "SELECT * FROM TestTypes";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTTestTypes = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTTestTypes.Load(Reader);
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                connection.Close();
            }

            return DTTestTypes;
        }

        public static bool Find(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDesription, ref short TestTypeFees)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM TestTypes
                             WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            bool isFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;
                    TestTypeTitle = Reader["TestTypeTitle"].ToString();
                    TestTypeDesription = Reader["TestTypeDescription"].ToString();
                    TestTypeFees = Convert.ToInt16(Reader["TestTypeFees"]);
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool Update(int TestTypeID, string TestTypeTitle, string TestTypeDescription, short TestTypeFees)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE TestTypes
                             SET
                                    TestTypeTitle = @TestTypeTitle,
                                    TestTypeDescription = @TestTypeDescription,
                                    TestTypeFees = @TestTypeFees
                             WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

            int RowAffected = 0;

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return RowAffected > 0;
        }
    }
}
