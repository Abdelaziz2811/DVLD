using DVLD_DAL.Countries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Countries
{
    public class clsCountries_BLL
    {
        public static DataTable GetCountries()
        {
            return clsCountries_DAL.GetCountries();
        }

        public static int GetCountryID(string Name)
        {
            return clsCountries_DAL.GetCountryID(Name);
        }

        public static string GetCountryName(int CountryID)
        {
            return clsCountries_DAL.GetCountryName(CountryID);
        }
    }
}
