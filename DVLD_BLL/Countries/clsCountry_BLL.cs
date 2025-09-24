using DVLD_DAL.Countries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Countries
{
    public class clsCountry_BLL
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        clsCountry_BLL(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static DataTable GetCountries()
        {
            return clsCountry_DAL.GetCountries();
        }

        public static clsCountry_BLL Find(int CountryID)
        {
            string CountryName = string.Empty;

            if (clsCountry_DAL.Find(CountryID, ref CountryName))
                return new clsCountry_BLL(CountryID, CountryName);
            return null;
        }

        public static int GetCountryID(string Name)
        {
            return clsCountry_DAL.GetCountryID(Name);
        }
    }
}
