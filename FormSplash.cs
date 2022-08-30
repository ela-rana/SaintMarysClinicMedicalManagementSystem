using System;
using System.Windows.Forms;

namespace SaintMarysClinicMedicalManagementSystem
{
    /// <summary>
    /// To create a splash screen (temporary welcome screen) that appears upon opening the app
    /// </summary>
    public partial class FormSplash : Form
    {

        //Constructor
        public FormSplash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            this.Close();   //to close our splash screen form when the full interval of the timer is complete
        }
    }
}
