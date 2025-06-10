using DVLD_DAL;
using DVLD_DAL.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL.Users
{
    public enum enUMode { Add, Update }

    public class clsUsers_BLL
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public enUMode Mode { get; set; }

        public clsUsers_BLL()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            this.Mode = enUMode.Add;
        }

        public clsUsers_BLL(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
            this.Mode = enUMode.Update;
        }

        private bool _Add()
        {
            this.UserID = clsUsers_DAL.Add(PersonID, UserName, Password, IsActive);

            return this.UserID != -1;
        }

        private bool _Update()
        {
            return clsUsers_DAL.Update(UserID, PersonID, UserName, Password, IsActive);
        }

        public bool Save()
        {
            if (Mode == enUMode.Add)
                return _Add();

            if (Mode == enUMode.Update)
                return _Update();

            return false;
        }

        public static DataTable GetUsersRecords()
        {
            return clsUsers_DAL.GetUsersRecords();
        }

        public static clsUsers_BLL Find(int UserID)
        {
            string UserName = string.Empty;
            int PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUsers_DAL.Find(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUsers_BLL(UserID, PersonID, UserName, Password, IsActive);
            }
            else return null;
        }

        public static clsUsers_BLL Find(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUsers_DAL.Find(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUsers_BLL(UserID, PersonID, UserName, Password, IsActive);
            }
            else return null;
        }

        public static bool Delete(int UserID)
        {
            return clsUsers_DAL.Delete(UserID);
        }
    }
}
