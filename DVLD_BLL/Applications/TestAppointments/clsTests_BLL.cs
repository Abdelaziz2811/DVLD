using DVLD_BLL.Applications.Applications;
using DVLD_BLL.Tests;
using DVLD_DAL.Applications.TestAppointments;
using DVLD_DAL.Applications.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BLL.Applications.TestAppointments
{
    public enum enTestMode { Add, Update };

    public class clsTests_BLL
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        enTestMode TestMode { get; set; }

        public clsTests_BLL()
        {
            TestID = 0;
            TestAppointmentID = 0;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = 0;
            TestMode = enTestMode.Add;
        }

        clsTests_BLL(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            TestMode = enTestMode.Update;
        }

        private bool _Add()
        {
            TestID = clsTests_DAL.Add(TestAppointmentID, TestResult, Notes, CreatedByUserID);

            return TestID != 0;
        }

        private bool _Update()
        {
            return clsTests_DAL.Update(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        public bool Save()
        {
            if (TestMode == enTestMode.Add)
                return _Add();

            return _Update();
        }

        public static bool IsPass(enTestType TestTypeID, int LocalDrivingLicenseApplicationID)
        {
            return clsTests_DAL.IsPass((int)TestTypeID, LocalDrivingLicenseApplicationID);
        }
    }
}
