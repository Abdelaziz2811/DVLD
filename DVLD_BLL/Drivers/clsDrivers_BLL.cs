using DVLD_DAL.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BLL.Drivers
{
    public enum enMode { Add, Update }
    public class clsDrivers_BLL
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public enMode Mode { get; set; }

        public clsDrivers_BLL()
        {
            DriverID = 0;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Now;
            Mode = enMode.Add;
        }

        private clsDrivers_BLL(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Add;
        }

        private bool _Add()
        {
            DriverID = clsDrivers_DAL.Add(PersonID, CreatedByUserID, CreatedDate);

            return DriverID != 0;
        }

        private bool _Update()
        {
            return clsDrivers_DAL.Update(DriverID, PersonID, CreatedByUserID, CreatedDate);
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();

            return _Update();
        }

        public static clsDrivers_BLL Find(int PersonID)
        {
            int DriverID = 0;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;
            if (clsDrivers_DAL.Find(ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDrivers_BLL(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            return null;
        }

        public static bool IsExists(int PersonID)
        {
            return clsDrivers_DAL.IsExists(PersonID);
        }
    }
}
