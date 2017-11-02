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
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
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
            //we can find the row index but not whats in that row
            Console.WriteLine(e.RowIndex);
            
        }
    }
}
