using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintMarysClinicMedicalManagementSystem
{
    public partial class FormPatientPortal : Form
    {
        MMSCRUD mms;

        public string CurrentLoggedInEmail { get; set; }
        public FormPatientPortal()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {

        }

        private void FormPatientPortal_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            Patient loggedInPatient;
            MMSUser loggedInUser = mms.GetPatient("ggg@ggg.com", out loggedInPatient);
            //MMSUser loggedInUser = mms.GetPatient(CurrentLoggedInEmail, out loggedInPatient);
            txtbxFirstName.Text = loggedInUser.FirstName;
            txtbxMiddleName.Text = loggedInUser.MiddleName;
            txtbxLastName.Text = loggedInUser.LastName;
            txtbxAddress.Text = loggedInPatient.Address;
            dttmDOB.Value = loggedInPatient.DOB;
        }

        private void FormPatientPortal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtbxFirstName.Enabled = true;
            txtbxMiddleName.Enabled = true;
            txtbxLastName.Enabled = true;
            txtbxAddress.Enabled = true;
            dttmDOB.Enabled = true;
            lblUpdateInstructions.Visible = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

        }
    }
}
