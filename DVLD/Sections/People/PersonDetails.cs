using DVLD_BLL;
using DVLD_BLL.Countries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonDetails: Form
    {
        clsPerson_BLL Person;
        public PersonDetails(ref clsPerson_BLL Person)
        {
            InitializeComponent();

            this.Person = Person;
        }

        public delegate void LicenseDetails_LoadPersonInfo(clsPerson_BLL Person);
        public event LicenseDetails_LoadPersonInfo LoadPersonInfo;

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            UC_Person_Info.GetPersonDetails(Person);
        }

        private void PersonDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoadPersonInfo?.Invoke(Person);
        }
    }
}
