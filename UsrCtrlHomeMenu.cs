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
    public partial class UsrCtrlHomeMenu : UserControl
    {
        public UsrCtrlHomeMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!FormHome.Instance.HomePanel.Controls.ContainsKey("UsrCtrlLogin"))
            {
                UsrCtrlLogin uc = new UsrCtrlLogin();
                FormHome.Instance.HomePanel.Controls.Add(uc);
            }
            FormHome.Instance.HomePanel.Controls["UsrCtrlLogin"].BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!FormHome.Instance.HomePanel.Controls.ContainsKey("UsrCtrlSignUp"))
            {
                UsrCtrlSignUp uc = new UsrCtrlSignUp();
                FormHome.Instance.HomePanel.Controls.Add(uc);
            }
            FormHome.Instance.HomePanel.Controls["UsrCtrlSignUp"].BringToFront();
        }
    }
}
