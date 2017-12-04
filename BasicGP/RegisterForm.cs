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

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                //attributes
                string[] patientDetails = new string[6];
                bool[] additionalInfo = new bool[3];
                string address = ConcatAddress();
                Console.WriteLine(address);
                //TODO: cahnge from bool and string arrays to just one Control data type array
                patientDetails[0] = txtFName.Text + " " + txtSName.Text; // data[2]
                patientDetails[1] = comboTitle.Text; // data[3]
                patientDetails[2] = dtpDOB.Text; // data[4]
                patientDetails[3] = txtPhoneNumber.Text; // data[5]
                patientDetails[4] = address; // data[6]
                patientDetails[5] = txtAllergies.Text; // data[7]

                additionalInfo[0] = cbDiabetes.Checked; // data[8]
                additionalInfo[1] = cbSmoker.Checked; // data[9]
                additionalInfo[2] = cbAsthmatic.Checked; // data[10]

                DBAccess.postData("registerPatient", patientDetails[0], patientDetails[1], patientDetails[2], patientDetails[3],
                    patientDetails[4], patientDetails[5], additionalInfo[0].ToString(), additionalInfo[1].ToString(), additionalInfo[2].ToString());

                Utilities.toDashboard(sender, e, this);
            }
        }

        /// <summary>
        /// a seperate method to build the address string, it allows for the user to only fill the first address line
        /// </summary>
        /// <returns></returns>
        private string ConcatAddress()
        {
            string address = txtAddress1.Text;
            if (txtAddress2.Text != "")
            {
                address += ", " + txtAddress2.Text;
                if (txtAddress3.Text != "")
                {
                    address += ", " + txtAddress3.Text;
                }
            }
            return address;
        }

        /// <summary>
        /// gets the data from each text box and checks each one with its designated validation method in utlities then handles the results
        /// </summary>
        /// <returns></returns>
        private Boolean CheckValidation()
        {
            bool result = false;
            string errorMsg = "";
            Boolean[] valid = new bool[8];
            Control[] userInputs = new Control[8];

            userInputs[0] = txtFName;
            userInputs[1] = txtSName;
            // these are set as panels so that the back colour can be changed
            userInputs[2] = pnlTitle;
            userInputs[3] = pnlDOB;
            userInputs[4] = txtPhoneNumber;
            userInputs[5] = txtAddress1;
            userInputs[6] = txtAddress2;
            userInputs[7] = txtAddress3;
            //all names validation
            for (int i = 0; i <= 1; i++)
            {
                valid[i] = Utilities.NameValidation(userInputs[i].Text);
            }
            //Title validation
            valid[2] = Utilities.ComboBoxValidation(comboTitle.SelectedIndex);
            //DOB validation
            valid[3] = Utilities.DOBValidation(dtpDOB.Value);
            //Phone number validation
            valid[4] = Utilities.PhoneNumberValidation(txtPhoneNumber.Text);
            //all address validation
            for (int i = 5; i <= 7; i++)
            {
                //if its txtAddress1
                valid[i] = Utilities.AddressValidation(userInputs[i].Name, userInputs[i].Text);
            }
            //searches through the how valid array after all controls have been checked, and prints errors respectively
            for (int i = 0; i < valid.Length; i++)
            {
                if (valid[i] == false)
                {
                    //this adds the new error message to the old one with a new line
                    errorMsg = Utilities.validation_failed(userInputs[i], lblErrorMsg, btnSubmit, errorMsg);
                }
            }
            //sets the error message label to the error message
            lblErrorMsg.Text = errorMsg;
            //shows the label
            lblErrorMsg.Visible = true;
            //if there is no occurance of a failed validation
            if (!valid.Contains(false))
            {
                //return true
                result = true;
            }
            return result;
        }

        /// <summary>
        /// is called when the logo is clicked, can also be called from in code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toDashboard(object sender, EventArgs e)
        {
            //closes the current form
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
            //makes the dashboard object visible
            dashboard.Visible = true;
        }


        /// <summary>
        /// allows the submit button to be clicked to progress
        /// </summary>
        /// <param name="boxInput"></param>
        private void validation_passed(TextBox boxInput)
        {
            btnSubmit.Enabled = true;
            boxInput.BackColor = Color.White;
        }

        /// <summary>
        /// Shows a message box - this is used from DBAccess to display a message if the user was added to the db
        /// or not
        /// </summary>
        /// <param name="title">title for the message box</param>
        /// <param name="message">message for the message box</param>
        public static void ShowMessage(string title, string message)
        {
            MessageBox.Show(title, message);
        }

        #region Ryan's Code
        //// I'm only doing the following bits of code so that we can easily pass into DBAccess when it is created
        //string fName, sName, title, address, allergies, nhNumber, phone;
        //string dob;
        //bool diabetic, smoker, asthmatic;

        //nhNumber = txtNHNumber.Text;
        //    fName = txtFName.Text;
        //    sName = txtSName.Text;
        //    title = comboTitle.Text;
        //    dob = dtpDOB.Text;
        //    phone = txtPhoneNumber.Text;
        //    address = txtAddress1.Text;
        //    allergies = txtAllergies.Text;
        //    diabetic = cbDiabetes.Checked;
        //    smoker = cbSmoker.Checked;
        //    asthmatic = cbAsthmatic.Checked;
        #endregion
            
    }
}
