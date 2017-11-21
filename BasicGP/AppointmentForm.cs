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
        string appointmentID;

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
                if (isEdting == false)
                {
                    //TODO: check order of data entry
                    DBAccess.postData("newAppointment", appointmentDetails[0].Text, appointmentDetails[1].Controls[0].Text, appointmentDetails[2].Controls[0].Text, appointmentDetails[3].Text, appointmentDetails[4].Controls[0].Text, appointmentDetails[5].Text, appointmentDetails[6].Text);
                }
                else
                {
                    DataSet dataSet = DBAccess.getData("employeeID", pnlTitle.Controls[0].Text, txtFName.Text, txtSName.Text);
                    DataTable table = dataSet.Tables[0];
                    // Put the value of the row returned into employeeid
                    int employeeID = Int32.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());

                    EditAppointment(employeeID, Int32.Parse(txtNHNumber.Text), pnlDate.Controls[0].Text, pnlTime.Controls[0].Text, txtDescription.Text, appointmentID);
                }

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
        private bool CheckEmployeeIsAvailable()
        {
            return true;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Delete appointment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               DBAccess.deleteData(txtNHNumber.Text, dtpDate.Text, cbTime.Text);
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
            //TODO: BUG  - ERROR CAN BE THROWN HERE WHEN THE EDITING DATE IS BEFORE CURRENT DATE
            dtpDate.Value = DateTime.Parse(table.Rows[e.RowIndex].ItemArray[3].ToString());

            #region not sure why we need this
            // Variables to hold the title, fname and sname pulled from the dgvAppointments
            string title = dgvAppointments.Rows[e.RowIndex].Cells[0].Value.ToString();
            string fName = dgvAppointments.Rows[e.RowIndex].Cells[1].Value.ToString();
            string sName = dgvAppointments.Rows[e.RowIndex].Cells[2].Value.ToString();
            
            // Reuse dataset & table from above
            dataSet = DBAccess.getData("employeeID", title, fName, sName);
            table = dataSet.Tables[0];
            // Put the value of the row returned into employeeid
            int employeeID = Int32.Parse(dataSet.Tables[0].Rows[0].ItemArray[0].ToString());
            #endregion

            string time = dgvAppointments.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            //TODO: get this data from employee table - Really?
            cbTitle.Text = title;
            txtFName.Text = fName;
            txtSName.Text = sName;
            cbTime.Text = time.Substring(0, time.Length-3);
            
            txtDescription.Text = dgvAppointments.Rows[e.RowIndex].Cells[5].Value.ToString();

            //TODO: Fix this
            //dataSet = DBAccess.getData("getAppointmentID", employeeID.ToString(), txtNHNumber.Text, dtpDate.Value.ToShortDateString(), cbTime.Text);
            //table = dataSet.Tables[0];
            //appointmentID = table.Rows[0].ItemArray[0].ToString();

            ChangeToEdit();
        }
        private void ChangeToEdit()
        {
            lblTitle.Text = "Edit appointment";
            btnDelete.Visible = true;
            //TODO: change the method that is called on the event click btnSubmit
            
            isEdting = true;
            //TODO: implement a back button to go from edit to register
        }

        private void EditAppointment(int eID, int NHNumber, string date, string time, string desc, string aID)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this appointment?", "Edit appointment", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBAccess.updateData("editAppointment", eID.ToString(), NHNumber.ToString(), date, time, desc, aID);
            }
        }
        
        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
