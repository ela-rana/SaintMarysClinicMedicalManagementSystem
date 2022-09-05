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
    public partial class FormAdminPortal : Form
    {
        MMSCRUD mms;
        Employee loggedInEmployee;
        MMSUser loggedInUser;

        public string CurrentLoggedInEmail { get; set; }
        public FormAdminPortal()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void FormAdminPortal_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            dtgrdApptDisplay.DataSource = mms.GetAllAppointments();
        }
    }
}
