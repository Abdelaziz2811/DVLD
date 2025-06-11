using DVLD.Properties;
using DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Test_Appointments;
using DVLD.User_Controls.Applications_Section;
using DVLD_BLL;
using DVLD_BLL.Applications.TestAppointments;
using DVLD_BLL.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Sections.Applications.Driving_Licenses_Services.New_Driving_License.Tests
{
    public partial class ScheduleTest : Form
    {
        UC_LicenseApplicationInfo LicenseApplicationInfo;
        enTestType TestType;
        public ScheduleTest(UC_LicenseApplicationInfo LicenseApplicationInfo, enTestType TestType)
        {
            InitializeComponent();

            this.LicenseApplicationInfo = LicenseApplicationInfo;
            this.TestType = TestType;
        }

        private void ScheduleTest_Load(object sender, EventArgs e)
        {
            SetDTPMinDate();
            LoadTestAppointmentInfo();
        }

        void SetDTPMinDate()
        {
            DTP_TestAppointment.MinDate = DateTime.Now;
        }

        void LoadTestAppointmentInfo()
        {
            switch(TestType)
            {
                case enTestType.VisionTest:
                    GB_TestInfo.Text = "Vision Test";
                    PB_TestImage.Image = Resources.VisionTest;
                    break;
                case enTestType.WrittenTest:
                    GB_TestInfo.Text = "Written Test";
                    PB_TestImage.Image = Resources.WrittenTest;
                    break;
                case enTestType.StreetTest:
                    GB_TestInfo.Text = "Street Test";
                    PB_TestImage.Image = Resources.StreetTest;
                    break;
            }

            LB_DLAppID.Text = LicenseApplicationInfo.LB_DLAppID.Text;
            LB_LicenseClass.Text = LicenseApplicationInfo.LB_LicenseClass.Text;
            LB_Name.Text = LicenseApplicationInfo.LB_ApplicantName.Text;
            LB_Trial.Text = clsTestAppointments_BLL.TrialCount(TestType, Convert.ToInt32(LicenseApplicationInfo.LB_DLAppID.Text)).ToString();
            LB_Fees.Text = clsTestTypes_BLL.Find(Convert.ToInt32(TestType)).TestTypeFees.ToString();

            if (Convert.ToInt16(LB_Trial.Text) > 0)
                LB_RetakeAppFees.Text = clsApplicationTypes_BLL.Find("Retake Test").ApplicationFees.ToString();

            LB_TotalFees.Text = (Convert.ToInt16(LB_Fees.Text) + Convert.ToInt16(LB_RetakeAppFees.Text)).ToString();
        }
    }
}
