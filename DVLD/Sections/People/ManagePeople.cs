using DVLD.User_Controls;
using DVLD_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ManagePeople: Form
    {
        public ManagePeople()
        {
            InitializeComponent();
        }
        private void ManagePeople_Load(object sender, EventArgs e)
        {
            GetPeopleRecords();
            GetPeopleRecordsCount();
        }

        void RefreshPeopleInfo()
        {
            GetPeopleRecords();
            GetPeopleRecordsCount();
        }

        void GetPeopleRecords()
        {
            DGV_People.DataSource = clsPerson_BLL.GetPeopleRecords();
        }

        void GetPeopleRecordsCount()
        {
            LB_RecordsCount.Text = DGV_People.RowCount.ToString();
        }

        private void BTN_AddPerson_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = new clsPerson_BLL();
            AddUpdatePerson add_UpdatePerson = new AddUpdatePerson(ref Person);
            add_UpdatePerson.ShowDialog();
            RefreshPeopleInfo();
        }

        private void TSMI_ShowDetails_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(Convert.ToInt32(DGV_People.CurrentRow.Cells[0].Value));
            if (Person != null)
            {
                PersonDetails personDetails = new PersonDetails(ref Person);
                personDetails.ShowDialog();
                RefreshPeopleInfo();
            }
            else
            {
                MessageBox.Show("Please select a person to view details.", "No Person Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TSMI_AddPerson_Click(object sender, EventArgs e)
        {
            BTN_AddPerson.PerformClick();
        }

        private void TSMI_UpdatePerson_Click(object sender, EventArgs e)
        {
            clsPerson_BLL Person = clsPerson_BLL.Find(Convert.ToInt32(DGV_People.CurrentRow.Cells[0].Value));
            if (Person != null)
            {
                AddUpdatePerson add_UpdatePerson = new AddUpdatePerson(ref Person);
                add_UpdatePerson.ShowDialog();
                RefreshPeopleInfo();
            }
            else
            {
                MessageBox.Show("Please select a person to update.", "No Person Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TSMI_DeletePerson_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            if (clsPerson_BLL.Delete(Convert.ToInt32(DGV_People.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Person deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshPeopleInfo();
            }
            else
            {
                MessageBox.Show("Failed to delete person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TSMI_Refresh_Click(object sender, EventArgs e)
        {
            RefreshPeopleInfo();
        }

        private void TSMI_SendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSMI_PhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Feature Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CB_FilterBy_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(CB_FilterBy.SelectedItem.ToString())
            {
                case "None":
                    break;

                case "Person ID":
                    break;
                
                case "National No.":
                    break;

                case "First Name":
                    break;
                case "Second Name":
                    break;

                case "Third Name":
                    break;

                case "Last Name":
                    break;

                case "Nationality":
                    break;

                case "Gender":
                    break;

                case "Phone":
                    break;

                case "Email":
                    break;
            }
        }
    }
}
