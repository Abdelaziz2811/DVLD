using DVLD_DAL.Applications.Licenses;
using DVLD_DAL.Applications.Local_License_Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Applications.Licenses
{
    public enum enMode { Add, Update }

    public class clsInternationalLicense_BLL
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        public enMode Mode { get; set; }
        public clsInternationalLicense_BLL()
        {
            InternationalLicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            IssuedUsingLocalLicenseID = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = true;
            CreatedByUserID = 0;
            Mode = enMode.Add;
        }

        private clsInternationalLicense_BLL(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            InternationalLicenseID = clsInternationalLicense_DAL.Add(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate,
                        ExpirationDate, IsActive, CreatedByUserID);
            return InternationalLicenseID != 0;
        }

        private bool _Update()
        {
            return clsInternationalLicense_DAL.Update(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate,
                        ExpirationDate, IsActive, CreatedByUserID);
        }

        public static clsInternationalLicense_BLL FindByAppID(int ApplicationID)
        {
            int InternationalLicenseID = 0;
            int DriverID = 0;
            int IssuedUsingLocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = 0;

            if (clsInternationalLicense_DAL.Find(ref InternationalLicenseID, ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
                ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense_BLL(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                                                       IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            return null;
        }

        public static clsInternationalLicense_BLL FindByInternationalLicenseID(int InternationalLicenseID)
        {
            int ApplicationID = 0;
            int DriverID = 0;
            int IssuedUsingLocalLicenseID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            bool IsActive = true;
            int CreatedByUserID = 0;

            if (clsInternationalLicense_DAL.Find(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID,
                                                 ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicense_BLL(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                                                       IssueDate, ExpirationDate, IsActive, CreatedByUserID);
            }
            return null;
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();

            return _Update();
        }

        public static DataTable LoadInternationalLicenses()
        {
            return clsInternationalLicense_DAL.LoadInternationalLicenses();
        }
    }
}
