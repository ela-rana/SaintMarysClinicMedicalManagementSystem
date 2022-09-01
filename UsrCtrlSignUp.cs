using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SaintMarysClinicMedicalManagementSystem
{
    public partial class UsrCtrlSignUp : UserControl
    {
        MMSCRUD mms;    //class object that represents the database CRUD/Find functionality
        public UsrCtrlSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //if (!FormHome.Instance.HomePanel.Controls.ContainsKey("UsrCtrlHomeMenu")) //if Home user control instance doesn't exit create it
            //{
            //    UsrCtrlHomeMenu uc = new UsrCtrlHomeMenu();   //create a HomeMenu user control object
            //    FormHome.Instance.HomePanel.Controls.Add(uc);  //Add the object to the list of user controls that can be displayed in home panel
            //}
            FormHome.Instance.HomePanel.Controls["UsrCtrlHomeMenu"].BringToFront(); //show the Home menu user control on the home panel
            ResetFields();  //clear the fields and reset visibilty in the login user control since we have gone back to home
        }

        /// <summary>
        /// Clears all fields in the Sign Up user control and reset which form items are visible and which are not
        /// </summary>
        void ResetFields()
        {
            tblUserInfo.Visible = true;
            btnViewPassword.Visible = true;
            btnCreateAccount.Visible = true;
            tblMoreInfo.Visible = false;
            tblEmployeeInfo.Visible = false;
            tblPatientInfo.Visible = false;
            btnViewSSN.Visible = false;
            btnSignUp.Visible = false;
            lblEnterDetails.Visible = false;
            lblError.Visible = false;

            txtbxPassword.Clear();
            txtbxReenterPassword.Clear();
            txtbxEmail.Clear();
            cmbxUserType.SelectedIndex = -1;
            txtbxFirstName.Clear();
            txtbxMiddleName.Clear();
            txtbxLastName.Clear();
            txtbxSSN.Clear();
            txtbxPhone.Clear();
            txtbxAddress.Clear();
            dttmDOB.Value = DateTime.Today;
            cmbxEmpType.SelectedIndex = -1;
            cmbxSpecialty.SelectedIndex = -1;
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (btnViewPassword.Text == "View")     //if you click the button while it says view
            {
                txtbxPassword.PasswordChar = '\0';  // make the password viewable instead of being represented as * symbol
                txtbxReenterPassword.PasswordChar = '\0'; //same for Reenter password textbox
                btnViewPassword.Text = "Hide";  //change the button text to display "Hide"
            }
            else //if you click when button says hide
            {
                txtbxPassword.PasswordChar = '*'; // make the password hidden by replacing the text with * symbol
                txtbxReenterPassword.PasswordChar = '*'; //same for Reenter password textbox
                btnViewPassword.Text = "View"; //change the button text to display "View"
            }

        }

        private void btnViewSSN_Click(object sender, EventArgs e)
        {
            if (btnViewSSN.Text == "View")     //if you click the button while it says view
            {
                txtbxSSN.PasswordChar = '\0';  // make the SSN viewable instead of being represented as * symbol
                btnViewSSN.Text = "Hide";  //change the button text to display "Hide"
            }
            else //if you click when button says hide
            {
                txtbxSSN.PasswordChar = '*'; // make the SSN hidden by replacing the text with * symbol
                btnViewSSN.Text = "View"; //change the button text to display "View"
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtbxEmail.TextLength > 0 && txtbxPassword.TextLength > 0 && txtbxPassword.TextLength > 0 && cmbxUserType.SelectedIndex != -1 )
            {
                tblUserInfo.Visible = false;
                btnCreateAccount.Visible = false;
                btnViewPassword.Visible = false;

                tblMoreInfo.Visible = true;
                lblEnterDetails.Visible = true;
                btnViewSSN.Visible = true;
                btnSignUp.Visible = true;
                switch (cmbxUserType.SelectedIndex)
                {
                    case 0:
                        tblPatientInfo.Visible = true;
                        break;
                    case 1:
                    case 2:
                        tblEmployeeInfo.Visible = true;
                        break;
                }
            }
            else
            {
                ErrorMessageTask("All fields must be filled and user type must be selected\n from dropdown menu");
            }
        }

        private void UsrCtrlSignUp_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();

            cmbxUserType.DataSource = Enum.GetValues(typeof(UserTypes)); //to set possible values for
                                                                         //combobox as all the possible values in the enum UserTypes
            cmbxEmpType.DataSource = Enum.GetValues(typeof(EmpTypes)); //to set possible values for
                                                                         //combobox as all the possible values in the enum EmpTypes
            cmbxSpecialty.DataSource = Enum.GetValues(typeof(Specialties)); //to set possible values for
                                                                            //combobox as all the possible values in the enum Specialties
            //to set the comboboxes to display blank (no selections) at beginning
            cmbxUserType.SelectedIndex = -1;
            cmbxEmpType.SelectedIndex = -1;
            cmbxSpecialty.SelectedIndex = -1;
        }

        /// <summary>
        /// To ensure a valid value is entered in the Email textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxEmail.TextLength != 0 && txtbxEmail.TextLength < 7 || txtbxEmail.TextLength > 50)
            {
                txtbxEmail.Clear();
                ErrorMessageTask("Email must be 6 to 50 characters long");
            }
            if (mms.emailAlreadyExists(txtbxEmail.Text))
            {
                txtbxEmail.Clear();
                ErrorMessageTask("This email already exists in our records. Please\nreenter or click back then login if you already have an account");
            }
        }

        /// <summary>
        /// Displays a passed string as an error message on a label
        /// </summary>
        /// <param name="errorMessage">a string that needs to be displayed as error message</param>
        public void ErrorMessageTask(string errorMessage)
        {
            lblError.Visible = true;   //makes the error message label visible
            SystemSounds.Beep.Play();   //plays an alert sound to notify user of the error
            lblError.Text = errorMessage;  //displays the error message in the label
        }

        /// <summary>
        /// To ensure a valid value is entered in the Password textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxPassword.TextLength != 0 && txtbxPassword.TextLength < 3 || txtbxPassword.TextLength > 50)
            {
                txtbxPassword.Clear();
                ErrorMessageTask("Password must be 3 to 50 characters long");
            }
        }
        private void txtbxReenterPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtbxPassword.Text != txtbxReenterPassword.Text)
            {
                txtbxReenterPassword.Clear();
                ErrorMessageTask("Reentered password doesn't match original entered password");
            }
        }

        private void AnyField_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool allFieldsFilled = false;
            if (txtbxFirstName.TextLength > 0 && txtbxLastName.TextLength > 0 &&
                txtbxSSN.TextLength > 0 && txtbxPhone.TextLength > 0)
            {
                allFieldsFilled = true;
            }
            if(cmbxUserType.SelectedIndex == 0 && (DateTime)dttmDOB.Value.Date == DateTime.Today)
            {
                if (MessageBox.Show("You have put today's date as date of birth.\nAre you sure that it correct",
                    "Caution", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

            }
            if (cmbxUserType.SelectedIndex == 0 && txtbxAddress.TextLength == 0)
                allFieldsFilled = false;
            if (cmbxUserType.SelectedIndex > 0 && cmbxEmpType.SelectedIndex < 0)
                allFieldsFilled = false;

            if(allFieldsFilled)
            {
                MMSUser u = new MMSUser();
                u.UserID = mms.MaxUserID() + 1;
                u.Passwrd = txtbxPassword.Text;
                u.SSN = txtbxSSN.Text;
                u.FirstName = txtbxFirstName.Text;
                u.MiddleName = txtbxMiddleName.Text;
                u.LastName = txtbxLastName.Text;
                u.Phone = txtbxPhone.Text;
                u.Email = txtbxEmail.Text;
                u.UserType = cmbxUserType.SelectedIndex + 1;
                
                switch (cmbxUserType.SelectedIndex)
                {
                    case 0:
                        Patient p = new Patient();
                        p.UserID = u.UserID;
                        p.DOB = (DateTime)dttmDOB.Value.Date;
                        p.Address = txtbxAddress.Text;
                        p.PCMUserID = 2;
                        mms.AddNewPatient(u, p);
                        break;
                    case 1:
                    case 2:
                        Employee emp = new Employee();
                        emp.UserID = u.UserID;
                        emp.EmpType = cmbxEmpType.SelectedIndex + 1;
                        if (cmbxSpecialty.Text == "")
                            emp.Specialty = null;
                        else
                            emp.Specialty = cmbxSpecialty.Text;
                        mms.AddNewEmployee(u, emp);
                        break;
                }
                MessageBox.Show("Account created.\nReturning home...\n\nClick Login to sign in to your newly created account");
                FormHome.Instance.HomePanel.Controls["UsrCtrlHomeMenu"].BringToFront(); //show the Home menu user control on the home panel
                ResetFields();  //clear the fields and reset visibilty in the login user control since we have gone back to home


            }
            else
            {
                ErrorMessageTask("All fields must be filled");
            }
        }
    }
}
