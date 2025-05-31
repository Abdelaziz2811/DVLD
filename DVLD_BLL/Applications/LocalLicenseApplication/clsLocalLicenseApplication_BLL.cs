using DVLD_DAL.Applications.New_Local_License_Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Applications.LocalLicenseApplication
{
    public class clsLocalLicenseApplication_BLL
    {
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public string ClassName { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public byte PassedTestCount { get; set; }
        public string Status { get; set; }

        public clsLocalLicenseApplication_BLL()
        {
            LocalDrivingLicenseApplicationID = 0;
            ApplicationID = 0;
            LicenseClassID = 0;
        }

        clsLocalLicenseApplication_BLL(int LocalDrivingLicenseApplicationID, string ClassName, string NationalNo, string FullName,
            DateTime ApplicationDate, byte PassedTestCount, string Status)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ClassName = ClassName;
            this.NationalNo = NationalNo;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.PassedTestCount = PassedTestCount;
            this.Status = Status;
        }

        public static DataTable GetLocalLicenseApplications()
        {
            return clsLocalLicenseApplication_DAL.GetLocalLicenseApplications();
        }

        public static clsLocalLicenseApplication_BLL Find(int LocalDrivingLicenseApplicationID)
        {
            string ClassName = string.Empty;
            string NationalNo = string.Empty;
            string FullName = string.Empty;
            DateTime ApplicationDate = DateTime.Now;
            byte PassedTestCount = 0;
            string Status = string.Empty;

            if (clsLocalLicenseApplication_DAL.Find(LocalDrivingLicenseApplicationID, ref ClassName, ref NationalNo, ref FullName,
                    ref ApplicationDate, ref PassedTestCount, ref Status))
            {
                return new clsLocalLicenseApplication_BLL(LocalDrivingLicenseApplicationID, ClassName, NationalNo, FullName,
                            ApplicationDate, PassedTestCount, Status);
            }
            else return null;
        }

        public int Add()
        {
            return clsLocalLicenseApplication_DAL.Add(ApplicationID, LicenseClassID);
        }

        public static bool IsLocalLicenseApplicationExists(int ApplicantID, int ClassID)
        {
            return clsLocalLicenseApplication_DAL.IsLocalLicenseApplicationExists(ApplicantID, ClassID);
        }
    }
}
