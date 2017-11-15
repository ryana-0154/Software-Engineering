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

        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Utilities.toDashboard(sender, e, this);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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
                MessageBox.Show("No data was found");
            }
        }
        
        private void mcDutyDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DataSet dataSet = DBAccess.getData("duty", mcDutyDate.SelectionStart.DayOfWeek.ToString());
            
            DataTable table = dataSet.Tables[0];
            
            dgvDuty.DataSource = table;
            
        }
    }
}