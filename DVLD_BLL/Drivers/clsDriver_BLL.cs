using DVLD_DAL.Drivers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BLL.Drivers
{
    public enum enMode { Add, Update }
    public class clsDriver_BLL
    {
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }
        public enMode Mode { get; set; }

        public clsDriver_BLL()
        {
            DriverID = 0;
            PersonID = 0;
            CreatedByUserID = 0;
            CreatedDate = DateTime.Now;
            Mode = enMode.Add;
        }

        private clsDriver_BLL(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            Mode = enMode.Add;
        }

        private bool _Add()
        {
            DriverID = clsDriver_DAL.Add(PersonID, CreatedByUserID, CreatedDate);

            return DriverID != 0;
        }

        private bool _Update()
        {
            return clsDriver_DAL.Update(DriverID, PersonID, CreatedByUserID, CreatedDate);
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();

            return _Update();
        }

        public static clsDriver_BLL FindByPersonID(int PersonID)
        {
            int DriverID = 0;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;
            if (clsDriver_DAL.Find(ref DriverID, PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver_BLL(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            return null;
        }

        public static clsDriver_BLL FindByDriverID(int DriverID)
        {
            int PersonID = 0;
            int CreatedByUserID = 0;
            DateTime CreatedDate = DateTime.Now;
            if (clsDriver_DAL.Find(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver_BLL(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            return null;
        }

        public static DataTable LoadDrivers()
        {
            return clsDriver_DAL.LoadDrivers();
        }

        public static bool IsExists(int PersonID)
        {
            return clsDriver_DAL.IsExists(PersonID);
        }
    }
}
