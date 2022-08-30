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
    public partial class UsrCtrlSplashMenu : UserControl
    {
        public UsrCtrlSplashMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //FormStart f1 = new FormStart();
           // f1.usrctrlLogin1.Visible = true;
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
