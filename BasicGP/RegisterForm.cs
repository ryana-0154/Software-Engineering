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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // I'm only doing the following bits of code so that we can easily pass into DBAccess when it is created
            string fName, sName, title, address, allergies, nhNumber, phone;
            string dob;
            bool diabetic, smoker, asthmatic;

            nhNumber = txtNHNumber.Text;
            fName = txtFName.Text;
            sName = txtSName.Text;
            title = comboTitle.Text;
            dob = dtpDOB.Text;
            phone = txtPhoneNumber.Text;
            address = txtAddress.Text;
            allergies = txtAllergies.Text;
            diabetic = cbDiabetes.Checked;
            smoker = cbSmoker.Checked;
            asthmatic = cbAsthmatic.Checked;
        }
    }
}
