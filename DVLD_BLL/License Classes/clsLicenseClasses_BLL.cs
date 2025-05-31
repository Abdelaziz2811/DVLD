using DVLD_DAL.License_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.License_Classes
{
    public static class clsLicenseClasses_BLL
    {
        public static DataTable GetLicenseClasses()
        {
            return clsLicenseClasses_DAL.GetLicenseClasses();
        }

        public static int LicenseClassID(string ClassName)
        {
            return clsLicenseClasses_DAL.LicenseClassID(ClassName);
        }
    }
}
