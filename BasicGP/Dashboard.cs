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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //Is this bad coding practice to repeat everytime???
            this.Visible = false;
            new RegisterForm().Visible = true;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            //and here repeated
            this.Visible = false;
            new ResultsForm().Visible = true;
        }

        private void BtnManage_Click(object sender, EventArgs e)
        {
            Visible = false;
            new AppointmentForm().Visible = true;
        }

        private void BtnAvailability_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new DutyForm().Visible = true;
        }
    }
}
