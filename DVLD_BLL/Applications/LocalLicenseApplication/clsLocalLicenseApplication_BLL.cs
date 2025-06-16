using DVLD_DAL.Applications.New_Local_License_Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BLL.Applications.LocalLicenseApplication
{
    public enum enLocalLicenseApplicationMode { Add, Update }
    public class clsLocalLicenseApplication_BLL
    {
        public int LocalDrivingLicenseApplicationID {  get; set; }
        public int ApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public string ClassName { get; set; }
        public string NationalNo { get; set; }
        public string FullName { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int PassedTestCount { get; set; }
        public string Status { get; set; }
        public enLocalLicenseApplicationMode Mode { get; set; }

        public clsLocalLicenseApplication_BLL()
        {
            LocalDrivingLicenseApplicationID = 0;
            ApplicationID = 0;
            LicenseClassID = 0;
            Mode = enLocalLicenseApplicationMode.Add;
        }

        clsLocalLicenseApplication_BLL(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
            Mode = enLocalLicenseApplicationMode.Update;
        }

        clsLocalLicenseApplication_BLL(int LocalDrivingLicenseApplicationID, string ClassName, string NationalNo, string FullName,
            DateTime ApplicationDate, int PassedTestCount, string Status)
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.ClassName = ClassName;
            this.NationalNo = NationalNo;
            this.FullName = FullName;
            this.ApplicationDate = ApplicationDate;
            this.PassedTestCount = PassedTestCount;
            this.Status = Status;
            Mode = enLocalLicenseApplicationMode.Update;
        }

        private bool _Add()
        {
            LocalDrivingLicenseApplicationID = clsLocalLicenseApplication_DAL.Add(ApplicationID, LicenseClassID);
            return LocalDrivingLicenseApplicationID != 0;
        }

        private bool _Update()
        {
            return clsLocalLicenseApplication_DAL.Update(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
        }

        public bool Save()
        {
            if (Mode == enLocalLicenseApplicationMode.Add)
                return _Add();

            return _Update();
        }

        public static DataTable GetLocalLicenseApplications()
        {
            return clsLocalLicenseApplication_DAL.GetLocalLicenseApplications();
        }

        public static clsLocalLicenseApplication_BLL FindInView(int LocalDrivingLicenseApplicationID)
        {
            string ClassName = string.Empty;
            string NationalNo = string.Empty;
            string FullName = string.Empty;
            DateTime ApplicationDate = DateTime.Now;
            int PassedTestCount = 0;
            string Status = string.Empty;

            if (clsLocalLicenseApplication_DAL.FindInView(LocalDrivingLicenseApplicationID, ref ClassName, ref NationalNo, ref FullName,
                    ref ApplicationDate, ref PassedTestCount, ref Status))
            {
                return new clsLocalLicenseApplication_BLL(LocalDrivingLicenseApplicationID, ClassName, NationalNo, FullName,
                            ApplicationDate, PassedTestCount, Status);
            }
            else return null;
        }

        public static clsLocalLicenseApplication_BLL Find(int LocalDrivingLicenseApplicationID)
        {
            int ApplicationID = 0;
            int LicenseClassID = 0;

            if (clsLocalLicenseApplication_DAL.Find(LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID))
            {
                return new clsLocalLicenseApplication_BLL(LocalDrivingLicenseApplicationID, ApplicationID, LicenseClassID);
            }
            else return null;
        }

        public static bool IsLocalLicenseApplicationExists(int ApplicantID, int ClassID)
        {
            return clsLocalLicenseApplication_DAL.IsLocalLicenseApplicationExists(ApplicantID, ClassID);
        }
    }
}
