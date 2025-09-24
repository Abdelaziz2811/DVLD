using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using DVLD.Properties;
using DVLD_BLL.Countries;
using DVLD_BLL;

namespace DVLD.User_Controls
{
    public partial class UC_Add_UpdatePerson: UserControl
    {
        public UC_Add_UpdatePerson()
        {
            InitializeComponent();
        }

        public string ImagePath = string.Empty;

        private void UC_Add_UpdatePerson_Load(object sender, EventArgs e)
        {
            SetDTP_MaxDate();
            GetCountries();
        }

        void GetCountries()
        {
            DataTable DTCountries = clsCountry_BLL.GetCountries();
            foreach (DataRow Row in DTCountries.Rows)
                CB_Countries.Items.Add(Row["CountryName"]);
            CB_Countries.SelectedItem = "Morocco";
        }

        void SetDTP_MaxDate()
        {
            DTP_BirthDate.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void BTN_SetImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_PersonImage.ImageLocation = openFileDialog.FileName;
                ImagePath = SaveImageToFolder(openFileDialog.FileName);
            }
        }

        string SaveImageToFolder(string SourcePath)
        {
            string FolderPath = @"C:\DVLD\Persons_Images";

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            
            string FileName = Path.GetFileName(SourcePath);
            string DestinationPath = Path.Combine(FolderPath, Guid.NewGuid().ToString() + '_' + FileName);

            File.Copy(SourcePath, DestinationPath);

            return DestinationPath;
        }

        private void BTN_RemoveImage_Click(object sender, EventArgs e)
        {
            PB_PersonImage.Image = null;
            PB_PersonImage.ImageLocation = null;
            ImagePath = string.Empty;
        } 
        
        private void TXTB_NationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (clsPerson_BLL.IsNationalNoExists(TXTB_NationalNo.Text) && this.Parent.FindForm().Tag.ToString() == "Add Person Info")
            {
                EP_ValidatingInputs.SetError(TXTB_NationalNo, "NationalNo already exists");
                e.Cancel = true;
            }
            else EP_ValidatingInputs.Clear();
        }

        bool IsInputsValid()
        {
            bool IsValid = true;
            EP_ValidatingInputs.Clear();

            if (string.IsNullOrWhiteSpace(TXTB_FirstName.Text) || !TXTB_FirstName.Text.All(char.IsLetter))
            {
                EP_ValidatingInputs.SetError(TXTB_FirstName, "First Name is invalid.");
                IsValid = false;
            }
            if (string.IsNullOrWhiteSpace(TXTB_LastName.Text) || !TXTB_LastName.Text.All(char.IsLetter))
            {
                EP_ValidatingInputs.SetError(TXTB_LastName, "Last Name is invalid.");
                IsValid = false;
            }
            if (string.IsNullOrWhiteSpace(TXTB_NationalNo.Text) || !TXTB_NationalNo.Text.All(char.IsLetterOrDigit))
            {
                EP_ValidatingInputs.SetError(TXTB_NationalNo, "NationalNo is invalid");
                IsValid = false;
            }
            if (string.IsNullOrWhiteSpace(TXTB_Email.Text) || !Regex.IsMatch(TXTB_Email.Text, @"^[a-zA-Z0-9_]+@[a-zA-Z0-9.]+\.[a-zA-Z]{2,}$"))
            {
                EP_ValidatingInputs.SetError(TXTB_Email, "Email is invalid");                                                   
                IsValid = false;
            }
            if (string.IsNullOrWhiteSpace(TXTB_Phone.Text) || !TXTB_Phone.Text.All(char.IsDigit))
            {
                EP_ValidatingInputs.SetError(TXTB_Phone, "Phone is invalid");
                IsValid = false;
            }
            if (string.IsNullOrWhiteSpace(TXTB_Address.Text) || !Regex.IsMatch(TXTB_Address.Text, @"^[a-zA-Z0-9\s,.\-#]+$"))
            {
                EP_ValidatingInputs.SetError(TXTB_Address, "Address is invalid.");
                IsValid = false;
            }
            return IsValid;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (!IsInputsValid())
            {
                MessageBox.Show("Inputs are not valid, make sure to enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BTN_Save.Tag = "Inputs are valid";
            this.Parent.FindForm().Close();
        }
    }
}
