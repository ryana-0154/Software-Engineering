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
        //Lowells Code
        #region
        /*
        //attributes
        string[] patientDetails = new string[8];
        bool[] additionalInfo = new bool[3];
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            patientDetails[0] = txtNHNumber.Text;
            patientDetails[1] = txtFName.Text;
            patientDetails[2] = txtSName.Text;
            patientDetails[3] = comboTitle.Text;
            patientDetails[4] = dtpDOB.Text;
            patientDetails[5] = txtPhoneNumber.Text;
            patientDetails[6] = txtAddress.Text;
            patientDetails[7] = txtAllergies.Text;

            additionalInfo[0] = cbDiabetes.Checked;
            additionalInfo[1] = cbSmoker.Checked;
            additionalInfo[2] = cbAsthmatic.Checked;
        }
        */
        #endregion
    }
}
