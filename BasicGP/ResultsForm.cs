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

        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Visible = false;
            dashboard.Visible = true;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // TODO: Send this all to backend
            //If the return key is pressed, sent a login button click event
            if (e.KeyChar == (char)13)
            {
                string[] data = new string[1];
                // Define a dataSet from DBAccess with the SQL statement
                DataSet dataSet = DBAccess.getData("findPatient", txtInput.Text);
                //Define a datatable with the tables from the dataset return
                DataTable table = dataSet.Tables[0];

                Console.WriteLine(table.Rows.Count);

                if (table.Rows.Count > 0)
                {
                    dgvPatients.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No data was found");
                }
            }
        }
        /// <summary>
        /// when a cell is double clicked on a dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPatients.Visible = false;
            tcResults.Visible = true;
            
            string[] data = new string[1];
            //https://stackoverflow.com/questions/5571963/how-to-get-datagridview-cell-value-in-messagebox
            //finds the NHNumber of whichever row was clicked on
            DataSet dataSetAppointments = DBAccess.getData("patientAppointments", dgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable tableAppointments = dataSetAppointments.Tables[0];
            CheckForResults(tableAppointments, dgvAppointments);

            DataSet dataSetPrescriptions = DBAccess.getData("patientPresciptions", dgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable tablePrescriptions = dataSetAppointments.Tables[0];
            CheckForResults(tablePrescriptions, dgvPrescriptions);

            DataSet dataSetResults = DBAccess.getData("testResults", dgvPatients.Rows[e.RowIndex].Cells[0].Value.ToString());
            DataTable tableResults = dataSetResults.Tables[0];
            CheckForResults(tableResults, dgvResults);

            Console.WriteLine(tableAppointments.Rows.Count);

        }
        //seperating this into a method allows it to work on all three dgvs without writing it over and over again
        private void CheckForResults(DataTable dt, DataGridView dgv)
        {
            if (dt.Rows.Count > 0)
            {
                dgv.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No appointments were found");
            }
        }
    }
}
