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
        //attributes
        bool isEdting = false;
        string appointmentID = "";
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
            appointmentDetails[3] = pnlTitle;
            appointmentDetails[4] = txtFName;
            appointmentDetails[5] = txtSName;
            appointmentDetails[6] = txtDescription;

            if (CheckValidation(appointmentDetails))
            {
                if (isEdting == false)
                {
                    //TODO: check order of data entry
                    DBAccess.postData("newAppointment", appointmentDetails[0].Text, appointmentDetails[1].Controls[0].Text, appointmentDetails[2].Controls[0].Text, appointmentDetails[3].Controls[0].Text, appointmentDetails[4].Text, appointmentDetails[5].Text, appointmentDetails[6].Text);
                }
                else
                {
                    //finds the employee ID of the new employee associated with the appointment
                    DataSet dataSet = DBAccess.getData("employeeID", appointmentDetails[3].Controls[0].Text, appointmentDetails[4].Text, appointmentDetails[5].Text);
                    DataTable table = dataSet.Tables[0];
                    // Put the value of the row returned into employeeid
                    int employeeID = Int32.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());

                    EditAppointment(employeeID, appointmentDetails[0].Text, pnlDate.Controls[0].Text, pnlTime.Controls[0].Text, appointmentDetails[6].Text, appointmentID);
                }

                Utilities.toDashboard(sender, e, this);
            }

            
        }
        private bool CheckValidation(Control[] appointmentDetails)
        {
            bool result = false;
            string errorMsg = "";
            bool[] valid = new bool[7];
            valid[0] = Utilities.NHNumberValidation(txtNHNumber.Text);
            valid[1] = Utilities.DateBookingValidation(dtpDate.Value);
            valid[2] = Utilities.ComboBoxValidation(cbTime.SelectedIndex);
            valid[3] = Utilities.ComboBoxValidation(cbTitle.SelectedIndex);
            //valid[4] = Utilities.NameValidation(txtFName);
            for (int i = 4; i <= 5; i++)
            {
                valid[i] = Utilities.NameValidation(appointmentDetails[i].Text);
            }
            //valid[5] = Utilities.NameValidation(txtSName);
            valid[6] = Utilities.DescriptionValidation(txtDescription.Text);
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
        private bool CheckEmployeeIsAvailable()
        {
            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete appointment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               DBAccess.deleteData(txtNHNumber.Text, dtpDate.Value.ToString(), cbTime.Text);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataSet dataSet;
            DataTable table;

            if (e.KeyChar == (char)13)
            {
                // Define a dataSet from DBAccess with the SQL statement

                dataSet = DBAccess.getData("patientAppointmentsView", txtSearch.Text);
                //Define a datatable with the tables from the dataset return
                table = dataSet.Tables[0];

                Console.WriteLine(table.Rows.Count);

                Utilities.CheckForResults(dgvAppointments, table);

            }
        }

        private void dgvCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet dataSet = DBAccess.getData("patientAppointmentsEdit", txtSearch.Text);
            DataTable table = dataSet.Tables[0];
            txtNHNumber.Text = table.Rows[e.RowIndex].ItemArray[0].ToString();
            dtpDate.Value = DateTime.Parse(table.Rows[e.RowIndex].ItemArray[1].ToString());
            DateTime time = DateTime.Parse(table.Rows[e.RowIndex].ItemArray[2].ToString());
            cbTime.Text = time.ToShortTimeString();
            cbTitle.Text = table.Rows[e.RowIndex].ItemArray[3].ToString();
            txtFName.Text = table.Rows[e.RowIndex].ItemArray[4].ToString();
            txtSName.Text = table.Rows[e.RowIndex].ItemArray[5].ToString();
            txtDescription.Text = table.Rows[e.RowIndex].ItemArray[6].ToString();
            appointmentID = table.Rows[e.RowIndex].ItemArray[7].ToString();
            ChangeToEdit();

        }
        /// <summary>
        /// changes all of the visuals on the form to look like editing then sets a bool flag isEditing to true;
        /// </summary>
        private void ChangeToEdit()
        {
            lblTitle.Text = "Edit appointment";
            btnDelete.Visible = true;
            picBackButton.Visible = true;
            isEdting = true;
            //TODO: implement a back button to go from edit to register
        }
        /// <summary>
        /// changes all of the visuals on the form to look like a new appointment form
        /// </summary>
        private void ChangeToNew()
        {
            lblTitle.Text = "New appointment";
            btnDelete.Visible = false;
            picBackButton.Visible = false;
            isEdting = false;
            txtNHNumber.Text = "";
            dtpDate.ResetText();
            cbTime.SelectedIndex = -1;
            cbTitle.SelectedIndex = -1;
            txtFName.Text = "";
            txtSName.Text = "";
        }

        private void EditAppointment(int eID, string NHNumber, string date, string time, string desc, string aID)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this appointment?", "Edit appointment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBAccess.updateData("editAppointment", eID.ToString(), NHNumber, date, time, desc, aID);
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            ChangeToNew();
        }
    }
}
