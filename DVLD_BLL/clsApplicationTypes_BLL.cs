using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public class clsApplicationTypes_BLL
    {
        public int ApplicationTypeID { get; }
        public string ApplicationTypeTitle { get; set; }
        public float ApplicationFees { get; set; }

        public static DataTable GetApplicationTypes()
        {
            return clsApplicationTypes_DAL.GetApplicationTypes();
        }

        clsApplicationTypes_BLL(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicationTypes_BLL Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = string.Empty;
            float ApplicationFees = 0;

            if (clsApplicationTypes_DAL.Find(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationTypes_BLL(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else return null;
        }

        public bool Update()
        {
            return clsApplicationTypes_DAL.Update(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
        }
    }
}
