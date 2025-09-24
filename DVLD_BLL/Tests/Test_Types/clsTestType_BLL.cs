using DVLD_DAL.Tests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Tests
{
    public enum enTestType { VisionTest = 1, WrittenTest, StreetTest };
    public class clsTestType_BLL
    {
        public int TestTypeID { get; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public short TestTypeFees { get; set; }
        public enTestType TestType { get; set; }

        clsTestType_BLL(int TestTypeID, string TestTypeTitle, string TestTypeDescription, short TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
            this.TestType = (enTestType)TestTypeID;
        }

        public static DataTable GetTestTypes()
        {
            return clsTestType_DAL.GetTestTypes();
        }

        public static clsTestType_BLL Find(int TestTypeID)
        {
            string TestTypeTitle = string.Empty;
            string TestTypeDescription = string.Empty;
            short TestTypeFees = 0;

            if (clsTestType_DAL.Find(TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType_BLL(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else 
                return null;
        }

        public static clsTestType_BLL Find(string TestTypeTitle)
        {
            int TestTypeID = 0;
            string TestTypeDescription = string.Empty;
            short TestTypeFees = 0;

            if (clsTestType_DAL.Find(ref TestTypeID, TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
            {
                return new clsTestType_BLL(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            }
            else
                return null;
        }

        public bool Update()
        {
            return clsTestType_DAL.Update(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }
    }
}
