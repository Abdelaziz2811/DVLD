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

    public class clsUser_BLL
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public enUMode Mode { get; set; }

        public clsUser_BLL()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActive = false;
            this.Mode = enUMode.Add;
        }

        public clsUser_BLL(int UserID, int PersonID, string UserName, string Password, bool IsActive)
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
            this.UserID = clsUser_DAL.Add(PersonID, UserName, Password, IsActive);

            return this.UserID != -1;
        }

        private bool _Update()
        {
            return clsUser_DAL.Update(UserID, PersonID, UserName, Password, IsActive);
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
            return clsUser_DAL.GetUsersRecords();
        }

        public static clsUser_BLL Find(int UserID)
        {
            string UserName = string.Empty;
            int PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUser_DAL.Find(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser_BLL(UserID, PersonID, UserName, Password, IsActive);
            }
            else return null;
        }

        public static clsUser_BLL Find(string UserName)
        {
            int UserID = -1;
            int PersonID = -1;
            string Password = string.Empty;
            bool IsActive = false;

            if (clsUser_DAL.Find(ref UserID, ref PersonID, UserName, ref Password, ref IsActive))
            {
                return new clsUser_BLL(UserID, PersonID, UserName, Password, IsActive);
            }
            else return null;
        }

        public static bool Delete(int UserID)
        {
            return clsUser_DAL.Delete(UserID);
        }
    }
}
