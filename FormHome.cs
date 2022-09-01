using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SaintMarysClinicMedicalManagementSystem
{
    public partial class FormHome : Form
    {
        //to create a static object of the FormHome so that we can use it to create a public Instance of our Home Form
        //that can be accessed by other user controls and forms
        static FormHome _formHomeObj;

        //to create a public Instance of our current form so that it can be accessed by other forms and its panel can
        //be accessed by the other user controls that will be displayed in its panel
        public static FormHome Instance
        {
            get
            {
                if (_formHomeObj == null)
                {
                    _formHomeObj = new FormHome();
                }
                return _formHomeObj;
            }
        }

        //to create a public property to represent our pnlHome panel toolbox field for the panel displayed in our Home Form
        //We are making it public so the other user controls can access it and display in it
        public Panel HomePanel
        {
            get { return pnlHome; }
            set { pnlHome = value; }
        }

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            _formHomeObj = this;   //to set our current form object to the current form
            UsrCtrlHomeMenu ucHome = new UsrCtrlHomeMenu(); //to create a Home menu user control object
            pnlHome.Controls.Add(ucHome); //in our Home Panel, display the Home menu user control when
                                          //the form loads
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
