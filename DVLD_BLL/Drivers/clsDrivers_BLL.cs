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

        //private clsDrivers_BLL()
        //{

        //}

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
    }
}
