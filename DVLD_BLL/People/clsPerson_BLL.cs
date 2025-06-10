using DVLD_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BLL
{
    public enum enMode { Add, Update }

    public class clsPerson_BLL
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }
        public enMode Mode { get; set; }

        public clsPerson_BLL()
        {
            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.BirthDate = DateTime.Now.AddYears(-18);
            this.Gender = 'U';
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;
            this.Mode = enMode.Add;
        }

        clsPerson_BLL(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime BirthDate,
                char Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
            this.Mode = enMode.Update;
        }

        private bool _Add()
        {
            this.PersonID = clsPersons_DAL.Add(NationalNo, FirstName, SecondName, ThirdName, LastName, BirthDate,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath);

            return this.PersonID != -1;
        }

        private bool _Update()
        {
            return clsPersons_DAL.Update(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, BirthDate,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        public bool Save()
        {
            if (Mode == enMode.Add)
                return _Add();

            if (Mode == enMode.Update)
                return _Update();

            return false;
        }

        public static DataTable GetPeopleRecords()
        {
            return clsPersons_DAL.GetPeopleRecords();
        }

        public static clsPerson_BLL Find(int PersonID)
        {
            string NationalNo = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime BirthDate = DateTime.Now.AddYears(-18);
            char Gender = 'U';
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsPersons_DAL.Find(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref BirthDate,
                ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson_BLL(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, BirthDate,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else return null;
        }

        public static clsPerson_BLL Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = string.Empty;
            string LastName = string.Empty;
            DateTime BirthDate = DateTime.Now.AddYears(-18);
            char Gender = 'U';
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsPersons_DAL.Find(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref BirthDate,
                ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson_BLL(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, BirthDate,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else return null;
        }

        public static clsPerson_BLL FindByName(string FullName)
        {
            int PersonID = -1;
            string NationalNo = string.Empty;
            DateTime BirthDate = DateTime.Now.AddYears(-18);
            char Gender = 'U';
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            int NationalityCountryID = -1;
            string ImagePath = string.Empty;

            if (clsPersons_DAL.Find(FullName, ref PersonID, ref NationalNo, ref BirthDate,
                ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                string[] SFullName = FullName.Split();
                return new clsPerson_BLL(PersonID, NationalNo, SFullName[0], SFullName[1], SFullName[2], SFullName[3], BirthDate,
                Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else return null;
        }

        public static bool Delete(int PersonID)
        {
            return clsPersons_DAL.Delete(PersonID);
        }

        public static bool IsNationalNoExists(string NationalNo)
        {
            return clsPersons_DAL.IsNationalNoExists(NationalNo);
        }

        public static int GetPersonID(string NationalNo)
        {
            return clsPersons_DAL.GetPersonID(NationalNo);
        }
    }
}
