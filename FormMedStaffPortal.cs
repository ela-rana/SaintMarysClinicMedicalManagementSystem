using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;    //needed for file operations
using System.Runtime.Serialization.Formatters.Binary;   //needed for binary ser/deser-ialization

namespace SaintMarysClinicMedicalManagementSystem
{
    public partial class FormMedStaffPortal : Form
    {
        MMSCRUD mms;
        Employee loggedInEmployee;
        MMSUser loggedInUser;
        public static FormMedStaffPortal instance;
        public string CurrentLoggedInEmail { get; set; }
        public FormMedStaffPortal()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void FormMedStaffPortal_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            //loggedInUser = mms.GetEmployee(CurrentLoggedInEmail, out loggedInEmployee);
            loggedInUser = mms.GetEmployee("Wendy@yahoo.com", out loggedInEmployee);
            txtbxFirstName.Text = loggedInUser.FirstName;
            txtbxMiddleName.Text = loggedInUser.MiddleName;
            txtbxLastName.Text = loggedInUser.LastName;
            txtbxPhone.Text = loggedInUser.Phone;
            txtbxSSN.Text = loggedInUser.SSN;
            DisplayAllAppointments();
            if(loggedInEmployee.EmpType>1 && loggedInEmployee.EmpType<5)    //meaning if they are a provider Emptype 2,3,4
            {
                btnChangeView.Visible = true;
            }
            List<MMSUser> allPatientUsers = mms.GetAllPatientUsers();
            List<StringBuilder> allPatientStrings = new List<StringBuilder>();
            foreach(MMSUser u in allPatientUsers)
            {
                allPatientStrings.Add(new StringBuilder($"ID: {u.UserID}, Name: {u.LastName}, {u.FirstName} {u.MiddleName}, Phone: {u.Phone}"));
            }
            cmbxSelectPatient.DataSource = allPatientStrings;
            cmbxSelectPatient.SelectedIndex = -1;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtbxFirstName.Enabled = true;
            txtbxMiddleName.Enabled = true;
            txtbxLastName.Enabled = true;
            txtbxSSN.Enabled = true;
            txtbxPhone.Enabled = true;
            lblUpdateInstructions.Visible = true;
            btnSaveChanges.Visible = true;
            btnUpdate.Visible = false;
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtbxFirstName.TextLength > 0 && txtbxLastName.TextLength > 0 &&
                txtbxSSN.TextLength > 0 && txtbxPhone.TextLength > 0)
            {
                Employee employeeToUpdate;
                //MMSUser userToUpdate = mms.GetEmployee(CurrentLoggedInEmail, out employeeToUpdate);
                MMSUser userToUpdate = mms.GetEmployee("Wendy@yahoo.com", out employeeToUpdate);
                userToUpdate.FirstName = txtbxFirstName.Text;
                userToUpdate.MiddleName = txtbxMiddleName.Text;
                userToUpdate.LastName = txtbxLastName.Text;
                userToUpdate.Phone = txtbxPhone.Text;
                userToUpdate.SSN = txtbxSSN.Text;
                mms.UpdateEmployee(userToUpdate, employeeToUpdate);
                MessageBox.Show("Profile Updated");
                RefreshPage();
            }
            else
            {
                MessageBox.Show("All fields except Middle Name must be filled");
            }
        }

        void RefreshPage()
        {
            txtbxFirstName.Enabled = false;
            txtbxMiddleName.Enabled = false;
            txtbxLastName.Enabled = false;
            txtbxSSN.Enabled = false;
            txtbxPhone.Enabled = false;
            lblUpdateInstructions.Visible = false;
            btnSaveChanges.Visible = false;
            btnUpdate.Visible = true;
        }
        private void btnBrowsePatient_Click(object sender, EventArgs e)
        {
            BrowsePatientDialog dialog = new BrowsePatientDialog();
            dialog.ShowDialog();
        }

        private void btnBrowseProvider_Click(object sender, EventArgs e)
        {
            BrowseProviderDialog dialog = new BrowseProviderDialog();
            dialog.ShowDialog();
        }

        private void btnChangeView_Click(object sender, EventArgs e)
        {
            switch(btnChangeView.Text)
            {
                case "View My Appointments Only":
                    lblDisplayDetails.Text = "Here are your appointments:";
                    DisplayThisProvidersAppointments();
                    btnChangeView.Text = "View All Appointments";
                    break;
                case "View All Appointments":
                    lblDisplayDetails.Text = "Here are all appointments for this clinic:";
                    DisplayAllAppointments();
                    btnChangeView.Text = "View My Appointments Only";
                    break;
            }
        }
        void DisplayAllAppointments()
        {
            dtgrdApptDisplay.DataSource = null;
            dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
            dtgrdApptDisplay.Columns[8].Visible = false;
            dtgrdApptDisplay.Columns[9].Visible = false;
        }
        void DisplayThisProvidersAppointments()
        {
            dtgrdApptDisplay.DataSource = null;
            dtgrdApptDisplay.DataSource = mms.GetProviderAppointments(loggedInUser.UserID);
            dtgrdApptDisplay.Columns[8].Visible = false;
            dtgrdApptDisplay.Columns[9].Visible = false;
        }

        private void btnSaveChart_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Are you sure you want to save this chart for patient:\n{cmbxSelectPatient.SelectedText}", 
               "Confirm Chart Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

            }
        }

        private void cmbxSelectPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpChart.Visible = true;
        }
    }
}
