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
    }
}