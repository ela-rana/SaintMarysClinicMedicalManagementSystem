
namespace SaintMarysClinicMedicalManagementSystem
{
    partial class FormMedStaffPortal
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
            this.btnChangeView = new System.Windows.Forms.Button();
            this.lblDisplayDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrdApptDisplay = new System.Windows.Forms.DataGridView();
            this.tbChart = new System.Windows.Forms.TabPage();
            this.grpChart = new System.Windows.Forms.GroupBox();
            this.btnSaveChart = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergies = new System.Windows.Forms.Label();
            this.txtMedications = new System.Windows.Forms.TextBox();
            this.lblMedications = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPain = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblPain = new System.Windows.Forms.Label();
            this.txtO2 = new System.Windows.Forms.TextBox();
            this.txtRR = new System.Windows.Forms.TextBox();
            this.txtHR = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.lblBP = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.lblRR = new System.Windows.Forms.Label();
            this.lblO2 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblVitals = new System.Windows.Forms.Label();
            this.cmbxSelectPatient = new System.Windows.Forms.ComboBox();
            this.lblSelectPatient = new System.Windows.Forms.Label();
            this.tbViewChart = new System.Windows.Forms.TabPage();
            this.txtChartDisplay = new System.Windows.Forms.RichTextBox();
            this.cmbxSelectViewPatient = new System.Windows.Forms.ComboBox();
            this.lblSelectViewPatient = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbProfile.SuspendLayout();
            this.tbViewAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).BeginInit();
            this.tbChart.SuspendLayout();
            this.grpChart.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbViewChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogOut.Location = new System.Drawing.Point(899, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(92, 31);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tbProfile);
            this.tabControl1.Controls.Add(this.tbViewAppointment);
            this.tabControl1.Controls.Add(this.tbChart);
            this.tabControl1.Controls.Add(this.tbViewChart);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 586);
            this.tabControl1.TabIndex = 5;
            // 
            // tbProfile
            // 
            this.tbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.tbProfile.Location = new System.Drawing.Point(4, 26);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Size = new System.Drawing.Size(989, 556);
            this.tbProfile.TabIndex = 2;
            this.tbProfile.Text = "My Profile";
            // 
            // txtbxSSN
            // 
            this.txtbxSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxSSN.Enabled = false;
            this.txtbxSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSSN.Location = new System.Drawing.Point(203, 120);
            this.txtbxSSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSSN.Name = "txtbxSSN";
            this.txtbxSSN.Size = new System.Drawing.Size(102, 23);
            this.txtbxSSN.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "SSN";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(177, 312);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(150, 41);
            this.btnSaveChanges.TabIndex = 43;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblUpdateInstructions
            // 
            this.lblUpdateInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUpdateInstructions.AutoSize = true;
            this.lblUpdateInstructions.Font = new System.Drawing.Font("Papyrus", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblUpdateInstructions.ForeColor = System.Drawing.Color.Crimson;
            this.lblUpdateInstructions.Location = new System.Drawing.Point(69, 210);
            this.lblUpdateInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateInstructions.Name = "lblUpdateInstructions";
            this.lblUpdateInstructions.Size = new System.Drawing.Size(552, 21);
            this.lblUpdateInstructions.TabIndex = 42;
            this.lblUpdateInstructions.Text = "Update all fields that you wish to above and then click the Save Changes button";
            this.lblUpdateInstructions.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Location = new System.Drawing.Point(502, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 43);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxPhone.Enabled = false;
            this.txtbxPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPhone.Location = new System.Drawing.Point(203, 92);
            this.txtbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(102, 23);
            this.txtbxPhone.TabIndex = 29;
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxLastName.Enabled = false;
            this.txtbxLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLastName.Location = new System.Drawing.Point(203, 67);
            this.txtbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(102, 23);
            this.txtbxLastName.TabIndex = 27;
            // 
            // txtbxMiddleName
            // 
            this.txtbxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxMiddleName.Enabled = false;
            this.txtbxMiddleName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMiddleName.Location = new System.Drawing.Point(203, 41);
            this.txtbxMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxMiddleName.Name = "txtbxMiddleName";
            this.txtbxMiddleName.Size = new System.Drawing.Size(102, 23);
            this.txtbxMiddleName.TabIndex = 26;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxFirstName.Enabled = false;
            this.txtbxFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFirstName.Location = new System.Drawing.Point(203, 14);
            this.txtbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(102, 23);
            this.txtbxFirstName.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(83, 14);
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
            this.lblPhone.Location = new System.Drawing.Point(83, 92);
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
            this.lblMiddleName.Location = new System.Drawing.Point(83, 40);
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
            this.lblLastName.Location = new System.Drawing.Point(83, 67);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(85, 17);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name";
            // 
            // tbViewAppointment
            // 
            this.tbViewAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbViewAppointment.Controls.Add(this.btnChangeView);
            this.tbViewAppointment.Controls.Add(this.lblDisplayDetails);
            this.tbViewAppointment.Controls.Add(this.label3);
            this.tbViewAppointment.Controls.Add(this.dtgrdApptDisplay);
            this.tbViewAppointment.Location = new System.Drawing.Point(4, 26);
            this.tbViewAppointment.Name = "tbViewAppointment";
            this.tbViewAppointment.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewAppointment.Size = new System.Drawing.Size(989, 556);
            this.tbViewAppointment.TabIndex = 1;
            this.tbViewAppointment.Text = "View Appointments";
            // 
            // btnChangeView
            // 
            this.btnChangeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChangeView.Location = new System.Drawing.Point(381, 6);
            this.btnChangeView.Name = "btnChangeView";
            this.btnChangeView.Size = new System.Drawing.Size(250, 37);
            this.btnChangeView.TabIndex = 5;
            this.btnChangeView.Text = "View My Appointments Only";
            this.btnChangeView.UseVisualStyleBackColor = false;
            this.btnChangeView.Visible = false;
            this.btnChangeView.Click += new System.EventHandler(this.btnChangeView_Click);
            // 
            // lblDisplayDetails
            // 
            this.lblDisplayDetails.AutoSize = true;
            this.lblDisplayDetails.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDisplayDetails.Location = new System.Drawing.Point(6, 31);
            this.lblDisplayDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayDetails.Name = "lblDisplayDetails";
            this.lblDisplayDetails.Size = new System.Drawing.Size(312, 17);
            this.lblDisplayDetails.TabIndex = 4;
            this.lblDisplayDetails.Text = "Here are all appointments for this clinic: ";
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
            this.dtgrdApptDisplay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtgrdApptDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdApptDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgrdApptDisplay.Location = new System.Drawing.Point(5, 49);
            this.dtgrdApptDisplay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgrdApptDisplay.Name = "dtgrdApptDisplay";
            this.dtgrdApptDisplay.Size = new System.Drawing.Size(979, 501);
            this.dtgrdApptDisplay.TabIndex = 0;
            // 
            // tbChart
            // 
            this.tbChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbChart.Controls.Add(this.grpChart);
            this.tbChart.Controls.Add(this.cmbxSelectPatient);
            this.tbChart.Controls.Add(this.lblSelectPatient);
            this.tbChart.Location = new System.Drawing.Point(4, 26);
            this.tbChart.Name = "tbChart";
            this.tbChart.Padding = new System.Windows.Forms.Padding(3);
            this.tbChart.Size = new System.Drawing.Size(989, 556);
            this.tbChart.TabIndex = 3;
            this.tbChart.Text = "Chart";
            // 
            // grpChart
            // 
            this.grpChart.Controls.Add(this.btnSaveChart);
            this.grpChart.Controls.Add(this.txtNotes);
            this.grpChart.Controls.Add(this.lblNotes);
            this.grpChart.Controls.Add(this.txtAllergies);
            this.grpChart.Controls.Add(this.lblAllergies);
            this.grpChart.Controls.Add(this.txtMedications);
            this.grpChart.Controls.Add(this.lblMedications);
            this.grpChart.Controls.Add(this.txtDiagnosis);
            this.grpChart.Controls.Add(this.tableLayoutPanel1);
            this.grpChart.Controls.Add(this.lblDiagnosis);
            this.grpChart.Controls.Add(this.lblVitals);
            this.grpChart.Location = new System.Drawing.Point(6, 48);
            this.grpChart.Name = "grpChart";
            this.grpChart.Size = new System.Drawing.Size(978, 504);
            this.grpChart.TabIndex = 2;
            this.grpChart.TabStop = false;
            this.grpChart.Visible = false;
            // 
            // btnSaveChart
            // 
            this.btnSaveChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveChart.Location = new System.Drawing.Point(369, 450);
            this.btnSaveChart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSaveChart.Name = "btnSaveChart";
            this.btnSaveChart.Size = new System.Drawing.Size(152, 46);
            this.btnSaveChart.TabIndex = 9;
            this.btnSaveChart.Text = "Save Chart";
            this.btnSaveChart.UseVisualStyleBackColor = false;
            this.btnSaveChart.Click += new System.EventHandler(this.btnSaveChart_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(110, 111);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(677, 331);
            this.txtNotes.TabIndex = 8;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(3, 114);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(54, 17);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Notes:";
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(110, 80);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(677, 25);
            this.txtAllergies.TabIndex = 6;
            // 
            // lblAllergies
            // 
            this.lblAllergies.AutoSize = true;
            this.lblAllergies.Location = new System.Drawing.Point(3, 83);
            this.lblAllergies.Name = "lblAllergies";
            this.lblAllergies.Size = new System.Drawing.Size(79, 17);
            this.lblAllergies.TabIndex = 5;
            this.lblAllergies.Text = "Allergies:";
            // 
            // txtMedications
            // 
            this.txtMedications.Location = new System.Drawing.Point(110, 49);
            this.txtMedications.Name = "txtMedications";
            this.txtMedications.Size = new System.Drawing.Size(677, 25);
            this.txtMedications.TabIndex = 4;
            // 
            // lblMedications
            // 
            this.lblMedications.AutoSize = true;
            this.lblMedications.Location = new System.Drawing.Point(3, 52);
            this.lblMedications.Name = "lblMedications";
            this.lblMedications.Size = new System.Drawing.Size(101, 17);
            this.lblMedications.TabIndex = 3;
            this.lblMedications.Text = "Medications:";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Location = new System.Drawing.Point(110, 18);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(677, 25);
            this.txtDiagnosis.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.5F));
            this.tableLayoutPanel1.Controls.Add(this.txtPain, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTemp, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPain, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtO2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtRR, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHR, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblBP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRR, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblO2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTemp, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(822, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 185);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtPain
            // 
            this.txtPain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPain.Location = new System.Drawing.Point(56, 155);
            this.txtPain.Name = "txtPain";
            this.txtPain.Size = new System.Drawing.Size(81, 25);
            this.txtPain.TabIndex = 22;
            // 
            // txtTemp
            // 
            this.txtTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemp.Location = new System.Drawing.Point(56, 123);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(81, 25);
            this.txtTemp.TabIndex = 20;
            // 
            // lblPain
            // 
            this.lblPain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPain.AutoSize = true;
            this.lblPain.Location = new System.Drawing.Point(3, 159);
            this.lblPain.Name = "lblPain";
            this.lblPain.Size = new System.Drawing.Size(47, 17);
            this.lblPain.TabIndex = 21;
            this.lblPain.Text = "Pain";
            // 
            // txtO2
            // 
            this.txtO2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtO2.Location = new System.Drawing.Point(56, 93);
            this.txtO2.Name = "txtO2";
            this.txtO2.Size = new System.Drawing.Size(81, 25);
            this.txtO2.TabIndex = 19;
            // 
            // txtRR
            // 
            this.txtRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRR.Location = new System.Drawing.Point(56, 63);
            this.txtRR.Name = "txtRR";
            this.txtRR.Size = new System.Drawing.Size(81, 25);
            this.txtRR.TabIndex = 18;
            // 
            // txtHR
            // 
            this.txtHR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHR.Location = new System.Drawing.Point(56, 33);
            this.txtHR.Name = "txtHR";
            this.txtHR.Size = new System.Drawing.Size(81, 25);
            this.txtHR.TabIndex = 17;
            // 
            // txtBP
            // 
            this.txtBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBP.Location = new System.Drawing.Point(56, 3);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(81, 25);
            this.txtBP.TabIndex = 16;
            // 
            // lblBP
            // 
            this.lblBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(3, 6);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(47, 17);
            this.lblBP.TabIndex = 2;
            this.lblBP.Text = "BP";
            // 
            // lblHR
            // 
            this.lblHR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(3, 36);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(47, 17);
            this.lblHR.TabIndex = 4;
            this.lblHR.Text = "HR";
            // 
            // lblRR
            // 
            this.lblRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRR.AutoSize = true;
            this.lblRR.Location = new System.Drawing.Point(3, 66);
            this.lblRR.Name = "lblRR";
            this.lblRR.Size = new System.Drawing.Size(47, 17);
            this.lblRR.TabIndex = 6;
            this.lblRR.Text = "RR";
            // 
            // lblO2
            // 
            this.lblO2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblO2.AutoSize = true;
            this.lblO2.Location = new System.Drawing.Point(3, 96);
            this.lblO2.Name = "lblO2";
            this.lblO2.Size = new System.Drawing.Size(47, 17);
            this.lblO2.TabIndex = 8;
            this.lblO2.Text = "O2";
            // 
            // lblTemp
            // 
            this.lblTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(3, 126);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(47, 17);
            this.lblTemp.TabIndex = 10;
            this.lblTemp.Text = "Temp";
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.Location = new System.Drawing.Point(3, 21);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(86, 17);
            this.lblDiagnosis.TabIndex = 0;
            this.lblDiagnosis.Text = "Diagnosis:";
            // 
            // lblVitals
            // 
            this.lblVitals.AutoSize = true;
            this.lblVitals.Location = new System.Drawing.Point(819, 21);
            this.lblVitals.Name = "lblVitals";
            this.lblVitals.Size = new System.Drawing.Size(65, 17);
            this.lblVitals.TabIndex = 0;
            this.lblVitals.Text = "VITALS";
            // 
            // cmbxSelectPatient
            // 
            this.cmbxSelectPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectPatient.FormattingEnabled = true;
            this.cmbxSelectPatient.Location = new System.Drawing.Point(215, 10);
            this.cmbxSelectPatient.Name = "cmbxSelectPatient";
            this.cmbxSelectPatient.Size = new System.Drawing.Size(669, 25);
            this.cmbxSelectPatient.TabIndex = 1;
            this.cmbxSelectPatient.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectPatient_SelectedIndexChanged);
            // 
            // lblSelectPatient
            // 
            this.lblSelectPatient.AutoSize = true;
            this.lblSelectPatient.Location = new System.Drawing.Point(6, 13);
            this.lblSelectPatient.Name = "lblSelectPatient";
            this.lblSelectPatient.Size = new System.Drawing.Size(203, 17);
            this.lblSelectPatient.TabIndex = 0;
            this.lblSelectPatient.Text = "Select Patient to Chart On:";
            // 
            // tbViewChart
            // 
            this.tbViewChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbViewChart.Controls.Add(this.txtChartDisplay);
            this.tbViewChart.Controls.Add(this.cmbxSelectViewPatient);
            this.tbViewChart.Controls.Add(this.lblSelectViewPatient);
            this.tbViewChart.Location = new System.Drawing.Point(4, 26);
            this.tbViewChart.Name = "tbViewChart";
            this.tbViewChart.Padding = new System.Windows.Forms.Padding(3);
            this.tbViewChart.Size = new System.Drawing.Size(989, 556);
            this.tbViewChart.TabIndex = 4;
            this.tbViewChart.Text = "View Patient Charts";
            // 
            // txtChartDisplay
            // 
            this.txtChartDisplay.Location = new System.Drawing.Point(6, 54);
            this.txtChartDisplay.Name = "txtChartDisplay";
            this.txtChartDisplay.Size = new System.Drawing.Size(977, 496);
            this.txtChartDisplay.TabIndex = 11;
            this.txtChartDisplay.Text = "";
            // 
            // cmbxSelectViewPatient
            // 
            this.cmbxSelectViewPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectViewPatient.FormattingEnabled = true;
            this.cmbxSelectViewPatient.Location = new System.Drawing.Point(302, 12);
            this.cmbxSelectViewPatient.Name = "cmbxSelectViewPatient";
            this.cmbxSelectViewPatient.Size = new System.Drawing.Size(669, 25);
            this.cmbxSelectViewPatient.TabIndex = 10;
            this.cmbxSelectViewPatient.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectViewPatient_SelectedIndexChanged);
            // 
            // lblSelectViewPatient
            // 
            this.lblSelectViewPatient.AutoSize = true;
            this.lblSelectViewPatient.Location = new System.Drawing.Point(13, 15);
            this.lblSelectViewPatient.Name = "lblSelectViewPatient";
            this.lblSelectViewPatient.Size = new System.Drawing.Size(261, 17);
            this.lblSelectViewPatient.TabIndex = 9;
            this.lblSelectViewPatient.Text = "Select Patient to View Their Chart:\r\n";
            // 
            // FormMedStaffPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1013, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogOut);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Harrington", 11.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMedStaffPortal";
            this.Text = "Saint Mary\'s Clinic - Medical Staff Portal";
            this.Load += new System.EventHandler(this.FormMedStaffPortal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbProfile.ResumeLayout(false);
            this.tbProfile.PerformLayout();
            this.tbViewAppointment.ResumeLayout(false);
            this.tbViewAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdApptDisplay)).EndInit();
            this.tbChart.ResumeLayout(false);
            this.tbChart.PerformLayout();
            this.grpChart.ResumeLayout(false);
            this.grpChart.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbViewChart.ResumeLayout(false);
            this.tbViewChart.PerformLayout();
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
        private System.Windows.Forms.Label lblDisplayDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgrdApptDisplay;
        private System.Windows.Forms.TextBox txtbxSSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeView;
        private System.Windows.Forms.TabPage tbChart;
        private System.Windows.Forms.ComboBox cmbxSelectPatient;
        private System.Windows.Forms.Label lblSelectPatient;
        private System.Windows.Forms.GroupBox grpChart;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Button btnSaveChart;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblAllergies;
        private System.Windows.Forms.TextBox txtMedications;
        private System.Windows.Forms.Label lblMedications;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPain;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblPain;
        private System.Windows.Forms.TextBox txtO2;
        private System.Windows.Forms.TextBox txtRR;
        private System.Windows.Forms.TextBox txtHR;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label lblRR;
        private System.Windows.Forms.Label lblO2;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblVitals;
        private System.Windows.Forms.TabPage tbViewChart;
        private System.Windows.Forms.ComboBox cmbxSelectViewPatient;
        private System.Windows.Forms.Label lblSelectViewPatient;
        private System.Windows.Forms.RichTextBox txtChartDisplay;
    }
}