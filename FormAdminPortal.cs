using System;
using System.Windows.Forms;

namespace SaintMarysClinicMedicalManagementSystem
{
    public partial class FormAdminPortal : Form
    {
        MMSCRUD mms;
        Employee loggedInEmployee;
        MMSUser loggedInUser;
        public static FormAdminPortal instance;
        public TextBox TxtBxPatientID
        {
            get { return txtbxPatient; }
            set { txtbxPatient = value; }
        }

        public TextBox TxtBxProviderID
        {
            get { return txtbxProvider; }
            set { txtbxProvider = value; }
        }

        public string CurrentLoggedInEmail { get; set; }
        public FormAdminPortal()
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

        private void FormAdminPortal_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            loggedInUser = mms.GetEmployee(CurrentLoggedInEmail, out loggedInEmployee);
            //loggedInUser = mms.GetEmployee("elarana@mssa.unitedtraining.com", out loggedInEmployee);
            txtbxFirstName.Text = loggedInUser.FirstName;
            txtbxMiddleName.Text = loggedInUser.MiddleName;
            txtbxLastName.Text = loggedInUser.LastName;
            txtbxPhone.Text = loggedInUser.Phone;
            txtbxSSN.Text = loggedInUser.SSN;
            RefreshGrid();
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
                MMSUser userToUpdate = mms.GetEmployee(CurrentLoggedInEmail, out employeeToUpdate);
                //MMSUser userToUpdate = mms.GetEmployee("elarana@mssa.unitedtraining.com", out employeeToUpdate);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int apptToDeleteID = (int)dtgrdApptDisplay.CurrentRow.Cells[0].Value;
            mms.DeleteAppointment(apptToDeleteID);
            MessageBox.Show("Appointment deleted");
            dtgrdApptDisplay.DataSource = null;
            dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int apID;
            bool parsed = Int32.TryParse(dtgrdApptDisplay.CurrentRow.Cells[0].Value.ToString(),out apID);
            if(parsed)
            {
                mms.VerifyAppointment(apID);
                MessageBox.Show("Appointment Verified");
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Error: Please ensure the appt to verify is selected in grid");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int apID;
            bool parsed = Int32.TryParse(dtgrdApptDisplay.CurrentRow.Cells[0].Value.ToString(), out apID);
            if (parsed)
            {
                dtgrdApptDisplay.Enabled = false;
                grpFields.Visible = true;
                btnConfirmEdit.Visible = true;
                btnCancelEdit.Visible = true;
                Appointment ap = mms.GetAppointment(apID);
                dttmApptDate.Value = ap.ApptDate.Date;
                dttmApptTime.Value = new DateTime(2022, 1, 1, ap.ApptTime.Hours, ap.ApptTime.Minutes, 0);
                txtApptDescription.Text = ap.Description;
                if (ap.Duration == 30)
                    cmbbxDuration.SelectedIndex = 0;
                else
                    cmbbxDuration.SelectedIndex = 1;
                txtbxPatient.Text = ap.PatientUserID.ToString();
                txtbxProvider.Text = ap.ProviderUserID.ToString();
            }
            else
            {
                MessageBox.Show("Error: Please ensure the appt to verify is selected in grid");
            }
        }

        void RefreshGrid()
        {
            dtgrdApptDisplay.DataSource = null;
            dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
            dtgrdApptDisplay.Columns[8].Visible = false;
            dtgrdApptDisplay.Columns[9].Visible = false;
        }
        private void btnAddAppt_Click(object sender, EventArgs e)
        {
            RefreshApptFields();
            grpFields.Visible = true;
            btnConfirmAdd.Visible = true;
            btnCancelAdd.Visible = true;
        }

        void RefreshApptFields()
        {
            dttmApptDate.Value = DateTime.Today;
            dttmApptTime.Value = DateTime.Now;
            txtApptDescription.Clear();
            txtbxPatient.Clear();
            txtbxProvider.Clear();
            cmbbxDuration.SelectedIndex = 0;
        }
        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            Appointment a = mms.GetAppointment(Int32.Parse(dtgrdApptDisplay.CurrentRow.Cells[0].Value.ToString()));
            a.ApptDate = dttmApptDate.Value.Date;
            a.ApptTime = dttmApptTime.Value.TimeOfDay;
            a.Description = txtApptDescription.Text;
            a.PatientUserID = Int32.Parse(txtbxPatient.Text);
            a.ProviderUserID = Int32.Parse(txtbxProvider.Text);
            if (cmbbxDuration.SelectedIndex == 0)
                a.Duration = 30;
            else
                a.Duration = 60;
            mms.UpdateAppointment(a);
            MessageBox.Show("Appointment Updated");
            RefreshGrid();
            dtgrdApptDisplay.Enabled = true;
            grpFields.Visible = false;
            btnConfirmEdit.Visible = false;
            btnCancelEdit.Visible = false;
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            if (txtbxPatient.TextLength > 0 && txtbxProvider.TextLength > 0)
            {
                Appointment newAppt = new Appointment();
                newAppt.ApptID = mms.MaxApptID() + 1;
                newAppt.ApptDate = dttmApptDate.Value.Date;
                newAppt.ApptTime = dttmApptTime.Value.TimeOfDay;
                if (cmbbxDuration.SelectedIndex == 0)
                    newAppt.Duration = 30;
                else
                    newAppt.Duration = 60;
                newAppt.Description = txtApptDescription.Text;
                newAppt.PatientUserID = Int32.Parse(txtbxPatient.Text);
                newAppt.ProviderUserID = Int32.Parse(txtbxProvider.Text);
                mms.AddNewAppointment(newAppt);
                MessageBox.Show("Appointment created");
                RefreshGrid();
                grpFields.Visible = false;
                btnConfirmAdd.Visible = false;
                btnCancelAdd.Visible = false;
            }
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

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            grpFields.Visible = false;
            dtgrdApptDisplay.Enabled = true;
            btnConfirmEdit.Visible = false;
            btnCancelEdit.Visible = false;
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            grpFields.Visible = false;
            btnConfirmAdd.Visible = false;
            btnCancelAdd.Visible = false;
        }
    }
}
