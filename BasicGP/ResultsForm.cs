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
            // TODO: This line of code loads data into the 'database1DataSet.patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.database1DataSet.patient);
            Console.WriteLine("Results Form Loaded");

        }
        //TODO: REMOVE ME
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Console.WriteLine("MEME");
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Visible = true;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If the return key is pressed, sent a login button click event
            if (e.KeyChar == (char)13)
            {
                string[] data = new string[1];
                data[0] = "Find Patient";
                DBAccess.getData(data);
            }
        }
    }
}
