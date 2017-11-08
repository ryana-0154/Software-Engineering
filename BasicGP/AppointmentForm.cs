using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGP
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            Utilities.toDashboard(sender, e, this);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //CheckValidation();
            string[] appointmentDetails = new string[5];

            appointmentDetails[0] = dtpDate.ToString();
            appointmentDetails[1] = dtpTime.ToString();
            appointmentDetails[2] = comboTitle.Text;
            appointmentDetails[3] = txtFName + " " + txtSName;
            appointmentDetails[4] = txtDescription.Text;
          
            // TODO: Fix this
            //DBAccess.postData("newAppointment",);
            
            Utilities.toDashboard(sender, e,this);
        }
        private bool CheckValidation()
        {
            bool result = false;
            bool[] valid = new bool[6];
            valid[2] = Utilities.TitleValidation(comboTitle);
            valid[3] = Utilities.NameValidation(txtFName);
            valid[4] = Utilities.NameValidation(txtSName);
            valid[5] = Utilities.DescriptionValidation(txtDescription);

            return result;
        }
    }
}
