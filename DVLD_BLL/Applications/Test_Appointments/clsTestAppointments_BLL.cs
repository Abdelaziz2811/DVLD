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
    public enum enTestAppointmentMode { Add, Update }
    public class clsTestAppointments_BLL
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public enTestAppointmentMode Mode { get; set; }

        public clsTestAppointments_BLL()
        {
            TestAppointmentID = 0;
            TestTypeID = 0;
            LocalDrivingLicenseApplicationID = 0;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUserID = 0;
            IsLocked = false;
            Mode = enTestAppointmentMode.Add;
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
            Mode = enTestAppointmentMode.Update;
        }

        private bool _Add()
        {
            TestAppointmentID = clsTestAppointments_DAL.Add(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate,
                                                        PaidFees, CreatedByUserID, IsLocked);
            return TestAppointmentID != 0;
        }

        private bool _Update()
        {
            return clsTestAppointments_DAL.Update(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                                           AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
        }

        public bool Save()
        {
            if (Mode == enTestAppointmentMode.Add)
                return _Add();

            return _Update();
        }

        public static DataTable LoadTestAppointments(enTestType TestType, int LocalDrivingLicenseID)
        {
            return clsTestAppointments_DAL.LoadTestAppointments(Convert.ToInt32(TestType), LocalDrivingLicenseID);
        }

        public static clsTestAppointments_BLL Find(int TestAppointmentID)
        {
            int TestTypeID = 0;
            int LocalDrivingLicenseApplicationID = 0;
            DateTime AppointmentDate = DateTime.Now;
            decimal PaidFees = 0; 
            int CreatedByUserID = 0;
            bool IsLocked = false;
            if (clsTestAppointments_DAL.Find(TestAppointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked))
            {
                return new clsTestAppointments_BLL(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                                                   AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            }
            return null;
        }

        public static DateTime TestAppointmentDate(int LocalLicenseAppID, enTestType TestType)
        {
            return clsTestAppointments_DAL.TestAppointmentDate(LocalLicenseAppID, (byte)TestType);
        }

        public static bool Exists(enTestType TestType, int LocalDrivingLicenseID)
        {
            return clsTestAppointments_DAL.IsExists((byte)TestType, LocalDrivingLicenseID);
        }

        public static int TrialCount(enTestType TestType, int LocalDrivingLicenseID)
        {
            return clsTestAppointments_DAL.TrialCount((byte)TestType, LocalDrivingLicenseID);
        }
    }
}
