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
    public class clsApplicationType_BLL
    {
        public int ApplicationTypeID { get; }
        public string ApplicationTypeTitle { get; set; }
        public short ApplicationFees { get; set; }

        public static DataTable GetApplicationTypes()
        {
            return clsApplicationType_DAL.GetApplicationTypes();
        }

        clsApplicationType_BLL(int ApplicationTypeID, string ApplicationTypeTitle, short ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static clsApplicationType_BLL Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = string.Empty;
            short ApplicationFees = 0;

            if (clsApplicationType_DAL.Find(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType_BLL(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else return null;
        }

        public static clsApplicationType_BLL Find(string ApplicationTypeTitle)
        {
            int ApplicationTypeID = 0;
            short ApplicationFees = 0;

            if (clsApplicationType_DAL.Find(ref ApplicationTypeID, ApplicationTypeTitle, ref ApplicationFees))
            {
                return new clsApplicationType_BLL(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            }
            else return null;
        }

        public bool Update()
        {
            return clsApplicationType_DAL.Update(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
        }
    }
}
