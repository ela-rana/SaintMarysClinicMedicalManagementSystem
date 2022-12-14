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
    public partial class BrowsePatientDialog : Form
    {
        MMSCRUD mms;
        public BrowsePatientDialog()
        {
            InitializeComponent();
        }

        private void BrowsePatientDialog_Load(object sender, EventArgs e)
        {
            mms = new MMSCRUD();
            dtgrdBrowse.DataSource = mms.GetAllPatientUsers();
            dtgrdBrowse.Columns[1].Visible = false;
            dtgrdBrowse.Columns[2].Visible = false;
            dtgrdBrowse.Columns[6].Visible = false;
            dtgrdBrowse.Columns[8].Visible = false;
            dtgrdBrowse.Columns[9].Visible = false;
            dtgrdBrowse.Columns[10].Visible = false;
            dtgrdBrowse.Columns[11].Visible = false;
            dtgrdBrowse.Columns[12].Visible = false;
            dtgrdBrowse.Columns[13].Visible = false;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int id;
            bool parsed = Int32.TryParse(dtgrdBrowse.CurrentRow.Cells[0].Value.ToString(), out id);
            if (parsed)
            {
                FormAdminPortal.instance.TxtBxPatientID.Text = id.ToString();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please make a selection before clicking the Select Patient button");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
