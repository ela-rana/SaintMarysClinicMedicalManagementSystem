
namespace SaintMarysClinicMedicalManagementSystem
{
    partial class UsrCtrlSignUp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtbxUserID = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblReenterPassword = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.txtbxReenterPassword = new System.Windows.Forms.TextBox();
            this.tblUserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cmbxUserType = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.tblMoreInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.txtbxSSN = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblEnterDetails = new System.Windows.Forms.Label();
            this.tblPatientInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dttmDOB = new System.Windows.Forms.DateTimePicker();
            this.tblEmployeeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.cmbxEmpType = new System.Windows.Forms.ComboBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.cmbxSpecialty = new System.Windows.Forms.ComboBox();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.btnViewSSN = new System.Windows.Forms.Button();
            this.tblUserInfo.SuspendLayout();
            this.tblMoreInfo.SuspendLayout();
            this.tblPatientInfo.SuspendLayout();
            this.tblEmployeeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Orange;
            this.btnSignUp.Location = new System.Drawing.Point(205, 432);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(133, 25);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Visible = false;
            // 
            // txtbxUserID
            // 
            this.txtbxUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxUserID.Location = new System.Drawing.Point(179, 5);
            this.txtbxUserID.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxUserID.Name = "txtbxUserID";
            this.txtbxUserID.ReadOnly = true;
            this.txtbxUserID.Size = new System.Drawing.Size(283, 22);
            this.txtbxUserID.TabIndex = 2;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbxPassword.Location = new System.Drawing.Point(179, 31);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(275, 22);
            this.txtbxPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(5, 31);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(5, 5);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(164, 15);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "UserID (auto-generated)";
            // 
            // lblReenterPassword
            // 
            this.lblReenterPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblReenterPassword.AutoSize = true;
            this.lblReenterPassword.Location = new System.Drawing.Point(5, 57);
            this.lblReenterPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReenterPassword.Name = "lblReenterPassword";
            this.lblReenterPassword.Size = new System.Drawing.Size(116, 15);
            this.lblReenterPassword.TabIndex = 8;
            this.lblReenterPassword.Text = "Reenter Password";
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(5, 111);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(68, 15);
            this.lblUserType.TabIndex = 10;
            this.lblUserType.Text = "User Type";
            // 
            // txtbxReenterPassword
            // 
            this.txtbxReenterPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbxReenterPassword.Location = new System.Drawing.Point(179, 57);
            this.txtbxReenterPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxReenterPassword.Name = "txtbxReenterPassword";
            this.txtbxReenterPassword.PasswordChar = '*';
            this.txtbxReenterPassword.Size = new System.Drawing.Size(275, 22);
            this.txtbxReenterPassword.TabIndex = 6;
            // 
            // tblUserInfo
            // 
            this.tblUserInfo.ColumnCount = 2;
            this.tblUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.2591F));
            this.tblUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.7409F));
            this.tblUserInfo.Controls.Add(this.txtbxReenterPassword, 1, 2);
            this.tblUserInfo.Controls.Add(this.lblUserType, 0, 4);
            this.tblUserInfo.Controls.Add(this.lblReenterPassword, 0, 2);
            this.tblUserInfo.Controls.Add(this.lblUserID, 0, 0);
            this.tblUserInfo.Controls.Add(this.lblPassword, 0, 1);
            this.tblUserInfo.Controls.Add(this.txtbxPassword, 1, 1);
            this.tblUserInfo.Controls.Add(this.txtbxUserID, 1, 0);
            this.tblUserInfo.Controls.Add(this.cmbxUserType, 1, 4);
            this.tblUserInfo.Controls.Add(this.lblEmail, 0, 3);
            this.tblUserInfo.Controls.Add(this.txtbxEmail, 1, 3);
            this.tblUserInfo.Location = new System.Drawing.Point(44, 31);
            this.tblUserInfo.Margin = new System.Windows.Forms.Padding(5);
            this.tblUserInfo.Name = "tblUserInfo";
            this.tblUserInfo.RowCount = 5;
            this.tblUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblUserInfo.Size = new System.Drawing.Size(467, 133);
            this.tblUserInfo.TabIndex = 5;
            // 
            // cmbxUserType
            // 
            this.cmbxUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUserType.FormattingEnabled = true;
            this.cmbxUserType.Location = new System.Drawing.Point(177, 107);
            this.cmbxUserType.Name = "cmbxUserType";
            this.cmbxUserType.Size = new System.Drawing.Size(287, 23);
            this.cmbxUserType.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 83);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxEmail.Location = new System.Drawing.Point(179, 83);
            this.txtbxEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(283, 22);
            this.txtbxEmail.TabIndex = 20;
            // 
            // tblMoreInfo
            // 
            this.tblMoreInfo.ColumnCount = 2;
            this.tblMoreInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.02208F));
            this.tblMoreInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.97792F));
            this.tblMoreInfo.Controls.Add(this.txtbxPhone, 1, 4);
            this.tblMoreInfo.Controls.Add(this.txtbxSSN, 1, 3);
            this.tblMoreInfo.Controls.Add(this.txtbxLastName, 1, 2);
            this.tblMoreInfo.Controls.Add(this.txtbxMiddleName, 1, 1);
            this.tblMoreInfo.Controls.Add(this.txtbxFirstName, 1, 0);
            this.tblMoreInfo.Controls.Add(this.lblPhone, 0, 4);
            this.tblMoreInfo.Controls.Add(this.lblSSN, 0, 3);
            this.tblMoreInfo.Controls.Add(this.lblLastName, 0, 2);
            this.tblMoreInfo.Controls.Add(this.lblMiddleName, 0, 1);
            this.tblMoreInfo.Controls.Add(this.lblFirstName, 0, 0);
            this.tblMoreInfo.Location = new System.Drawing.Point(45, 191);
            this.tblMoreInfo.Margin = new System.Windows.Forms.Padding(5);
            this.tblMoreInfo.Name = "tblMoreInfo";
            this.tblMoreInfo.RowCount = 5;
            this.tblMoreInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMoreInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMoreInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMoreInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMoreInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tblMoreInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMoreInfo.Size = new System.Drawing.Size(467, 132);
            this.tblMoreInfo.TabIndex = 6;
            this.tblMoreInfo.Visible = false;
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxPhone.Location = new System.Drawing.Point(145, 109);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(317, 22);
            this.txtbxPhone.TabIndex = 22;
            // 
            // txtbxSSN
            // 
            this.txtbxSSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbxSSN.Location = new System.Drawing.Point(145, 83);
            this.txtbxSSN.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxSSN.Name = "txtbxSSN";
            this.txtbxSSN.PasswordChar = '*';
            this.txtbxSSN.Size = new System.Drawing.Size(274, 22);
            this.txtbxSSN.TabIndex = 21;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLastName.Location = new System.Drawing.Point(145, 57);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(317, 22);
            this.txtbxLastName.TabIndex = 20;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMiddleName.Location = new System.Drawing.Point(145, 31);
            this.txtbxMiddleName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(317, 22);
            this.txtbxMiddleName.TabIndex = 19;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFirstName.Location = new System.Drawing.Point(145, 5);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(317, 22);
            this.txtbxFirstName.TabIndex = 18;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(5, 110);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 15);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // lblSSN
            // 
            this.lblSSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(5, 83);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(32, 15);
            this.lblSSN.TabIndex = 16;
            this.lblSSN.Text = "SSN";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(5, 57);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 15);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(5, 31);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(83, 15);
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(5, 5);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 15);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Orange;
            this.btnCreateAccount.Location = new System.Drawing.Point(204, 166);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(133, 27);
            this.btnCreateAccount.TabIndex = 7;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblEnterDetails
            // 
            this.lblEnterDetails.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnterDetails.AutoSize = true;
            this.lblEnterDetails.Font = new System.Drawing.Font("Ink Free", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblEnterDetails.Location = new System.Drawing.Point(42, 171);
            this.lblEnterDetails.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEnterDetails.Name = "lblEnterDetails";
            this.lblEnterDetails.Size = new System.Drawing.Size(157, 15);
            this.lblEnterDetails.TabIndex = 11;
            this.lblEnterDetails.Text = "Enter Additional Details:";
            this.lblEnterDetails.Visible = false;
            // 
            // tblPatientInfo
            // 
            this.tblPatientInfo.ColumnCount = 2;
            this.tblPatientInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.02208F));
            this.tblPatientInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.97792F));
            this.tblPatientInfo.Controls.Add(this.txtbxAddress, 1, 0);
            this.tblPatientInfo.Controls.Add(this.lblAddress, 0, 0);
            this.tblPatientInfo.Controls.Add(this.lblDOB, 0, 1);
            this.tblPatientInfo.Controls.Add(this.dttmDOB, 1, 1);
            this.tblPatientInfo.Location = new System.Drawing.Point(45, 320);
            this.tblPatientInfo.Margin = new System.Windows.Forms.Padding(5);
            this.tblPatientInfo.Name = "tblPatientInfo";
            this.tblPatientInfo.RowCount = 2;
            this.tblPatientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPatientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPatientInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPatientInfo.Size = new System.Drawing.Size(467, 53);
            this.tblPatientInfo.TabIndex = 15;
            this.tblPatientInfo.Visible = false;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAddress.Location = new System.Drawing.Point(145, 5);
            this.txtbxAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(317, 22);
            this.txtbxAddress.TabIndex = 22;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(5, 5);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(127, 15);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Full Mailing Address";
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(5, 32);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(91, 15);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date of Birth";
            // 
            // dttmDOB
            // 
            this.dttmDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dttmDOB.Location = new System.Drawing.Point(143, 29);
            this.dttmDOB.Name = "dttmDOB";
            this.dttmDOB.Size = new System.Drawing.Size(321, 22);
            this.dttmDOB.TabIndex = 24;
            // 
            // tblEmployeeInfo
            // 
            this.tblEmployeeInfo.ColumnCount = 2;
            this.tblEmployeeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.02208F));
            this.tblEmployeeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.97792F));
            this.tblEmployeeInfo.Controls.Add(this.cmbxEmpType, 1, 0);
            this.tblEmployeeInfo.Controls.Add(this.lblSpecialty, 0, 1);
            this.tblEmployeeInfo.Controls.Add(this.cmbxSpecialty, 1, 1);
            this.tblEmployeeInfo.Controls.Add(this.lblEmpType, 0, 0);
            this.tblEmployeeInfo.Location = new System.Drawing.Point(45, 371);
            this.tblEmployeeInfo.Margin = new System.Windows.Forms.Padding(5);
            this.tblEmployeeInfo.Name = "tblEmployeeInfo";
            this.tblEmployeeInfo.RowCount = 2;
            this.tblEmployeeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEmployeeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblEmployeeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEmployeeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEmployeeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEmployeeInfo.Size = new System.Drawing.Size(467, 56);
            this.tblEmployeeInfo.TabIndex = 16;
            this.tblEmployeeInfo.Visible = false;
            // 
            // cmbxEmpType
            // 
            this.cmbxEmpType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxEmpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmpType.FormattingEnabled = true;
            this.cmbxEmpType.Location = new System.Drawing.Point(143, 3);
            this.cmbxEmpType.Name = "cmbxEmpType";
            this.cmbxEmpType.Size = new System.Drawing.Size(321, 23);
            this.cmbxEmpType.TabIndex = 20;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(5, 34);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(111, 15);
            this.lblSpecialty.TabIndex = 10;
            this.lblSpecialty.Text = "Specialty (if any)";
            // 
            // cmbxSpecialty
            // 
            this.cmbxSpecialty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSpecialty.FormattingEnabled = true;
            this.cmbxSpecialty.Location = new System.Drawing.Point(143, 31);
            this.cmbxSpecialty.Name = "cmbxSpecialty";
            this.cmbxSpecialty.Size = new System.Drawing.Size(321, 23);
            this.cmbxSpecialty.TabIndex = 19;
            // 
            // lblEmpType
            // 
            this.lblEmpType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpType.AutoSize = true;
            this.lblEmpType.Location = new System.Drawing.Point(5, 6);
            this.lblEmpType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(94, 15);
            this.lblEmpType.TabIndex = 21;
            this.lblEmpType.Text = "Employee Type";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 26);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.BackColor = System.Drawing.Color.Orange;
            this.btnViewPassword.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPassword.Location = new System.Drawing.Point(467, 60);
            this.btnViewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(43, 50);
            this.btnViewPassword.TabIndex = 18;
            this.btnViewPassword.Text = "View";
            this.btnViewPassword.UseVisualStyleBackColor = false;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // btnViewSSN
            // 
            this.btnViewSSN.BackColor = System.Drawing.Color.Orange;
            this.btnViewSSN.Font = new System.Drawing.Font("Dubai", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSSN.Location = new System.Drawing.Point(468, 272);
            this.btnViewSSN.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewSSN.Name = "btnViewSSN";
            this.btnViewSSN.Size = new System.Drawing.Size(43, 24);
            this.btnViewSSN.TabIndex = 19;
            this.btnViewSSN.Text = "View\r\n";
            this.btnViewSSN.UseVisualStyleBackColor = false;
            this.btnViewSSN.Visible = false;
            this.btnViewSSN.Click += new System.EventHandler(this.btnViewSSN_Click);
            // 
            // UsrCtrlSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.btnViewSSN);
            this.Controls.Add(this.btnViewPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tblEmployeeInfo);
            this.Controls.Add(this.tblPatientInfo);
            this.Controls.Add(this.lblEnterDetails);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.tblMoreInfo);
            this.Controls.Add(this.tblUserInfo);
            this.Controls.Add(this.btnSignUp);
            this.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsrCtrlSignUp";
            this.Size = new System.Drawing.Size(560, 540);
            this.Load += new System.EventHandler(this.UsrCtrlSignUp_Load);
            this.tblUserInfo.ResumeLayout(false);
            this.tblUserInfo.PerformLayout();
            this.tblMoreInfo.ResumeLayout(false);
            this.tblMoreInfo.PerformLayout();
            this.tblPatientInfo.ResumeLayout(false);
            this.tblPatientInfo.PerformLayout();
            this.tblEmployeeInfo.ResumeLayout(false);
            this.tblEmployeeInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtbxUserID;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblReenterPassword;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox txtbxReenterPassword;
        private System.Windows.Forms.TableLayoutPanel tblUserInfo;
        private System.Windows.Forms.ComboBox cmbxUserType;
        private System.Windows.Forms.TableLayoutPanel tblMoreInfo;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.TextBox txtbxSSN;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxMiddleName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.Label lblEnterDetails;
        private System.Windows.Forms.TableLayoutPanel tblPatientInfo;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dttmDOB;
        private System.Windows.Forms.TableLayoutPanel tblEmployeeInfo;
        private System.Windows.Forms.ComboBox cmbxEmpType;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.ComboBox cmbxSpecialty;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewPassword;
        private System.Windows.Forms.Button btnViewSSN;
    }
}
