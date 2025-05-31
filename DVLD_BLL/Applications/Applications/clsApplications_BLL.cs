using DVLD_DAL.Applications.Local_License;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Applications.Applications
{
    public enum enApplicationStatus { New = 1, Complete, Canceled }
    public class clsApplications_BLL
    {
        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus ApplicationStatus {  get; set; }
        public DateTime LastStatusDate { get; set; }
        public short PaidFees { get; set; }
        public int CreatedByUserID { get; set; }

        public clsApplications_BLL()
        {
            ApplicantPersonID = 0;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = 0;
            ApplicationStatus = enApplicationStatus.New;
            LastStatusDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
        }

        clsApplications_BLL(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, byte ApplicationStatus,
            DateTime LastStatusDate, short PaidFees, int CreatedByUserID)
        {
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = (enApplicationStatus)ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        public int Add()
        {
            return (ApplicationID = clsApplications_DAL.Add(ApplicantPersonID, ApplicationDate, ApplicationTypeID, (byte)ApplicationStatus,
                LastStatusDate, PaidFees, CreatedByUserID));
        }

        public static DataTable GetApplications()
        {
            return clsApplications_DAL.GetApplications();
        }
    }
}
