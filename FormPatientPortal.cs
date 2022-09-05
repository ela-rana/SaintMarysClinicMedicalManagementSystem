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
        Patient loggedInPatient;
        MMSUser loggedInUser;

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

        private void FormPatientPortal_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            loggedInUser = mms.GetPatient(CurrentLoggedInEmail, out loggedInPatient);
            txtbxFirstName.Text = loggedInUser.FirstName;
            txtbxMiddleName.Text = loggedInUser.MiddleName;
            txtbxLastName.Text = loggedInUser.LastName;
            txtbxPhone.Text = loggedInUser.Phone;
            txtbxAddress.Text = loggedInPatient.Address;
            dttmDOB.Value = loggedInPatient.DOB;
            dtgrdApptDisplay.DataSource = mms.GetPatientAppointments(loggedInUser.UserID);
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
            txtbxPhone.Enabled = true;
            dttmDOB.Enabled = true;
            lblUpdateInstructions.Visible = true;
            btnSaveChanges.Visible = true;
            btnUpdate.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (txtbxFirstName.TextLength > 0 && txtbxLastName.TextLength > 0 &&
                txtbxAddress.TextLength > 0 && txtbxPhone.TextLength > 0)
            {
                Patient patientToUpdate;
                MMSUser userToUpdate = mms.GetPatient(CurrentLoggedInEmail, out patientToUpdate);
                userToUpdate.FirstName = txtbxFirstName.Text;
                userToUpdate.MiddleName = txtbxMiddleName.Text;
                userToUpdate.LastName = txtbxLastName.Text;
                userToUpdate.Phone = txtbxPhone.Text;
                patientToUpdate.Address = txtbxAddress.Text;
                patientToUpdate.DOB = (DateTime)dttmDOB.Value.Date;
                mms.UpdatePatient(userToUpdate, patientToUpdate);
                MessageBox.Show("Profile Updated");
                RefreshPage();
                dtgrdApptDisplay.DataSource = null;
                dtgrdApptDisplay.DataSource = userToUpdate.UserID;
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
            txtbxAddress.Enabled = false;
            txtbxPhone.Enabled = false;
            dttmDOB.Enabled = false;
            lblUpdateInstructions.Visible = false;
            btnSaveChanges.Visible = false;
            btnUpdate.Visible = true;
        }

        private void txtApptDescription_Validating(object sender, CancelEventArgs e)
        {
            if(txtApptDescription.TextLength>50)
            {
                MessageBox.Show("Description can be upto 50 characters (including spaces). No more that that.");
                e.Cancel = true;
            }
        }

        private void dttmApptDate_Validating(object sender, CancelEventArgs e)
        {
            if(dttmApptDate.Value.DayOfWeek == DayOfWeek.Saturday || dttmApptDate.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("Appointment date cannot be on a weekend. Please select a weekday value");
                e.Cancel = true;
            }
        }

        private void dttmApptTime_Validating(object sender, CancelEventArgs e)
        {
            //if (dttmApptDate.Value.Minute != 30 || dttmApptDate.Value.Minute != 00)
            //{
            //    MessageBox.Show("Appointment time must be on the hour or half-hour mark. Please change minutes to 00 or 30");
            //    e.Cancel = true;
            //}
        }

        private void btnMakeAppt_Click(object sender, EventArgs e)
        {
            bool providerNotAvailable = false;
            List<Appointment> providersAppointments = mms.GetProviderAppointments(loggedInPatient.PCMUserID);
            foreach (Appointment a in providersAppointments)
            {
                if (a.ApptDate.Date == dttmApptDate.Value.Date && a.ApptTime == dttmApptTime.Value.TimeOfDay)
                {
                    MessageBox.Show("The provider is not available at this date and time. Please try readjusting date and/or time");
                    providerNotAvailable = true;
                    break;
                }
            }
            if (providerNotAvailable == false)
            {
                Appointment newAppt = new Appointment();
                newAppt.ApptID = mms.MaxApptID() + 1;
                newAppt.ApptDate = dttmApptDate.Value.Date;
                newAppt.ApptTime = dttmApptTime.Value.TimeOfDay;
                newAppt.Duration = 30;
                newAppt.Description = txtApptDescription.Text;
                newAppt.PatientUserID = loggedInPatient.UserID;
                newAppt.ProviderUserID = loggedInPatient.PCMUserID;
                mms.AddNewAppointment(newAppt);
                MessageBox.Show("Appointment created. Please go to View Appointments tab if you wish to view your appt");
                dtgrdApptDisplay.DataSource = null;
                dtgrdApptDisplay.DataSource = mms.GetPatientAppointments(loggedInUser.UserID);
            }
        }

        private void btnCancelAppt_Click(object sender, EventArgs e)
        {
            lblCancelMessage.Visible = true;
            btnConfirmDelete.Visible = true;
            btnCancelAppt.Visible = false;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            int apptToDeleteID = (int)dtgrdApptDisplay.CurrentRow.Cells[0].Value;
            mms.DeleteAppointment(apptToDeleteID);
            MessageBox.Show("Appointment deleted");
            dtgrdApptDisplay.DataSource = null;
            dtgrdApptDisplay.DataSource = mms.GetPatientAppointments(loggedInUser.UserID);
            lblCancelMessage.Visible = false;
            btnConfirmDelete.Visible = false;
            btnCancelAppt.Visible = true;
        }
    }
}
