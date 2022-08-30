﻿
namespace SaintMarysClinicMedicalManagementSystem
{
    partial class UsrCtrlSplashMenu
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
            this.lblYouMustLogin = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblNewUsers = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblReturningUsers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblYouMustLogin
            // 
            this.lblYouMustLogin.AutoSize = true;
            this.lblYouMustLogin.Location = new System.Drawing.Point(125, 249);
            this.lblYouMustLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYouMustLogin.Name = "lblYouMustLogin";
            this.lblYouMustLogin.Size = new System.Drawing.Size(273, 16);
            this.lblYouMustLogin.TabIndex = 4;
            this.lblYouMustLogin.Text = "You must be logged in to use the account";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(288, 196);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 28);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblNewUsers
            // 
            this.lblNewUsers.AutoSize = true;
            this.lblNewUsers.Location = new System.Drawing.Point(299, 176);
            this.lblNewUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUsers.Name = "lblNewUsers";
            this.lblNewUsers.Size = new System.Drawing.Size(76, 16);
            this.lblNewUsers.TabIndex = 3;
            this.lblNewUsers.Text = "New Users";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(128, 196);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblReturningUsers
            // 
            this.lblReturningUsers.AutoSize = true;
            this.lblReturningUsers.Location = new System.Drawing.Point(125, 176);
            this.lblReturningUsers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturningUsers.Name = "lblReturningUsers";
            this.lblReturningUsers.Size = new System.Drawing.Size(111, 16);
            this.lblReturningUsers.TabIndex = 1;
            this.lblReturningUsers.Text = "Returning Users";
            // 
            // UsrCtrlSplashMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.lblYouMustLogin);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblReturningUsers);
            this.Controls.Add(this.lblNewUsers);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsrCtrlSplashMenu";
            this.Size = new System.Drawing.Size(560, 540);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYouMustLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblNewUsers;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblReturningUsers;
    }
}
