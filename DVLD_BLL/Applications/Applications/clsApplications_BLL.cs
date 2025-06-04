using DVLD_BLL.Applications.LocalLicenseApplication;
using DVLD_DAL.Applications.Local_License;
using DVLD_DAL.Applications.New_Local_License_Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BLL.Applications.Applications
{
    public enum Mode { Add, Update }
    public enum enApplicationStatus { New = 1, Canceled, Complete }
    public class clsApplications_BLL
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus ApplicationStatus {  get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public enMode Mode { get; set; }

        public clsApplications_BLL()
        {
            ApplicationID = 0;
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = 0;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            Mode = enMode.Add;
        }

        clsApplications_BLL(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = (enApplicationStatus)ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            ApplicationID = clsApplications_DAL.Add(ApplicantPersonID, ApplicationDate, ApplicationTypeID, (byte)ApplicationStatus,
                LastStatusDate, PaidFees, CreatedByUserID);

            return ApplicationID != 0;
        }

        private bool _Update()
        {
            return clsApplications_DAL.Update(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, (byte)ApplicationStatus,
                LastStatusDate, PaidFees, CreatedByUserID);
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();
            else
                return _Update();
        }

        public static DataTable GetApplications()
        {
            return clsApplications_DAL.GetApplications();
        }

        public static clsApplications_BLL Find(int ApplicationID)
        { 
            
            int ApplicantPersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = 0;
            byte ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;
            int CreatedByUserID = 0;

            if (clsApplications_DAL.Find(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {
                return new clsApplications_BLL(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
                LastStatusDate, PaidFees, CreatedByUserID);
            }
            else return null;
        }
    }
}
