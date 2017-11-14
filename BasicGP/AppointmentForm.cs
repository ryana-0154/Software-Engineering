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
            
            Control[] appointmentDetails = new Control[7];
            appointmentDetails[0] = txtNHNumber;
            appointmentDetails[1] = dtpDate;
            appointmentDetails[2] = dtpTime;
            appointmentDetails[3] = comboTitle;
            appointmentDetails[4] = txtFName;
            appointmentDetails[5] = txtSName;
            appointmentDetails[6] = txtDescription;
            CheckValidation(appointmentDetails);
            // TODO: Fix this
            DBAccess.postData("newAppointment",appointmentDetails[0].Text,appointmentDetails[1].ToString(),appointmentDetails[2].ToString(),appointmentDetails[4].Text,appointmentDetails[5].Text, appointmentDetails[6].Text);

            Utilities.toDashboard(sender, e, this);
        }
        private bool CheckValidation(Control[] appointmentDetails)
        {
            bool result = false;
            string errorMsg = "";
            bool[] valid = new bool[7];
            valid[0] = Utilities.NHNumberValidation(txtNHNumber);
            valid[1] = Utilities.DateBookingValidation(dtpDate);
            valid[2] = Utilities.TimeBookingValidation(dtpTime);
            valid[3] = Utilities.TitleValidation(comboTitle);
            valid[4] = Utilities.NameValidation(txtFName);
            valid[5] = Utilities.NameValidation(txtSName);
            valid[6] = Utilities.DescriptionValidation(txtDescription);
            //searches through the how valid array after all controls have been checked, and prints errors respectively
            for (int i = 0; i < valid.Length; i++)
            {
                if (valid[i] == false)
                {
                    errorMsg = Utilities.validation_failed(appointmentDetails[i], lblErrorMsg, btnSubmit, errorMsg);
                }
            }
            lblErrorMsg.Text = errorMsg;
            lblErrorMsg.Visible = true;
            if (!valid.Contains(false))
            {
                result = true;
            }
            return result;
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
