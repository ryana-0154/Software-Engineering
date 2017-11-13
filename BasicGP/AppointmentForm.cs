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

            Utilities.toDashboard(sender, e, this);
        }
        private bool CheckValidation()
        {
            bool result = false;
            bool[] valid = new bool[6];
            valid[0] = false;//this will be the nhnumber
            valid[1] = Utilities.DateBookingValidation(dtpDate);
            valid[2] = Utilities.TimeBookingValidation(dtpTime);
            valid[3] = Utilities.TitleValidation(comboTitle);
            valid[4] = Utilities.NameValidation(txtFName);
            valid[5] = Utilities.NameValidation(txtSName);
            valid[6] = Utilities.DescriptionValidation(txtDescription);

            return result;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete appointment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //DBAccess.Delete("deleteAppointment", txtNHNumber.Text, dtpDate.Value, dtpTime.Value);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataSet dataSet;
            DataTable table;

            if (e.KeyChar == (char)13)
            {
                // Define a dataSet from DBAccess with the SQL statement

                dataSet = DBAccess.getData("findPatient", "id", txtSearch.Text);
                //Define a datatable with the tables from the dataset return
                table = dataSet.Tables[0];

                Console.WriteLine(table.Rows.Count);

                if (table.Rows.Count > 0)
                {
                    dgvAppointments.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No data was found");
                }
            }
        }
    }
}
