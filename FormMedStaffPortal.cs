using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            loggedInUser = mms.GetEmployee(CurrentLoggedInEmail, out loggedInEmployee);
            //loggedInUser = mms.GetEmployee("Wendy@yahoo.com", out loggedInEmployee);
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
            cmbxSelectViewPatient.DataSource = allPatientStrings;
            cmbxSelectViewPatient.SelectedIndex = -1;
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
                //MMSUser userToUpdate = mms.GetEmployee("Wendy@yahoo.com", out employeeToUpdate);
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
                string userID = Regex.Match(cmbxSelectPatient.Text, "[0-9]+").ToString();
                string filePath = $@"C:\Records\{userID}_{DateTime.Now.ToString("yyyy''MM''dd'_'hhmmtt")}.txt";
                StringBuilder chartNotes = new StringBuilder();
                chartNotes.AppendLine($"PATIENT RECORD CHARTED ON: {DateTime.Now}");
                chartNotes.AppendLine($"CHARTED BY:   UserID: {loggedInUser.UserID}, {loggedInUser.FirstName} {loggedInUser.LastName}, {(EmpTypes)loggedInEmployee.EmpType}");
                chartNotes.AppendLine($"\nVitals: BP: {txtBP.Text}, HR: {txtHR.Text}, RR: {txtRR.Text}, O2: {txtO2.Text}, Temp: {txtTemp.Text}, Pain: {txtPain.Text}");
                chartNotes.AppendLine($"Diagnosis: {txtDiagnosis.Text}\nMedications: {txtMedications.Text}\nAllergies: {txtAllergies.Text}\nNotes: {txtNotes.Text}\n\n");
                BinarySerialize(filePath,chartNotes.ToString());
                ClearChartFields();
            }
        }

        void ClearChartFields()
        {
            txtBP.Clear();
            txtHR.Clear();
            txtRR.Clear();
            txtO2.Clear();
            txtTemp.Clear();
            txtPain.Clear();
            txtDiagnosis.Clear();
            txtMedications.Clear();
            txtAllergies.Clear();
            txtNotes.Clear();
        }

        void BinarySerialize(string filePath, string chartNotes)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.CreateNew, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, chartNotes);  //filestream- where to put serialized, chartNoted- what to serialize
                MessageBox.Show($"Chart saved to file: \"{filePath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

        string BinaryDeserialize(string filePath)
        {
            string contents = null;
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                contents = (string)formatter.Deserialize(fileStream);  //reads from filestream deserializes it and adds it to the string
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
            return contents;
        }

        private void cmbxSelectPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpChart.Visible = true;
        }

        private void cmbxSelectViewPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChartDisplay.ForeColor = System.Drawing.Color.Black;
            txtChartDisplay.Clear();
            string userID = Regex.Match(cmbxSelectViewPatient.Text, "[0-9]+").ToString();
            StringBuilder chartContents = new StringBuilder();
            DirectoryInfo directory = new DirectoryInfo(@"C:\Records\");
            FileInfo[] files = directory.GetFiles();
            bool recordFound = false;
            foreach (FileInfo file in files)
            {
                if (Regex.Match(file.Name, "[0-9]+").ToString() == userID)   //userID in filename matches userID of the patient to be viewed
                                                                            //meaning it is this patient's file
                {
                    recordFound = true;
                    chartContents.Append(BinaryDeserialize($@"{file.Directory}\{file}"));
                }
            }
            txtChartDisplay.Text = chartContents.ToString();
            if(!recordFound)
            {
                txtChartDisplay.ForeColor = System.Drawing.Color.Red;
                txtChartDisplay.Text = "No previous chart records exist for this patient";
            }
        }
    }
}
