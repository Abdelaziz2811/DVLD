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
    public class clsLicenseClasses_BLL
    {
        public byte LicenseClassID {  get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public decimal ClassFees { get; set; }

        private clsLicenseClasses_BLL(byte LicenseClassID, string ClassName, string ClassDescription,
                                      byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public static DataTable GetLicenseClasses()
        {
            return clsLicenseClasses_DAL.GetLicenseClasses();
        }

        public static clsLicenseClasses_BLL Find(string ClassName)
        {
            byte LicenseClassID = 0;
            string ClassDescription = string.Empty;
            byte MinimumAllowedAge = 0;
            byte DefaultValidityLength = 0;
            decimal ClassFees = 0;

            if (clsLicenseClasses_DAL.Find(ref LicenseClassID, ClassName, ref ClassDescription, ref MinimumAllowedAge,
                                           ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses_BLL(LicenseClassID, ClassName, ClassDescription,MinimumAllowedAge,
                                                 DefaultValidityLength, ClassFees);
            }
            return null;
        }

        public static int GetLicenseClassID(string ClassName)
        {
            return clsLicenseClasses_DAL.LicenseClassID(ClassName);
        }
    }
}
