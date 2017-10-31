using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
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

        #region Lowells Code
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
        /// <summary>
        /// a text validation method which checks the length of the compulsory fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtText_validation(object sender, EventArgs e)
        {
            TextBox boxInput = (TextBox)sender;
            if (boxInput.Text != "")
            {
                switch (boxInput.Name)
                {
                    case "lblFName":
                        //checks to see if the input is less that or equal to 16 bits and is only letters
                        if (boxInput.Text.Length <= 16 && Regex.IsMatch(boxInput.Text, @"^[\p{L}]+$"))
                        {
                            //passes validation
                        }
                        break;
                    case "lblSName":
                        if (boxInput.Text.Length <= 16 && Regex.IsMatch(boxInput.Text, @"^[\p{L}]+$"))
                        {

                        }
                        break;
                    case "lblAddress":
                        break;
                    default:
                        break;
                }
            }
            else
            {
                //TODO: implement this as a popup label
                Console.WriteLine("you need to enter Text here");
                boxInput.BackColor = Color.LightCoral;
                btnSubmit.Enabled = false;
            }
        }

                /// <summary>
/// A validation check to make sure number fields are numbers and correct length
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
                private void txtNumber_validation(object sender, EventArgs e)
        {
            TextBox boxInput = (TextBox)sender;
            //if there is something in there and it is a number
            if (boxInput.Text != "" && int.TryParse(boxInput.Text, out int input))
            {
                //assuming NHNumber is meant to be 10 digits
                if (boxInput.Name == "txtNHNumber" && boxInput.Text.Length == 10)
                {
                    //passes the validation
                    btnSubmit.Enabled = true;
                    boxInput.BackColor = Color.White;
                    return;
                }
                else if (boxInput.Name == "txtPhoneNumber" && boxInput.Text.Length == 11)
                {
                    //passes the validation
                    btnSubmit.Enabled = true;
                    boxInput.BackColor = Color.White;
                    return;
                }
                else
                {
                    //TODO: implement this as a popup label
                    Console.WriteLine("Entry is incorrect length");
                    boxInput.BackColor = Color.LightCoral;
                    btnSubmit.Enabled = false;
                }
            }
            else {
                //TODO: implement this as a popup label
                Console.WriteLine("you need to enter number");
                boxInput.BackColor = Color.LightCoral;
                btnSubmit.Enabled = false;
            }

         }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Visible = true;
        }
    }
}
