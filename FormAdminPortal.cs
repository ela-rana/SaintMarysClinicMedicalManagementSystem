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
    public partial class FormAdminPortal : Form
    {
        MMSCRUD mms;
        Employee loggedInEmployee;
        MMSUser loggedInUser;

        public string CurrentLoggedInEmail { get; set; }
        public FormAdminPortal()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void FormAdminPortal_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            //loggedInUser = mms.GetEmployee(CurrentLoggedInEmail, out loggedInEmployee);
            loggedInUser = mms.GetEmployee("elarana@mssa.unitedtraining.com", out loggedInEmployee);
            txtbxFirstName.Text = loggedInUser.FirstName;
            txtbxMiddleName.Text = loggedInUser.MiddleName;
            txtbxLastName.Text = loggedInUser.LastName;
            txtbxPhone.Text = loggedInUser.Phone;
            txtbxSSN.Text = loggedInUser.SSN;
            dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
            cmbbxDuration.DataSource = Enum.GetValues(typeof(Durations)); //to set possible values for
                                                                            //Duration combobox 
            cmbbxDuration.SelectedIndex = -1; //to keep the combobox blank until user selects a dropdown 
                            //option by setting the index to a value lower than the first index
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
                MMSUser userToUpdate = mms.GetEmployee("elarana@mssa.unitedtraining.com", out employeeToUpdate);
                userToUpdate.FirstName = txtbxFirstName.Text;
                userToUpdate.MiddleName = txtbxMiddleName.Text;
                userToUpdate.LastName = txtbxLastName.Text;
                userToUpdate.Phone = txtbxPhone.Text;
                userToUpdate.SSN = txtbxSSN.Text;
                mms.UpdateEmployee(userToUpdate, employeeToUpdate);
                MessageBox.Show("Profile Updated");
                RefreshPage();
                dtgrdApptDisplay.DataSource = null;
                dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int apptToDeleteID = (int)dtgrdApptDisplay.CurrentRow.Cells[0].Value;
            mms.DeleteAppointment(apptToDeleteID);
            MessageBox.Show("Appointment deleted");
            dtgrdApptDisplay.DataSource = null;
            dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
        }
    }
}
