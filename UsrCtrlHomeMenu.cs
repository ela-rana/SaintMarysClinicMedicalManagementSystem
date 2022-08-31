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
                UsrCtrlLogin ucLogin = new UsrCtrlLogin();
                FormHome.Instance.HomePanel.Controls.Add(ucLogin);
            }
            FormHome.Instance.HomePanel.Controls["UsrCtrlLogin"].BringToFront();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!FormHome.Instance.HomePanel.Controls.ContainsKey("UsrCtrlSignUp"))
            {
                UsrCtrlSignUp ucSignUp = new UsrCtrlSignUp();
                FormHome.Instance.HomePanel.Controls.Add(ucSignUp);
            }
            FormHome.Instance.HomePanel.Controls["UsrCtrlSignUp"].BringToFront();
        }
    }
}
