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
    public partial class UsrCtrlSignUp : UserControl
    {
        public UsrCtrlSignUp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!FormHome.Instance.HomePanel.Controls.ContainsKey("UsrCtrlHomeMenu")) //if Home user control instance doesn't exit create it
            {
                UsrCtrlHomeMenu uc = new UsrCtrlHomeMenu();   //create a HomeMenu user control object
                FormHome.Instance.HomePanel.Controls.Add(uc);  //Add the object to the list of user controls that can be displayed in home panel
            }
            FormHome.Instance.HomePanel.Controls["UsrCtrlHomeMenu"].BringToFront(); //show the Home menu user control on the home panel
            ClearFields();  //clear the fields in the login user control since we have gone back to home
        }

        /// <summary>
        /// Clears all fields in the Sign Up user control
        /// </summary>
        void ClearFields()
        {
            txtbxUserID.Clear();
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
                btnViewPassword.Text = "Hide";  //change the button text to display "Hide"
            }
            else //if you click when button says hide
            {
                txtbxPassword.PasswordChar = '*'; // make the password hidden by replacing the text with * symbol
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

        }

        private void UsrCtrlSignUp_Load(object sender, EventArgs e)
        {
            cmbxUserType.DataSource = Enum.GetValues(typeof(UserTypes)); //to set possible values for
                                                                         //combobox as all the possible values in the enum UserTypes
            cmbxEmpType.DataSource = Enum.GetValues(typeof(EmpTypes)); //to set possible values for
                                                                         //combobox as all the possible values in the enum EmpTypes
            cmbxSpecialty.DataSource = Enum.GetValues(typeof(Specialties)); //to set possible values for
                                                                         //combobox as all the possible values in the enum Specialties
            

        }
    }
}
