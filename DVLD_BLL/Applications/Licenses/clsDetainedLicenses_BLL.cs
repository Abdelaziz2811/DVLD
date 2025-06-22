using DVLD_DAL.Applications.Licenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Applications.Licenses
{
    public class clsDetainedLicenses_BLL
    {
        public static bool IsExists(int LicenseID)
        {
            return clsDetainedLicenses_DAL.IsExists(LicenseID);
        }
    }
}
