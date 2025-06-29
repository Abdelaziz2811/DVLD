using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Users;
using DVLD_DAL.Applications.Local_License_Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_BLL.Applications.LocalLicenseApplication
{
    public enum enMode { Add, Update }
    public enum enIssueReason { First_Time = 1, Renew }
    public class clsLicense_BLL
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID {  get; set; }
        public byte LicenseClass {  get; set; }
        public DateTime IssueDate {  get; set; }
        public DateTime ExpirationDate {  get; set; }
        public string Notes {  get; set; }
        public decimal PaidFees {  get; set; }
        public bool IsActive {  get; set; }
        public enIssueReason IssueReason {  get; set; }
        public int CreatedByUserID {  get; set; }
        public enMode Mode { get; set; }
        public clsLicense_BLL()
        {
            LicenseID = 0;
            ApplicationID = 0;
            DriverID = 0;
            LicenseClass = 0;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = true;
            IssueReason = enIssueReason.First_Time;
            CreatedByUserID = 0;
            Mode = enMode.Add;
        }

        private clsLicense_BLL(int LicenseID, int ApplicationID, int DriverID, byte LicenseClass, DateTime IssueDate,
            DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            Mode = enMode.Update;
        }

        private bool _Add()
        {
            LicenseID = clsLicense_DAL.Add(ApplicationID, DriverID, LicenseClass, IssueDate,
                        ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);
            return LicenseID != 0;
        }

        private bool _Update()
        {
            return clsLicense_DAL.Update(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate,
                        ExpirationDate, Notes, PaidFees, IsActive, (byte)IssueReason, CreatedByUserID);
        }

        public static clsLicense_BLL FindByAppID(int ApplicationID)
        {
            int LicenseID = 0;
            int DriverID = 0;
            byte LicenseClass = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = string.Empty;
            decimal PaidFees = 0;
            bool IsActive = true;
            byte IssueReason = 1;
            int CreatedByUserID = 0;

            if (clsLicense_DAL.Find(ref LicenseID, ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate,
                ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense_BLL(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes,
                    PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }
            return null;
        }

        public static clsLicense_BLL FindByLicenseID(int LicenseID)
        {
            int ApplicationID = 0;
            int DriverID = 0;
            byte LicenseClass = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now;
            string Notes = string.Empty;
            decimal PaidFees = 0;
            bool IsActive = true;
            byte IssueReason = 1;
            int CreatedByUserID = 0;

            if (clsLicense_DAL.Find(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass, ref IssueDate,
                ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense_BLL(LicenseID, ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes,
                    PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }
            return null;
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();

            return _Update();
        }

        public static DataTable LoadLicensesHistory(int PersonID)
        {
            return clsLicense_DAL.LoadLicensesHistory(PersonID);
        }
    }
}
