
namespace SaintMarysClinicMedicalManagementSystem
{
    partial class FormAdminPortal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPortal));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProfile = new System.Windows.Forms.TabPage();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblUpdateInstructions = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbViewAppointment = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrdApptDisplay = new System.Windows.Forms.DataGridView();
            this.txtbxSSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnAddAppt = new System.Windows.Forms.Button();
            this.txtApptDescription = new System.Windows.Forms.TextBox();
            this.lblApptDescription = new System.Windows.Forms.Label();
            this.lblApptTime = new System.Windows.Forms.Label();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.dttmApptTime = new System.Windows.Forms.DateTimePicker();
            this.dttmApptDate = new System.Windows.Forms.DateTimePicker();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtbxPatient = new System.Windows.Forms.TextBox();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.txtbxProvider = new System.Windows.Forms.TextBox();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.cmbbxDuration = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbProfile.SuspendLayout();
            this.tbViewAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(532, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(102, 35);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProfile);
            this.tabControl1.Controls.Add(this.tbViewAppointment);
            this.tabControl1.Location = new System.Drawing.Point(13, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 573);
            this.tabControl1.TabIndex = 5;
            // 
            // tbProfile
            // 
            this.tbProfile.Controls.Add(this.txtbxSSN);
            this.tbProfile.Controls.Add(this.label1);
            this.tbProfile.Controls.Add(this.btnSaveChanges);
            this.tbProfile.Controls.Add(this.lblUpdateInstructions);
            this.tbProfile.Controls.Add(this.btnUpdate);
            this.tbProfile.Controls.Add(this.txtbxPhone);
            this.tbProfile.Controls.Add(this.txtbxLastName);
            this.tbProfile.Controls.Add(this.txtbxMiddleName);
            this.tbProfile.Controls.Add(this.txtbxFirstName);
            this.tbProfile.Controls.Add(this.lblFirstName);
            this.tbProfile.Controls.Add(this.lblPhone);
            this.tbProfile.Controls.Add(this.lblMiddleName);
            this.tbProfile.Controls.Add(this.lblLastName);
            this.tbProfile.Location = new System.Drawing.Point(4, 28);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(879, 541);
            this.tbProfile.TabIndex = 2;
            this.tbProfile.Text = "My Profile";
            this.tbProfile.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(197, 349);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(167, 28);
            this.btnSaveChanges.TabIndex = 43;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblUpdateInstructions
            // 
            this.lblUpdateInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUpdateInstructions.AutoSize = true;
            this.lblUpdateInstructions.Font = new System.Drawing.Font("Papyrus", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblUpdateInstructions.ForeColor = System.Drawing.Color.Crimson;
            this.lblUpdateInstructions.Location = new System.Drawing.Point(77, 291);
            this.lblUpdateInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateInstructions.Name = "lblUpdateInstructions";
            this.lblUpdateInstructions.Size = new System.Drawing.Size(552, 21);
            this.lblUpdateInstructions.TabIndex = 42;
            this.lblUpdateInstructions.Text = "Update all fields that you wish to above and then click the Save Changes button";
            this.lblUpdateInstructions.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(558, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 28);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxPhone.Enabled = false;
            this.txtbxPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.Location = new System.Drawing.Point(226, 159);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(265, 23);
            this.txtbxPhone.TabIndex = 29;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.Location = new System.Drawing.Point(226, 131);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(265, 23);
            this.txtbxLastName.TabIndex = 27;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMiddleName.Enabled = false;
            this.txtbxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMiddleName.Location = new System.Drawing.Point(226, 102);
            this.txtbxMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(265, 23);
            this.txtbxMiddleName.TabIndex = 26;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.Location = new System.Drawing.Point(226, 72);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(265, 23);
            this.txtbxFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(92, 72);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(99, 20);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(92, 159);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(92, 101);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(114, 20);
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(92, 131);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 20);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // tbViewAppointment
            // 
            this.tbViewAppointment.Controls.Add(this.cmbbxDuration);
            this.tbViewAppointment.Controls.Add(this.lblDuration);
            this.tbViewAppointment.Controls.Add(this.txtbxProvider);
            this.tbViewAppointment.Controls.Add(this.lblProvider);
            this.tbViewAppointment.Controls.Add(this.btnConfirmAdd);
            this.tbViewAppointment.Controls.Add(this.txtbxPatient);
            this.tbViewAppointment.Controls.Add(this.lblPatient);
            this.tbViewAppointment.Controls.Add(this.txtApptDescription);
            this.tbViewAppointment.Controls.Add(this.lblApptDescription);
            this.tbViewAppointment.Controls.Add(this.lblApptTime);
            this.tbViewAppointment.Controls.Add(this.lblApptDate);
            this.tbViewAppointment.Controls.Add(this.dttmApptTime);
            this.tbViewAppointment.Controls.Add(this.dttmApptDate);
            this.tbViewAppointment.Controls.Add(this.btnAddAppt);
            this.tbViewAppointment.Controls.Add(this.btnEdit);
            this.tbViewAppointment.Controls.Add(this.btnConfirmEdit);
            this.tbViewAppointment.Controls.Add(this.btnVerify);
            this.tbViewAppointment.Controls.Add(this.btnDelete);
            this.tbViewAppointment.Controls.Add(this.label7);
            this.tbViewAppointment.Controls.Add(this.lblMessage);
            this.tbViewAppointment.Controls.Add(this.label3);
            this.tbViewAppointment.Controls.Add(this.dtgrdApptDisplay);
            this.tbViewAppointment.Location = new System.Drawing.Point(4, 28);
            this.tbViewAppointment.Name = "tbViewAppointment";
            this.tbViewAppointment.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbViewAppointment.Size = new System.Drawing.Size(879, 541);
            this.tbViewAppointment.TabIndex = 1;
            this.tbViewAppointment.Text = "View Appointments";
            this.tbViewAppointment.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(17, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(547, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Here are your appointments: (If display is blank, then you have no appts)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "APPOINTMENTS DISPLAY\r\n";
            // 
            // dtgrdApptDisplay
            // 
            this.dtgrdApptDisplay.BackgroundColor = System.Drawing.Color.Thistle;
            this.dtgrdApptDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdApptDisplay.Location = new System.Drawing.Point(20, 53);
            this.dtgrdApptDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgrdApptDisplay.Name = "dtgrdApptDisplay";
            this.dtgrdApptDisplay.Size = new System.Drawing.Size(478, 439);
            this.dtgrdApptDisplay.TabIndex = 0;
            // 
            // txtbxSSN
            // 
            this.txtbxSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxSSN.Enabled = false;
            this.txtbxSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSSN.Location = new System.Drawing.Point(226, 190);
            this.txtbxSSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSSN.Name = "txtbxSSN";
            this.txtbxSSN.Size = new System.Drawing.Size(265, 23);
            this.txtbxSSN.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "SSN";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(536, 191);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected Appt";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(533, 68);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(335, 68);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Select an appt on the Appointments Display \r\nand click Verify Appointment below t" +
    "o \r\napprove that appt request, Delete to cancel \r\nthe appt, or edit to update it" +
    "\r\n";
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVerify.Location = new System.Drawing.Point(536, 160);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(216, 25);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify Selected Appt";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(536, 222);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(216, 25);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Selected Appt";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmEdit.Location = new System.Drawing.Point(536, 500);
            this.btnConfirmEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(125, 25);
            this.btnConfirmEdit.TabIndex = 7;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddAppt
            // 
            this.btnAddAppt.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAppt.Location = new System.Drawing.Point(536, 253);
            this.btnAddAppt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddAppt.Name = "btnAddAppt";
            this.btnAddAppt.Size = new System.Drawing.Size(216, 25);
            this.btnAddAppt.TabIndex = 9;
            this.btnAddAppt.Text = "Add New Appt";
            this.btnAddAppt.UseVisualStyleBackColor = true;
            // 
            // txtApptDescription
            // 
            this.txtApptDescription.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtApptDescription.Location = new System.Drawing.Point(607, 349);
            this.txtApptDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtApptDescription.Multiline = true;
            this.txtApptDescription.Name = "txtApptDescription";
            this.txtApptDescription.Size = new System.Drawing.Size(265, 50);
            this.txtApptDescription.TabIndex = 15;
            // 
            // lblApptDescription
            // 
            this.lblApptDescription.AutoSize = true;
            this.lblApptDescription.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApptDescription.Location = new System.Drawing.Point(504, 353);
            this.lblApptDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDescription.Name = "lblApptDescription";
            this.lblApptDescription.Size = new System.Drawing.Size(75, 13);
            this.lblApptDescription.TabIndex = 14;
            this.lblApptDescription.Text = "Description:";
            // 
            // lblApptTime
            // 
            this.lblApptTime.AutoSize = true;
            this.lblApptTime.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApptTime.Location = new System.Drawing.Point(504, 323);
            this.lblApptTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptTime.Name = "lblApptTime";
            this.lblApptTime.Size = new System.Drawing.Size(67, 13);
            this.lblApptTime.TabIndex = 13;
            this.lblApptTime.Text = "Appt Time:";
            // 
            // lblApptDate
            // 
            this.lblApptDate.AutoSize = true;
            this.lblApptDate.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApptDate.Location = new System.Drawing.Point(504, 288);
            this.lblApptDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(67, 13);
            this.lblApptDate.TabIndex = 12;
            this.lblApptDate.Text = "Appt Date:";
            // 
            // dttmApptTime
            // 
            this.dttmApptTime.CustomFormat = "hh:mm";
            this.dttmApptTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dttmApptTime.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.dttmApptTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmApptTime.Location = new System.Drawing.Point(607, 317);
            this.dttmApptTime.Margin = new System.Windows.Forms.Padding(4);
            this.dttmApptTime.Name = "dttmApptTime";
            this.dttmApptTime.Size = new System.Drawing.Size(265, 20);
            this.dttmApptTime.TabIndex = 11;
            this.dttmApptTime.Value = new System.DateTime(2022, 9, 1, 9, 0, 0, 0);
            // 
            // dttmApptDate
            // 
            this.dttmApptDate.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.dttmApptDate.Location = new System.Drawing.Point(607, 289);
            this.dttmApptDate.Margin = new System.Windows.Forms.Padding(4);
            this.dttmApptDate.Name = "dttmApptDate";
            this.dttmApptDate.Size = new System.Drawing.Size(266, 20);
            this.dttmApptDate.TabIndex = 10;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPatient.Location = new System.Drawing.Point(504, 415);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(50, 13);
            this.lblPatient.TabIndex = 16;
            this.lblPatient.Text = "Patient:";
            // 
            // txtbxPatient
            // 
            this.txtbxPatient.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbxPatient.Location = new System.Drawing.Point(607, 411);
            this.txtbxPatient.Name = "txtbxPatient";
            this.txtbxPatient.Size = new System.Drawing.Size(266, 20);
            this.txtbxPatient.TabIndex = 17;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmAdd.Location = new System.Drawing.Point(665, 500);
            this.btnConfirmAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(125, 25);
            this.btnConfirmAdd.TabIndex = 18;
            this.btnConfirmAdd.Text = "Confirm Add";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // txtbxProvider
            // 
            this.txtbxProvider.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtbxProvider.Location = new System.Drawing.Point(606, 437);
            this.txtbxProvider.Name = "txtbxProvider";
            this.txtbxProvider.Size = new System.Drawing.Size(266, 20);
            this.txtbxProvider.TabIndex = 20;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProvider.Location = new System.Drawing.Point(503, 441);
            this.lblProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(58, 13);
            this.lblProvider.TabIndex = 19;
            this.lblProvider.Text = "Provider:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDuration.Location = new System.Drawing.Point(503, 467);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(57, 13);
            this.lblDuration.TabIndex = 21;
            this.lblDuration.Text = "Duration";
            // 
            // cmbbxDuration
            // 
            this.cmbbxDuration.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmbbxDuration.FormattingEnabled = true;
            this.cmbbxDuration.Location = new System.Drawing.Point(606, 463);
            this.cmbbxDuration.Name = "cmbbxDuration";
            this.cmbbxDuration.Size = new System.Drawing.Size(266, 21);
            this.cmbbxDuration.TabIndex = 22;
            // 
            // FormAdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(914, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogOut);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Harrington", 12.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormAdminPortal";
            this.Text = "Saint Mary\'s Clinic - Admin Portal";
            this.Load += new System.EventHandler(this.FormAdminPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbProfile.ResumeLayout(false);
            this.tbProfile.PerformLayout();
            this.tbViewAppointment.ResumeLayout(false);
            this.tbViewAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbProfile;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblUpdateInstructions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxMiddleName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TabPage tbViewAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgrdApptDisplay;
        private System.Windows.Forms.TextBox txtbxSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddAppt;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnConfirmEdit;
        private System.Windows.Forms.ComboBox cmbbxDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtbxProvider;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.TextBox txtbxPatient;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtApptDescription;
        private System.Windows.Forms.Label lblApptDescription;
        private System.Windows.Forms.Label lblApptTime;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.DateTimePicker dttmApptTime;
        private System.Windows.Forms.DateTimePicker dttmApptDate;
    }
}