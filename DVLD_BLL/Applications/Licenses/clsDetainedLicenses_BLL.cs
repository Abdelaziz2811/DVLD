using DVLD_DAL.Applications.Licenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Applications.Licenses
{
    public class clsDetainedLicenses_BLL
    {
        public enum enMode { Add, Update }
        public int DetainID {  get; set; }
        public int LicenseID {  get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }
        public enMode Mode { get; set; }

        public clsDetainedLicenses_BLL()
        {
            DetainID = 0;
            LicenseID = 0;
            DetainDate = DateTime.Now;
            FineFees = 0;
            CreatedByUserID = 0;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = 0;
            ReleaseApplicationID = 0;
            Mode = enMode.Add;
        }
        
        private clsDetainedLicenses_BLL(int DetainID, int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            Mode = enMode.Add;
        }

        private bool _Add()
        {
            DetainID = clsDetainedLicenses_DAL.Add(LicenseID, DetainDate, FineFees, CreatedByUserID,
                                     IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            return DetainID != 0;
        }

        private bool _Update()
        {
            return clsDetainedLicenses_DAL.Update(DetainID, LicenseID, DetainDate,FineFees, CreatedByUserID,
                                                  IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();
            return _Update();
        }

        public static bool IsExists(int LicenseID)
        {
            return clsDetainedLicenses_DAL.IsExists(LicenseID);
        }
    }
}
