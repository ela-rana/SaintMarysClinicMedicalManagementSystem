
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
            this.txtbxSSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.grpFields = new System.Windows.Forms.GroupBox();
            this.txtApptDescription = new System.Windows.Forms.TextBox();
            this.btnBrowseProvider = new System.Windows.Forms.Button();
            this.dttmApptDate = new System.Windows.Forms.DateTimePicker();
            this.btnBrowsePatient = new System.Windows.Forms.Button();
            this.dttmApptTime = new System.Windows.Forms.DateTimePicker();
            this.cmbbxDuration = new System.Windows.Forms.ComboBox();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblApptTime = new System.Windows.Forms.Label();
            this.txtbxProvider = new System.Windows.Forms.TextBox();
            this.lblApptDescription = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.txtbxPatient = new System.Windows.Forms.TextBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.btnAddAppt = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnConfirmEdit = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrdApptDisplay = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbProfile.SuspendLayout();
            this.tbViewAppointment.SuspendLayout();
            this.grpFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(899, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 31);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProfile);
            this.tabControl1.Controls.Add(this.tbViewAppointment);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 586);
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
            this.tbProfile.Size = new System.Drawing.Size(790, 481);
            this.tbProfile.TabIndex = 2;
            this.tbProfile.Text = "My Profile";
            this.tbProfile.UseVisualStyleBackColor = true;
            // 
            // txtbxSSN
            // 
            this.txtbxSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxSSN.Enabled = false;
            this.txtbxSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSSN.Location = new System.Drawing.Point(203, 170);
            this.txtbxSSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSSN.Name = "txtbxSSN";
            this.txtbxSSN.Size = new System.Drawing.Size(239, 23);
            this.txtbxSSN.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "SSN";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(177, 312);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 25);
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
            this.lblUpdateInstructions.Location = new System.Drawing.Point(69, 260);
            this.lblUpdateInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateInstructions.Name = "lblUpdateInstructions";
            this.lblUpdateInstructions.Size = new System.Drawing.Size(552, 21);
            this.lblUpdateInstructions.TabIndex = 42;
            this.lblUpdateInstructions.Text = "Update all fields that you wish to above and then click the Save Changes button";
            this.lblUpdateInstructions.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 25);
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
            this.txtbxPhone.Location = new System.Drawing.Point(203, 142);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(239, 23);
            this.txtbxPhone.TabIndex = 29;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.Location = new System.Drawing.Point(203, 117);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(239, 23);
            this.txtbxLastName.TabIndex = 27;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMiddleName.Enabled = false;
            this.txtbxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMiddleName.Location = new System.Drawing.Point(203, 91);
            this.txtbxMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(239, 23);
            this.txtbxMiddleName.TabIndex = 26;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.Location = new System.Drawing.Point(203, 64);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(239, 23);
            this.txtbxFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(83, 64);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 17);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(83, 142);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 17);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(83, 90);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(102, 17);
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(83, 117);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 17);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // tbViewAppointment
            // 
            this.tbViewAppointment.Controls.Add(this.btnCancelAdd);
            this.tbViewAppointment.Controls.Add(this.grpFields);
            this.tbViewAppointment.Controls.Add(this.btnCancelEdit);
            this.tbViewAppointment.Controls.Add(this.btnConfirmAdd);
            this.tbViewAppointment.Controls.Add(this.btnAddAppt);
            this.tbViewAppointment.Controls.Add(this.btnEdit);
            this.tbViewAppointment.Controls.Add(this.btnConfirmEdit);
            this.tbViewAppointment.Controls.Add(this.btnVerify);
            this.tbViewAppointment.Controls.Add(this.btnDelete);
            this.tbViewAppointment.Controls.Add(this.label7);
            this.tbViewAppointment.Controls.Add(this.lblMessage);
            this.tbViewAppointment.Controls.Add(this.label3);
            this.tbViewAppointment.Controls.Add(this.dtgrdApptDisplay);
            this.tbViewAppointment.Location = new System.Drawing.Point(4, 26);
            this.tbViewAppointment.Name = "tbViewAppointment";
            this.tbViewAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewAppointment.Size = new System.Drawing.Size(989, 556);
            this.tbViewAppointment.TabIndex = 1;
            this.tbViewAppointment.Text = "View Appointments";
            this.tbViewAppointment.UseVisualStyleBackColor = true;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelAdd.Location = new System.Drawing.Point(777, 456);
            this.btnCancelAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(112, 22);
            this.btnCancelAdd.TabIndex = 27;
            this.btnCancelAdd.Text = "Cancel Add";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Visible = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // grpFields
            // 
            this.grpFields.Controls.Add(this.txtApptDescription);
            this.grpFields.Controls.Add(this.btnBrowseProvider);
            this.grpFields.Controls.Add(this.dttmApptDate);
            this.grpFields.Controls.Add(this.btnBrowsePatient);
            this.grpFields.Controls.Add(this.dttmApptTime);
            this.grpFields.Controls.Add(this.cmbbxDuration);
            this.grpFields.Controls.Add(this.lblApptDate);
            this.grpFields.Controls.Add(this.lblDuration);
            this.grpFields.Controls.Add(this.lblApptTime);
            this.grpFields.Controls.Add(this.txtbxProvider);
            this.grpFields.Controls.Add(this.lblApptDescription);
            this.grpFields.Controls.Add(this.lblProvider);
            this.grpFields.Controls.Add(this.lblPatient);
            this.grpFields.Controls.Add(this.txtbxPatient);
            this.grpFields.Location = new System.Drawing.Point(611, 200);
            this.grpFields.Name = "grpFields";
            this.grpFields.Size = new System.Drawing.Size(336, 220);
            this.grpFields.TabIndex = 25;
            this.grpFields.TabStop = false;
            this.grpFields.Visible = false;
            // 
            // txtApptDescription
            // 
            this.txtApptDescription.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApptDescription.Location = new System.Drawing.Point(94, 95);
            this.txtApptDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtApptDescription.Multiline = true;
            this.txtApptDescription.Name = "txtApptDescription";
            this.txtApptDescription.Size = new System.Drawing.Size(239, 45);
            this.txtApptDescription.TabIndex = 15;
            // 
            // btnBrowseProvider
            // 
            this.btnBrowseProvider.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBrowseProvider.Location = new System.Drawing.Point(185, 174);
            this.btnBrowseProvider.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowseProvider.Name = "btnBrowseProvider";
            this.btnBrowseProvider.Size = new System.Drawing.Size(112, 18);
            this.btnBrowseProvider.TabIndex = 24;
            this.btnBrowseProvider.Text = "Browse Provider";
            this.btnBrowseProvider.UseVisualStyleBackColor = true;
            this.btnBrowseProvider.Click += new System.EventHandler(this.btnBrowseProvider_Click);
            // 
            // dttmApptDate
            // 
            this.dttmApptDate.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttmApptDate.Location = new System.Drawing.Point(94, 41);
            this.dttmApptDate.Margin = new System.Windows.Forms.Padding(4);
            this.dttmApptDate.Name = "dttmApptDate";
            this.dttmApptDate.Size = new System.Drawing.Size(240, 20);
            this.dttmApptDate.TabIndex = 10;
            // 
            // btnBrowsePatient
            // 
            this.btnBrowsePatient.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBrowsePatient.Location = new System.Drawing.Point(185, 150);
            this.btnBrowsePatient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowsePatient.Name = "btnBrowsePatient";
            this.btnBrowsePatient.Size = new System.Drawing.Size(112, 18);
            this.btnBrowsePatient.TabIndex = 23;
            this.btnBrowsePatient.Text = "Browse Patient";
            this.btnBrowsePatient.UseVisualStyleBackColor = true;
            this.btnBrowsePatient.Click += new System.EventHandler(this.btnBrowsePatient_Click);
            // 
            // dttmApptTime
            // 
            this.dttmApptTime.CustomFormat = "hh:mm";
            this.dttmApptTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dttmApptTime.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttmApptTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttmApptTime.Location = new System.Drawing.Point(94, 66);
            this.dttmApptTime.Margin = new System.Windows.Forms.Padding(4);
            this.dttmApptTime.Name = "dttmApptTime";
            this.dttmApptTime.Size = new System.Drawing.Size(239, 20);
            this.dttmApptTime.TabIndex = 11;
            this.dttmApptTime.Value = new System.DateTime(2022, 9, 1, 9, 0, 0, 0);
            // 
            // cmbbxDuration
            // 
            this.cmbbxDuration.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxDuration.FormattingEnabled = true;
            this.cmbbxDuration.Location = new System.Drawing.Point(94, 197);
            this.cmbbxDuration.Name = "cmbbxDuration";
            this.cmbbxDuration.Size = new System.Drawing.Size(240, 21);
            this.cmbbxDuration.TabIndex = 22;
            // 
            // lblApptDate
            // 
            this.lblApptDate.AutoSize = true;
            this.lblApptDate.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApptDate.Location = new System.Drawing.Point(2, 40);
            this.lblApptDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(67, 13);
            this.lblApptDate.TabIndex = 12;
            this.lblApptDate.Text = "Appt Date:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDuration.Location = new System.Drawing.Point(1, 200);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(60, 13);
            this.lblDuration.TabIndex = 21;
            this.lblDuration.Text = "Duration:";
            // 
            // lblApptTime
            // 
            this.lblApptTime.AutoSize = true;
            this.lblApptTime.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApptTime.Location = new System.Drawing.Point(2, 72);
            this.lblApptTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptTime.Name = "lblApptTime";
            this.lblApptTime.Size = new System.Drawing.Size(67, 13);
            this.lblApptTime.TabIndex = 13;
            this.lblApptTime.Text = "Appt Time:";
            // 
            // txtbxProvider
            // 
            this.txtbxProvider.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxProvider.Location = new System.Drawing.Point(94, 174);
            this.txtbxProvider.Name = "txtbxProvider";
            this.txtbxProvider.ReadOnly = true;
            this.txtbxProvider.Size = new System.Drawing.Size(78, 20);
            this.txtbxProvider.TabIndex = 20;
            // 
            // lblApptDescription
            // 
            this.lblApptDescription.AutoSize = true;
            this.lblApptDescription.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblApptDescription.Location = new System.Drawing.Point(2, 98);
            this.lblApptDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDescription.Name = "lblApptDescription";
            this.lblApptDescription.Size = new System.Drawing.Size(75, 13);
            this.lblApptDescription.TabIndex = 14;
            this.lblApptDescription.Text = "Description:";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProvider.Location = new System.Drawing.Point(1, 177);
            this.lblProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(58, 13);
            this.lblProvider.TabIndex = 19;
            this.lblProvider.Text = "Provider:";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPatient.Location = new System.Drawing.Point(2, 154);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(50, 13);
            this.lblPatient.TabIndex = 16;
            this.lblPatient.Text = "Patient:";
            // 
            // txtbxPatient
            // 
            this.txtbxPatient.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPatient.Location = new System.Drawing.Point(94, 150);
            this.txtbxPatient.Name = "txtbxPatient";
            this.txtbxPatient.ReadOnly = true;
            this.txtbxPatient.Size = new System.Drawing.Size(77, 20);
            this.txtbxPatient.TabIndex = 17;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelEdit.Location = new System.Drawing.Point(661, 456);
            this.btnCancelEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(112, 22);
            this.btnCancelEdit.TabIndex = 26;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmAdd.Location = new System.Drawing.Point(777, 433);
            this.btnConfirmAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(112, 22);
            this.btnConfirmAdd.TabIndex = 18;
            this.btnConfirmAdd.Text = "Confirm Add";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Visible = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // btnAddAppt
            // 
            this.btnAddAppt.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddAppt.Location = new System.Drawing.Point(781, 171);
            this.btnAddAppt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddAppt.Name = "btnAddAppt";
            this.btnAddAppt.Size = new System.Drawing.Size(153, 22);
            this.btnAddAppt.TabIndex = 9;
            this.btnAddAppt.Text = "Add New Appt";
            this.btnAddAppt.UseVisualStyleBackColor = true;
            this.btnAddAppt.Click += new System.EventHandler(this.btnAddAppt_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(781, 143);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 22);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit Selected Appt";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnConfirmEdit
            // 
            this.btnConfirmEdit.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfirmEdit.Location = new System.Drawing.Point(661, 433);
            this.btnConfirmEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConfirmEdit.Name = "btnConfirmEdit";
            this.btnConfirmEdit.Size = new System.Drawing.Size(112, 22);
            this.btnConfirmEdit.TabIndex = 7;
            this.btnConfirmEdit.Text = "Confirm Edit";
            this.btnConfirmEdit.UseVisualStyleBackColor = true;
            this.btnConfirmEdit.Visible = false;
            this.btnConfirmEdit.Click += new System.EventHandler(this.btnConfirmEdit_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVerify.Location = new System.Drawing.Point(629, 143);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(153, 22);
            this.btnVerify.TabIndex = 6;
            this.btnVerify.Text = "Verify Selected Appt";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(629, 171);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 22);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Selected Appt";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(547, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Here are your appointments: (If display is blank, then you have no appts)";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(627, 61);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(335, 68);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Select an appt on the Appointments Display \r\nand click Verify Appointment below t" +
    "o \r\napprove that appt request, Delete to cancel \r\nthe appt, or edit to update it" +
    "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 16);
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
            this.dtgrdApptDisplay.Location = new System.Drawing.Point(5, 49);
            this.dtgrdApptDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgrdApptDisplay.Name = "dtgrdApptDisplay";
            this.dtgrdApptDisplay.Size = new System.Drawing.Size(601, 489);
            this.dtgrdApptDisplay.TabIndex = 0;
            // 
            // FormAdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1013, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogOut);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdminPortal";
            this.Text = "Saint Mary\'s Clinic - Admin Portal";
            this.Load += new System.EventHandler(this.FormAdminPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbProfile.ResumeLayout(false);
            this.tbProfile.PerformLayout();
            this.tbViewAppointment.ResumeLayout(false);
            this.tbViewAppointment.PerformLayout();
            this.grpFields.ResumeLayout(false);
            this.grpFields.PerformLayout();
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
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Button btnConfirmAdd;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.TextBox txtApptDescription;
        private System.Windows.Forms.Label lblApptDescription;
        private System.Windows.Forms.Label lblApptTime;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.DateTimePicker dttmApptTime;
        private System.Windows.Forms.DateTimePicker dttmApptDate;
        private System.Windows.Forms.Button btnBrowseProvider;
        private System.Windows.Forms.Button btnBrowsePatient;
        private System.Windows.Forms.TextBox txtbxProvider;
        private System.Windows.Forms.TextBox txtbxPatient;
        private System.Windows.Forms.GroupBox grpFields;
        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}