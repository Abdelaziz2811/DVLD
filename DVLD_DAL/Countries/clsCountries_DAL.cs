using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL.Countries
{
    public static class clsCountries_DAL
    {
        public static DataTable GetCountries()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = "SELECT * FROM Countries";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTCountries = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTCountries.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTCountries;
        }

        public static int GetCountryID(string Name)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT CountryID FROM Countries
                             WHERE CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", Name);

            int CountryID = -1;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                    CountryID = ID;

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return CountryID;
        }

        public static string GetCountryName(int CountryID)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT CountryName FROM Countries
                             WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryID);

            string CountryName = string.Empty;

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null)
                    CountryName = Result.ToString();

            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return CountryName;
        }

    }
}
