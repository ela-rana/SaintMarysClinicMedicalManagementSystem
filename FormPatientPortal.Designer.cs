
namespace SaintMarysClinicMedicalManagementSystem
{
    partial class FormPatientPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatientPortal));
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbProfile = new System.Windows.Forms.TabPage();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dttmDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbMakeAppt = new System.Windows.Forms.TabPage();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.txtApptDescription = new System.Windows.Forms.TextBox();
            this.lblApptDescription = new System.Windows.Forms.Label();
            this.lblApptTime = new System.Windows.Forms.Label();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.dttmApptTime = new System.Windows.Forms.DateTimePicker();
            this.dttmApptDate = new System.Windows.Forms.DateTimePicker();
            this.tbViewAppointment = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateInstructions = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbProfile.SuspendLayout();
            this.tbMakeAppt.SuspendLayout();
            this.tbViewAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(827, 22);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(201, 32);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbProfile);
            this.tabControl1.Controls.Add(this.tbMakeAppt);
            this.tabControl1.Controls.Add(this.tbViewAppointment);
            this.tabControl1.Location = new System.Drawing.Point(16, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 663);
            this.tabControl1.TabIndex = 4;
            // 
            // tbProfile
            // 
            this.tbProfile.Controls.Add(this.btnSaveChanges);
            this.tbProfile.Controls.Add(this.lblUpdateInstructions);
            this.tbProfile.Controls.Add(this.btnUpdate);
            this.tbProfile.Controls.Add(this.lblDOB);
            this.tbProfile.Controls.Add(this.dttmDOB);
            this.tbProfile.Controls.Add(this.lblAddress);
            this.tbProfile.Controls.Add(this.txtbxAddress);
            this.tbProfile.Controls.Add(this.txtbxPhone);
            this.tbProfile.Controls.Add(this.txtbxLastName);
            this.tbProfile.Controls.Add(this.txtbxMiddleName);
            this.tbProfile.Controls.Add(this.txtbxFirstName);
            this.tbProfile.Controls.Add(this.lblFirstName);
            this.tbProfile.Controls.Add(this.lblPhone);
            this.tbProfile.Controls.Add(this.lblMiddleName);
            this.tbProfile.Controls.Add(this.lblLastName);
            this.tbProfile.Location = new System.Drawing.Point(4, 27);
            this.tbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(1057, 632);
            this.tbProfile.TabIndex = 2;
            this.tbProfile.Text = "My Profile";
            this.tbProfile.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(110, 250);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(90, 18);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date of Birth";
            // 
            // dttmDOB
            // 
            this.dttmDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dttmDOB.Enabled = false;
            this.dttmDOB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttmDOB.Location = new System.Drawing.Point(250, 244);
            this.dttmDOB.Name = "dttmDOB";
            this.dttmDOB.Size = new System.Drawing.Size(321, 23);
            this.dttmDOB.TabIndex = 31;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(110, 218);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 18);
            this.lblAddress.TabIndex = 40;
            this.lblAddress.Text = "Address";
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxAddress.Enabled = false;
            this.txtbxAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAddress.Location = new System.Drawing.Point(250, 213);
            this.txtbxAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(317, 23);
            this.txtbxAddress.TabIndex = 30;
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxPhone.Enabled = false;
            this.txtbxPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.Location = new System.Drawing.Point(250, 182);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(317, 23);
            this.txtbxPhone.TabIndex = 29;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.Location = new System.Drawing.Point(250, 149);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(317, 23);
            this.txtbxLastName.TabIndex = 27;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMiddleName.Enabled = false;
            this.txtbxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMiddleName.Location = new System.Drawing.Point(250, 115);
            this.txtbxMiddleName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(317, 23);
            this.txtbxMiddleName.TabIndex = 26;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.Location = new System.Drawing.Point(250, 81);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(317, 23);
            this.txtbxFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(110, 84);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(74, 18);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(110, 185);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(45, 18);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(110, 118);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(88, 18);
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(110, 152);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 18);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // tbMakeAppt
            // 
            this.tbMakeAppt.Controls.Add(this.lblNote);
            this.tbMakeAppt.Controls.Add(this.btnCheckAvailability);
            this.tbMakeAppt.Controls.Add(this.txtApptDescription);
            this.tbMakeAppt.Controls.Add(this.lblApptDescription);
            this.tbMakeAppt.Controls.Add(this.lblApptTime);
            this.tbMakeAppt.Controls.Add(this.lblApptDate);
            this.tbMakeAppt.Controls.Add(this.dttmApptTime);
            this.tbMakeAppt.Controls.Add(this.dttmApptDate);
            this.tbMakeAppt.Location = new System.Drawing.Point(4, 27);
            this.tbMakeAppt.Margin = new System.Windows.Forms.Padding(4);
            this.tbMakeAppt.Name = "tbMakeAppt";
            this.tbMakeAppt.Padding = new System.Windows.Forms.Padding(4);
            this.tbMakeAppt.Size = new System.Drawing.Size(1057, 632);
            this.tbMakeAppt.TabIndex = 0;
            this.tbMakeAppt.Text = "Make An Appointment";
            this.tbMakeAppt.UseVisualStyleBackColor = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(149, 303);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(714, 54);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = resources.GetString("lblNote.Text");
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(393, 416);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(224, 28);
            this.btnCheckAvailability.TabIndex = 5;
            this.btnCheckAvailability.Text = "Check Appointment Availabilty";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // txtApptDescription
            // 
            this.txtApptDescription.Location = new System.Drawing.Point(411, 184);
            this.txtApptDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtApptDescription.Multiline = true;
            this.txtApptDescription.Name = "txtApptDescription";
            this.txtApptDescription.Size = new System.Drawing.Size(358, 69);
            this.txtApptDescription.TabIndex = 6;
            // 
            // lblApptDescription
            // 
            this.lblApptDescription.AutoSize = true;
            this.lblApptDescription.Location = new System.Drawing.Point(132, 188);
            this.lblApptDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDescription.Name = "lblApptDescription";
            this.lblApptDescription.Size = new System.Drawing.Size(279, 18);
            this.lblApptDescription.TabIndex = 5;
            this.lblApptDescription.Text = "Reason for appointment/Description (Brief):";
            // 
            // lblApptTime
            // 
            this.lblApptTime.AutoSize = true;
            this.lblApptTime.Location = new System.Drawing.Point(132, 132);
            this.lblApptTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptTime.Name = "lblApptTime";
            this.lblApptTime.Size = new System.Drawing.Size(279, 18);
            this.lblApptTime.TabIndex = 3;
            this.lblApptTime.Text = "Select a preferred time for your appointment:";
            // 
            // lblApptDate
            // 
            this.lblApptDate.AutoSize = true;
            this.lblApptDate.Location = new System.Drawing.Point(132, 78);
            this.lblApptDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(279, 18);
            this.lblApptDate.TabIndex = 2;
            this.lblApptDate.Text = "Select a preferred date for your appointment:";
            // 
            // dttmApptTime
            // 
            this.dttmApptTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmApptTime.Location = new System.Drawing.Point(411, 127);
            this.dttmApptTime.Margin = new System.Windows.Forms.Padding(4);
            this.dttmApptTime.Name = "dttmApptTime";
            this.dttmApptTime.Size = new System.Drawing.Size(358, 25);
            this.dttmApptTime.TabIndex = 1;
            // 
            // dttmApptDate
            // 
            this.dttmApptDate.Location = new System.Drawing.Point(411, 73);
            this.dttmApptDate.Margin = new System.Windows.Forms.Padding(4);
            this.dttmApptDate.Name = "dttmApptDate";
            this.dttmApptDate.Size = new System.Drawing.Size(358, 25);
            this.dttmApptDate.TabIndex = 0;
            // 
            // tbViewAppointment
            // 
            this.tbViewAppointment.Controls.Add(this.label7);
            this.tbViewAppointment.Controls.Add(this.label6);
            this.tbViewAppointment.Controls.Add(this.button2);
            this.tbViewAppointment.Controls.Add(this.label3);
            this.tbViewAppointment.Controls.Add(this.dataGridView1);
            this.tbViewAppointment.Location = new System.Drawing.Point(4, 27);
            this.tbViewAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.tbViewAppointment.Name = "tbViewAppointment";
            this.tbViewAppointment.Padding = new System.Windows.Forms.Padding(4);
            this.tbViewAppointment.Size = new System.Drawing.Size(1057, 632);
            this.tbViewAppointment.TabIndex = 1;
            this.tbViewAppointment.Text = "View Appointments";
            this.tbViewAppointment.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(379, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "APPOINTMENTS DISPLAY: Here are your appointments:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select the appt that you want to dell";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(645, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel An Appointment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "APPOINTMENTS DISPLAY\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 508);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(670, 118);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 32);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateInstructions
            // 
            this.lblUpdateInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUpdateInstructions.AutoSize = true;
            this.lblUpdateInstructions.Font = new System.Drawing.Font("Papyrus", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblUpdateInstructions.ForeColor = System.Drawing.Color.Crimson;
            this.lblUpdateInstructions.Location = new System.Drawing.Point(93, 338);
            this.lblUpdateInstructions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdateInstructions.Name = "lblUpdateInstructions";
            this.lblUpdateInstructions.Size = new System.Drawing.Size(552, 21);
            this.lblUpdateInstructions.TabIndex = 42;
            this.lblUpdateInstructions.Text = "Update all fields that you wish to above and then click the Save Changes button";
            this.lblUpdateInstructions.Visible = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(236, 404);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(201, 32);
            this.btnSaveChanges.TabIndex = 43;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // FormPatientPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1097, 732);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPatientPortal";
            this.Text = "Saint Marys Clinic - Patient Portal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPatientPortal_FormClosing);
            this.Load += new System.EventHandler(this.FormPatientPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbProfile.ResumeLayout(false);
            this.tbProfile.PerformLayout();
            this.tbMakeAppt.ResumeLayout(false);
            this.tbMakeAppt.PerformLayout();
            this.tbViewAppointment.ResumeLayout(false);
            this.tbViewAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbMakeAppt;
        private System.Windows.Forms.TabPage tbViewAppointment;
        private System.Windows.Forms.TabPage tbProfile;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.DateTimePicker dttmApptTime;
        private System.Windows.Forms.DateTimePicker dttmApptDate;
        private System.Windows.Forms.TextBox txtApptDescription;
        private System.Windows.Forms.Label lblApptDescription;
        private System.Windows.Forms.Label lblApptTime;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dttmDOB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtbxAddress;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxMiddleName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateInstructions;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}