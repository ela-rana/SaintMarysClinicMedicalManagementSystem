
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tbProfile = new System.Windows.Forms.TabPage();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblUpdateInstructions = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxMiddleName = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbViewAppts = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrdApptDisplay = new System.Windows.Forms.DataGridView();
            this.cmbxEmpType = new System.Windows.Forms.ComboBox();
            this.cmbxSpecialty = new System.Windows.Forms.ComboBox();
            this.tabControlAdmin.SuspendLayout();
            this.tbProfile.SuspendLayout();
            this.tbViewAppts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portal Under Construction";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(639, 16);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(122, 40);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tbProfile);
            this.tabControlAdmin.Controls.Add(this.tbViewAppts);
            this.tabControlAdmin.Font = new System.Drawing.Font("Harrington", 10.25F, System.Drawing.FontStyle.Bold);
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 66);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1028, 654);
            this.tabControlAdmin.TabIndex = 4;
            // 
            // tbProfile
            // 
            this.tbProfile.Controls.Add(this.cmbxEmpType);
            this.tbProfile.Controls.Add(this.cmbxSpecialty);
            this.tbProfile.Controls.Add(this.btnSaveChanges);
            this.tbProfile.Controls.Add(this.lblUpdateInstructions);
            this.tbProfile.Controls.Add(this.btnUpdate);
            this.tbProfile.Controls.Add(this.lblSpecialty);
            this.tbProfile.Controls.Add(this.lblEmpType);
            this.tbProfile.Controls.Add(this.txtbxPhone);
            this.tbProfile.Controls.Add(this.txtbxLastName);
            this.tbProfile.Controls.Add(this.txtbxMiddleName);
            this.tbProfile.Controls.Add(this.txtbxFirstName);
            this.tbProfile.Controls.Add(this.lblFirstName);
            this.tbProfile.Controls.Add(this.lblPhone);
            this.tbProfile.Controls.Add(this.lblMiddleName);
            this.tbProfile.Controls.Add(this.lblLastName);
            this.tbProfile.Location = new System.Drawing.Point(4, 25);
            this.tbProfile.Margin = new System.Windows.Forms.Padding(4);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(1020, 625);
            this.tbProfile.TabIndex = 3;
            this.tbProfile.Text = "My Profile";
            this.tbProfile.UseVisualStyleBackColor = true;
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
            this.btnSaveChanges.Visible = false;
            // 
            // lblUpdateInstructions
            // 
            this.lblUpdateInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUpdateInstructions.AutoSize = true;
            this.lblUpdateInstructions.Font = new System.Drawing.Font("Papyrus", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblUpdateInstructions.ForeColor = System.Drawing.Color.Crimson;
            this.lblUpdateInstructions.Location = new System.Drawing.Point(93, 334);
            this.lblUpdateInstructions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUpdateInstructions.Name = "lblUpdateInstructions";
            this.lblUpdateInstructions.Size = new System.Drawing.Size(552, 21);
            this.lblUpdateInstructions.TabIndex = 42;
            this.lblUpdateInstructions.Text = "Update all fields that you wish to above and then click the Save Changes button";
            this.lblUpdateInstructions.Visible = false;
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
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(110, 246);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(74, 16);
            this.lblSpecialty.TabIndex = 23;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblEmpType
            // 
            this.lblEmpType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmpType.AutoSize = true;
            this.lblEmpType.Location = new System.Drawing.Point(110, 214);
            this.lblEmpType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(116, 16);
            this.lblEmpType.TabIndex = 40;
            this.lblEmpType.Text = "Employee Type";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxPhone.Enabled = false;
            this.txtbxPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.Location = new System.Drawing.Point(250, 178);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(280, 23);
            this.txtbxPhone.TabIndex = 29;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.Location = new System.Drawing.Point(250, 145);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(280, 23);
            this.txtbxLastName.TabIndex = 27;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMiddleName.Enabled = false;
            this.txtbxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMiddleName.Location = new System.Drawing.Point(250, 111);
            this.txtbxMiddleName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(280, 23);
            this.txtbxMiddleName.TabIndex = 26;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.Location = new System.Drawing.Point(250, 77);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(280, 23);
            this.txtbxFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(110, 80);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 16);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(110, 181);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 16);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(110, 114);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(98, 16);
            this.lblMiddleName.TabIndex = 11;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(110, 148);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 16);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // tbViewAppts
            // 
            this.tbViewAppts.Controls.Add(this.groupBox1);
            this.tbViewAppts.Controls.Add(this.label7);
            this.tbViewAppts.Controls.Add(this.label3);
            this.tbViewAppts.Controls.Add(this.dtgrdApptDisplay);
            this.tbViewAppts.Location = new System.Drawing.Point(4, 25);
            this.tbViewAppts.Name = "tbViewAppts";
            this.tbViewAppts.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewAppts.Size = new System.Drawing.Size(1020, 625);
            this.tbViewAppts.TabIndex = 1;
            this.tbViewAppts.Text = "View All Appointments";
            this.tbViewAppts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(21, 576);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(570, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Appt";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update Appt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New Appt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(614, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Here are all the appointments for this Clinic: (If display is blank, there are no" +
    " appts)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "APPOINTMENTS DISPLAY\r\n";
            // 
            // dtgrdApptDisplay
            // 
            this.dtgrdApptDisplay.BackgroundColor = System.Drawing.Color.Thistle;
            this.dtgrdApptDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdApptDisplay.Location = new System.Drawing.Point(18, 64);
            this.dtgrdApptDisplay.Name = "dtgrdApptDisplay";
            this.dtgrdApptDisplay.Size = new System.Drawing.Size(974, 508);
            this.dtgrdApptDisplay.TabIndex = 5;
            // 
            // cmbxEmpType
            // 
            this.cmbxEmpType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxEmpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmpType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEmpType.FormattingEnabled = true;
            this.cmbxEmpType.Location = new System.Drawing.Point(250, 214);
            this.cmbxEmpType.Name = "cmbxEmpType";
            this.cmbxEmpType.Size = new System.Drawing.Size(280, 23);
            this.cmbxEmpType.TabIndex = 44;
            // 
            // cmbxSpecialty
            // 
            this.cmbxSpecialty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxSpecialty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxSpecialty.FormattingEnabled = true;
            this.cmbxSpecialty.Location = new System.Drawing.Point(250, 242);
            this.cmbxSpecialty.Name = "cmbxSpecialty";
            this.cmbxSpecialty.Size = new System.Drawing.Size(280, 23);
            this.cmbxSpecialty.TabIndex = 45;
            // 
            // FormAdminPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1097, 732);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormAdminPortal";
            this.Text = "Saint Mary\'s Clinic - Admin Portal";
            this.Load += new System.EventHandler(this.FormAdminPortal_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tbProfile.ResumeLayout(false);
            this.tbProfile.PerformLayout();
            this.tbViewAppts.ResumeLayout(false);
            this.tbViewAppts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tbViewAppts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgrdApptDisplay;
        private System.Windows.Forms.TabPage tbProfile;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblUpdateInstructions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.TextBox txtbxPhone;
        private System.Windows.Forms.TextBox txtbxLastName;
        private System.Windows.Forms.TextBox txtbxMiddleName;
        private System.Windows.Forms.TextBox txtbxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbxEmpType;
        private System.Windows.Forms.ComboBox cmbxSpecialty;
    }
}