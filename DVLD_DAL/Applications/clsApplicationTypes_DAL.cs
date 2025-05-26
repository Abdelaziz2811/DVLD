using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DAL
{
    public static class clsApplicationTypes_DAL
    {
        public static DataTable GetApplicationTypes()
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable DTApplicationTypes = new DataTable();

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                    DTApplicationTypes.Load(Reader);
            }
            catch (Exception e)
            {

            }
            finally
            {
                connection.Close();
            }

            return DTApplicationTypes;
        }

        public static bool Find(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"SELECT * FROM ApplicationTypes 
                             WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            bool IsFound = false;

            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    ApplicationTypeTitle = Reader["ApplicationTypeTitle"].ToString();
                    ApplicationFees = (decimal)Reader["ApplicationFees"];
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

        public static bool Update(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {
            SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionString);

            string query = @"UPDATE ApplicationTypes
                             SET
                                   ApplicationTypeTitle = @ApplicationTypeTitle,
                                   ApplicationFees = @ApplicationFees
                             WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

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
