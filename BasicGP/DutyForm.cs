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
    public partial class DutyForm : Form
    {
        public DutyForm()
        {
            InitializeComponent();
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            GetDuty(DateTime.Today.DayOfWeek.ToString());
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Utilities.toDashboard(sender, e, this);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GetDuty(string dayOfWeek)
        {
            DataSet dataSet = DBAccess.getData("duty", dayOfWeek);
            DataTable table = dataSet.Tables[0];

            dgvDuty.DataSource = table;
        }

        private void mcDutyDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            GetDuty(mcDutyDate.SelectionStart.DayOfWeek.ToString());
            
        }

        private void dgvCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Clicked");
            //gets the employee title from the dgv and clicked cell
            string title = dgvDuty.Rows[e.RowIndex].Cells[0].Value.ToString();
            //gets the employee firstname from the dgv and clicked cell
            string firstname = dgvDuty.Rows[e.RowIndex].Cells[1].Value.ToString();
            //gets the employee last name from the dgv and clicked cell
            string lastname = dgvDuty.Rows[e.RowIndex].Cells[2].Value.ToString();
            DataSet dataSetAvailability = DBAccess.getData("employeeID", title, firstname, lastname);
            DataTable tableAvailabilty = dataSetAvailability.Tables[0];
            DataSet datasetEID = DBAccess.getData("employeeID", title, firstname, lastname);
            int employeeID = Int32.Parse(datasetEID.Tables[0].Rows[0].ItemArray[0].ToString());
            //sets every time back to available before it gets changed
            for (int i = 1; i < 40; i += 2)
            {
                tableLayout.Controls[i].BackColor = Color.PaleGreen;
                tableLayout.Controls[i].Text = "Available";
            }
            ShowTimes(employeeID);
        }
        private void ShowTimes(int employeeID)
        {
            //uses the employeeID and the selected date to return all of their appointment times on that day
            DataSet dsTest = DBAccess.getData("showEmployeeAvailability", employeeID.ToString(), mcDutyDate.SelectionStart.ToShortDateString());
            DataTable table = dsTest.Tables[0];

            //loops through all of the returned rows, and therefore all the times in that day that the employee has appointments
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //loops through all of the times on the page
                for (int j = 0; j < 40; j += 2)
                {//j is the time labels, it increments by 2 because the the odd numbers are the available labels
                    //if the appointment time matches one of the time labels time then change the colour and text of the opposite item
                    if (table.Rows[i].ItemArray[4].ToString().Equals(tableLayout.Controls[j].Text + ":00"))
                    {
                        tableLayout.Controls[j + 1].BackColor = Color.LightCoral;
                        tableLayout.Controls[j + 1].Text = "Not Available";
                    }
                }
            }

        }
    }
}