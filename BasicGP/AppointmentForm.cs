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
            Dashboard dashboard = new Dashboard();
            this.Visible = false;
            dashboard.Visible = true;
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

            //TODO: check this, should we just overload the method instead???
            toDashboard(sender, e);
        }
        /// <summary>
        /// is called when the logo is clicked, can also be called from in code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toDashboard(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Visible = true;
        }
    }
}
