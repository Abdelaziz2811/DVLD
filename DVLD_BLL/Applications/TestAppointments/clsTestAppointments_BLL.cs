using DVLD_BLL.Tests;
using DVLD_DAL.Applications.TestAppointments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Applications.TestAppointments
{
    public class clsTestAppointments_BLL
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        public clsTestAppointments_BLL()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
        }

        clsTestAppointments_BLL(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate
            , decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
        }

        public static DataTable LoadTestAppointments(enTestType TestType, int LocalDrivingLicenseID)
        {
            return clsTestAppointments_DAL.LoadTestAppointments(Convert.ToInt32(TestType), LocalDrivingLicenseID);
        }

        public static bool Exists(enTestType TestType, int LocalDrivingLicenseID)
        {
            return clsTestAppointments_DAL.Exists((byte)TestType, LocalDrivingLicenseID);
        }

        public static int TrialCount(enTestType TestType, int LocalDrivingLicenseID)
        {
            return clsTestAppointments_DAL.TrialCount((byte)TestType, LocalDrivingLicenseID);
        }
    }
}
