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
            //place the panel in here then later on work on the containing element
            appointmentDetails[1] = pnlDate;
            appointmentDetails[2] = pnlTime;
            appointmentDetails[3] = txtDescription;
            appointmentDetails[4] = pnlTitle;
            appointmentDetails[5] = txtFName;
            appointmentDetails[6] = txtSName;
            if (CheckValidation(appointmentDetails))
            {
                //TODO: check order of data entry
                DBAccess.postData("newAppointment", appointmentDetails[0].Text, appointmentDetails[1].Controls[0].Text, appointmentDetails[2].Controls[0].Text, appointmentDetails[3].Text, appointmentDetails[4].Controls[0].Text, appointmentDetails[5].Text, appointmentDetails[6].Text);
                Utilities.toDashboard(sender, e, this);
            }
        }
        private bool CheckValidation(Control[] appointmentDetails)
        {
            bool result = false;
            string errorMsg = "";
            bool[] valid = new bool[7];
            valid[0] = Utilities.NHNumberValidation(txtNHNumber);
            valid[1] = Utilities.DateBookingValidation(dtpDate);
            valid[2] = Utilities.ComboBoxValidation(cbTime);
            valid[3] = Utilities.ComboBoxValidation(cbTitle);
            valid[4] = Utilities.NameValidation(txtFName);
            valid[5] = Utilities.NameValidation(txtSName);
            valid[6] = Utilities.DescriptionValidation(txtDescription);
            //searches through the how valid array after all controls have been checked, and prints errors respectively
            for (int i = 0; i < valid.Length; i++)
            {
                if (valid[i] == false)
                {
                    //TODO: appointment details entries for dtp and dropdown needs to be set as the panel for this to work
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
               // DBAccess.Delete("deleteAppointment", txtNHNumber.Text, dtpDate.Value, cbTime.Text);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataSet dataSet;
            DataTable table;

            if (e.KeyChar == (char)13)
            {
                // Define a dataSet from DBAccess with the SQL statement

                dataSet = DBAccess.getData("patientAppointmentsEdit", txtSearch.Text);
                //Define a datatable with the tables from the dataset return
                table = dataSet.Tables[0];

                Console.WriteLine(table.Rows.Count);

                Utilities.CheckForResults(dgvAppointments, table);

            }
        }
  
        private void dgvCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNHNumber.Text = dgvAppointments.Rows[e.RowIndex].Cells[0].Value.ToString();
           //TODO: BUG  - ERROR CAN BE THROWN HERE WHEN THE EDITING DATE IS BEFORE CURRENT DATE
            dtpDate.Value = (DateTime)dgvAppointments.Rows[e.RowIndex].Cells[3].Value;
            cbTime.Text = dgvAppointments.Rows[e.RowIndex].Cells[4].Value.ToString();

            //comboTitle.Text = dgvAppointments.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtFName.Text = dgvAppointments.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtSName.Text = dgvAppointments.Rows[e.RowIndex].Cells[5].Value.ToString();

            txtDescription.Text = dgvAppointments.Rows[e.RowIndex].Cells[6].Value.ToString();
                    }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
