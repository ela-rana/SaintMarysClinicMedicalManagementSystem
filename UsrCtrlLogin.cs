using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;

namespace SaintMarysClinicMedicalManagementSystem
{
    public partial class UsrCtrlLogin : UserControl
    {
        MMSCRUD mms;    //class object that represents the database CRUD/Find functionality
        public UsrCtrlLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;  //to remove any previous error messages
            if(txtbxEmail.TextLength != 0 && txtbxPassword.TextLength != 0)
            {
                Nullable<UserTypes> type = mms.ValidLogin(txtbxEmail.Text, txtbxPassword.Text);
                if (type != null)
                {
                    switch((int)type)
                    {
                        case 1:
                            FormPatientPortal formPatientPortal = new FormPatientPortal();
                            formPatientPortal.CurrentLoggedInEmail = txtbxEmail.Text;
                            formPatientPortal.Show();
                            break;
                        case 2:
                            FormMedStaffPortal formMedStaffPortal = new FormMedStaffPortal();
                            formMedStaffPortal.Show();
                            break;
                        case 3:
                            FormAdminPortal formAdminPortal = new FormAdminPortal();
                            formAdminPortal.Show();
                            break;
                    }
                    this.ParentForm.Hide();
                }
                else
                {
                    ErrorMessageTask("This is not the correct password\nfor this email account. Please\nrecheck email and password.");
                }
            }
            else
            {
                ErrorMessageTask("Both fields must be filled");
            }
        }

        /// <summary>
        /// Event handler to handle returning to Home user control when the back button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!FormHome.Instance.HomePanel.Controls.ContainsKey("UsrCtrlHomeMenu")) //if Home user control instance doesn't exit create it
            {
                UsrCtrlHomeMenu uc = new UsrCtrlHomeMenu();   //create a HomeMenu user control object
                FormHome.Instance.HomePanel.Controls.Add(uc);  //Add the object to the list of user controls that can be displayed in home panel
            }
            FormHome.Instance.HomePanel.Controls["UsrCtrlHomeMenu"].BringToFront(); //show the Home menu user control on the home panel
            txtbxEmail.Clear(); //clear the fields in the login user control since we have gone back to home
            txtbxPassword.Clear();
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
                ErrorMessageTask("Email must be 6 to 50\ncharacters long");
            }
            if(!mms.emailAlreadyExists(txtbxEmail.Text))
            {
                txtbxEmail.Clear();
                ErrorMessageTask("This email does not exist\nin our records. Please\nreenter or click back then sign up\nto create a new account");
            }
        }

        /// <summary>
        /// Displays a passed string as an error message on a label
        /// </summary>
        /// <param name="errorMessage">a string that needs to be displayed as error message</param>
        public void ErrorMessageTask(string errorMessage)
        {
            lblErrorLogin.Visible = true;   //makes the error message label visible
            SystemSounds.Beep.Play();   //plays an alert sound to notify user of the error
            lblErrorLogin.Text = errorMessage;  //displays the error message in the label
        }

        /// <summary>
        /// To ensure a valid value is entered in the Password textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxPassword.TextLength!=0 && txtbxPassword.TextLength < 3 || txtbxPassword.TextLength > 50)
            {
                txtbxPassword.Clear();
                ErrorMessageTask("Password must be 3 to 50\ncharacters long");
            }
        }

        private void UsrCtrlLogin_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
        }

        /// <summary>
        /// Hides or shows password when button is clicked and changes the text of the button to toggle between hide and view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;  //to remove any previous error messages
            if (btnViewPassword.Text == "View")     //if you click the button while it says view
            {
                txtbxPassword.PasswordChar = '\0';  // make the password viewable instead of being represented as * symbol
                btnViewPassword.Text = "Hide";  //change the button text to display "Hide"
            }
            else //if you click when button says hide
            {
                txtbxPassword.PasswordChar = '*'; // make the password hidden by replacing the text with * symbol
                btnViewPassword.Text = "View"; //change the button text to display "View"
            }
        }
    }
}
