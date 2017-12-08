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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            DataSet dataSet = DBAccess.getData("selectAllPatients", "0");
            DataTable table = dataSet.Tables[0];
            Utilities.CheckForResults(dgvPatients, table);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Visible = false;
            dashboard.Visible = true;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataSet dataSet;
            DataTable table;

            // TODO: Send this all to backend
            //If the return key is pressed, sent a login button click event
            if (e.KeyChar == (char)13)
            {
                // Define a dataSet from DBAccess with the SQL statement
                if (rdbNHNumber.Checked)
                {
                    dataSet = DBAccess.getData("findPatient", "id", txtInput.Text);
                }
                //and therefore the other button is checked
                else
                {// Define a dataSet from DBAccess with the SQL statement
                    dataSet = DBAccess.getData("findPatient", "name&dob", txtInput.Text, dtpDOB.Text);
                }
                //Define a datatable with the tables from the dataset return
                table = dataSet.Tables[0];

                Console.WriteLine(table.Rows.Count);

                Utilities.CheckForResults(dgvPatients, table);

            }

        }


        int NHNumber;

        /// <summary>
        /// when a cell is double clicked on a dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PatientSelect(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: THERE IS BUG WHEN YOU DOUBLE CLICK MIDDLE LINE
            dgvPatients.Visible = false;
            tcResults.Visible = true;
            lblPatientName.Visible = true;
            
            lblPatientName.Text = dgvPatients.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd() +" " + dgvPatients.Rows[e.RowIndex].Cells[1].Value.ToString();
            //TODO: make this easier to understand, rename it?
            NHNumber = e.RowIndex;

            string[] data = new string[1];
            //https://stackoverflow.com/questions/5571963/how-to-get-datagridview-cell-value-in-messagebox
            //finds the NHNumber of whichever row was clicked on
            DataSet dataSetAppointments = DBAccess.getData("patientAppointments", dgvPatients.Rows[NHNumber].Cells[0].Value.ToString());
            DataTable tableAppointments = dataSetAppointments.Tables[0];
            Utilities.CheckForResults(dgvAppointments, tableAppointments);

            Console.WriteLine(tableAppointments.Rows.Count);

        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lblPrompt.Text = "Full Name: ";
            lblDOB.Visible = true;
            dtpDOB.Visible = true;
        }

        private void rdbNHNumber_CheckedChanged(object sender, EventArgs e)
        {
            lblPrompt.Text = "National Health Number: ";
            lblDOB.Visible = false;
            dtpDOB.Visible = false;
        }

        private void tcResults_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0:
                    DataSet dataSetAppointments = DBAccess.getData("patientAppointments", dgvPatients.Rows[NHNumber].Cells[0].Value.ToString());
                    DataTable tableAppointments = dataSetAppointments.Tables[0];
                    Utilities.CheckForResults(dgvAppointments, tableAppointments);
                    break;
                case 1:
                    DataSet dataSetPrescriptions = DBAccess.getData("patientPresciptions", dgvPatients.Rows[NHNumber].Cells[0].Value.ToString());
                    DataTable tablePrescriptions = dataSetPrescriptions.Tables[0];
                    Utilities.CheckForResults(dgvPrescriptions, tablePrescriptions);
                    break;
                case 2:
                    DataSet dataSetResults = DBAccess.getData("testResults", dgvPatients.Rows[NHNumber].Cells[0].Value.ToString());
                    DataTable tableResults = dataSetResults.Tables[0];
                    Utilities.CheckForResults(dgvResults, tableResults);
                    break;
                default:
                    break;
            }
        }

        private void PrescriptionClick(object sender, DataGridViewCellEventArgs e)
        {
            //these will be found from the DB
            int prescriptionID;
            int prescriptionDuration;
            string presciptionName = dgvPrescriptions.Rows[e.RowIndex].Cells[1].Value.ToString();
            int.TryParse(dgvPrescriptions.Rows[e.RowIndex].Cells[0].Value.ToString(), out prescriptionID);
            int.TryParse(dgvPrescriptions.Rows[e.RowIndex].Cells[3].Value.ToString(), out prescriptionDuration);
            DateTime prescriptionDate = (DateTime)dgvPrescriptions.Rows[e.RowIndex].Cells[2].Value;
            //if the duration of the prescription has ran out
            if (DateTime.Compare(prescriptionDate.AddDays(prescriptionDuration), DateTime.Today) < 0)
            {
                //https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
                DialogResult result = MessageBox.Show("Would you like to extend: " + Environment.NewLine + presciptionName + " for another " + prescriptionDuration + " days.", "Extend Prescription", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ExtendPrescription(prescriptionID);
                }
            }
            else
            {
                MessageBox.Show("Cannot extend this prescription as it is still active.");
            }

        }
        private void ExtendPrescription(int prescriptionID)
        {
            DBAccess.updateData("extendPrescription", prescriptionID.ToString());
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataSet dataSet;
        DataTable table;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Define a dataSet from DBAccess with the SQL statement
            if (rdbNHNumber.Checked)
            {
                dataSet = DBAccess.getData("findPatient", "id", txtInput.Text);
            }
            //and therefore the other button is checked
            else
            {// Define a dataSet from DBAccess with the SQL statement
                dataSet = DBAccess.getData("findPatient", "name&dob", txtInput.Text, dtpDOB.Text);
            }
            //Define a datatable with the tables from the dataset return
            table = dataSet.Tables[0];

            Console.WriteLine(table.Rows.Count);

            Utilities.CheckForResults(dgvPatients, table);

        }
    }
}
