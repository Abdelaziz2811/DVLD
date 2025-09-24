using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_BLL;
using DVLD_BLL.Countries;
using System.IO;

namespace DVLD.User_Controls
{
    public partial class UC_Person_Selector: UserControl
    {
        clsPerson_BLL Person;

        public UC_Person_Selector()
        {
            InitializeComponent();
        }

        private void UC_Person_Selector_Load(object sender, EventArgs e)
        {
            InitializeCB_FindBy();
        }

        void InitializeCB_FindBy()
        {
            CB_FindBy.SelectedIndex = 0;
        }

        private void BTN_AddPerson_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = new clsPerson_BLL();
            AddUpdatePerson add_UpdatePerson = new AddUpdatePerson(ref Person);
            add_UpdatePerson.GetPersonID += GetNewAddedPersonInfo;
            add_UpdatePerson.ShowDialog();
        }

        private void BTN_FindPerson_Click(object sender, EventArgs e)
        {
            Person = new clsPerson_BLL();

            if (!string.IsNullOrWhiteSpace(TXTB_SearchBox.Text))
            {
                if (CB_FindBy.SelectedItem.ToString() == "PersonID")
                {
                    if (int.TryParse(TXTB_SearchBox.Text, out int ID))
                    {
                        Person = clsPerson_BLL.Find(ID);
                        if (Person != null)
                            Person_Info.GetPersonDetails(Person);
                        else
                            MessageBox.Show($"No person found with this ID '{ID}'", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Please enter a valid ID", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (CB_FindBy.SelectedItem.ToString() == "NationalNo.")
                {
                    Person = clsPerson_BLL.Find(TXTB_SearchBox.Text);
                    if (Person != null)
                        Person_Info.GetPersonDetails(Person);
                    else
                        MessageBox.Show($"No person found with this NationalNo. '{TXTB_SearchBox.Text}'", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
                MessageBox.Show("Please enter a valid Input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void GetNewAddedPersonInfo(int PersonID)
        {
            InitializeCB_FindBy();
            TXTB_SearchBox.Text = PersonID.ToString();
            BTN_FindPerson.PerformClick();
        }
    }
}
