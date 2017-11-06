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
        //comment
        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckValidation();
            //attributes
            string[] patientDetails = new string[7];
            bool[] additionalInfo = new bool[3];
            string address = ConcatAddress();
            Console.WriteLine(address);
            //TODO: cahnge from bool and string arrays to just one Control data type array
            patientDetails[0] = txtNHNumber.Text; // data[1]
            patientDetails[1] = txtFName.Text + " " + txtSName.Text; // data[2]
            patientDetails[2] = comboTitle.Text; // data[3]
            patientDetails[3] = dtpDOB.Text; // data[4]
            patientDetails[4] = txtPhoneNumber.Text; // data[5]
            patientDetails[5] = address; // data[6]
            patientDetails[6] = txtAllergies.Text; // data[7]

            additionalInfo[0] = cbDiabetes.Checked; // data[8]
            additionalInfo[1] = cbSmoker.Checked; // data[9]
            additionalInfo[2] = cbAsthmatic.Checked; // data[10]

            DBAccess.postData("registerPatient", patientDetails[0], patientDetails[1], patientDetails[2], patientDetails[3],
                patientDetails[4], patientDetails[5], patientDetails[6],
                additionalInfo[0].ToString(), additionalInfo[1].ToString(), additionalInfo[2].ToString());

            //TODO: check this, should we just overload the method instead???
            toDashboard(sender, e);
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

        private Boolean CheckValidation()
        {
            bool result = false;
            Boolean[] valid = new bool[9];
            Control[] userInputs = new Control[9];

            userInputs[0] = txtNHNumber; //valid[0]
            userInputs[1] = txtFName;
            userInputs[2] = txtSName;
            userInputs[3] = comboTitle;
            userInputs[4] = dtpDOB;
            userInputs[5] = txtPhoneNumber;
            userInputs[6] = txtAddress1;
            userInputs[7] = txtAddress2;
            userInputs[8] = txtAddress3;
            //NHNumber validation
            if (userInputs[0].Text.Length == 10 && Regex.IsMatch(userInputs[0].Text, @"^\d+$"))
            {
                valid[0] = true;
            }
            //all names validation
            for (int i = 1; i <= 2; i++)
            {
                if ((userInputs[i].Text.Length <= 16 && userInputs[i].Text.Length > 0) && Regex.IsMatch(userInputs[i].Text, @"^[\p{L}]+$"))
                {
                    valid[i] = true;
                }
            }
            //Title validation
            if (comboTitle.SelectedIndex != -1)//something was selected
            {
                //it is valid number 8 because its not a txt box and goes at the end
                valid[3] = true;
            }
            #region compare explaination
            /*Less than zero time1 is earlier than time2. Zero time1 is the same as time2. Greater than
            zero time1 is later than time2.
            this if is saying if the user has inputted a date in the future or exactly now, then it is not correct
            */
            #endregion
            //DOB validation
            if ((DateTime.Compare(dtpDOB.Value, DateTime.Now)) < 0)
            {
                valid[4] = true;
            }
            //Phone number validation
            if (userInputs[5].Text.Length == 11 && Regex.IsMatch(userInputs[5].Text, @"^\d+$"))
            {
                valid[5] = true;
            }
            //all address validation
            for (int i = 6; i <= 8; i++)
            {
                //if its txtAddress1
                if (i == 6)
                {
                    if (userInputs[i].Text.Length <= 64 && userInputs[i].Text.Length > 0)
                    {
                        valid[i] = true;
                    }
                }
                else //if it isnt txtAddress1 - therefore txtAddress2 and 3
                {
                    //only check if its input is less that 64
                    if (userInputs[i].Text.Length <= 64)
                    {
                        valid[i] = true;
                    }
                }
            }
            //searches through the how valid array after all controls have been checked, and prints errors respectively
            for (int i = 0; i < valid.Length; i++)
            {
                if (valid[i] == false)
                {
                    validation_failed(userInputs[i]);
                }
            }
            if (!valid.Contains(false))
            {
                result = true;
            }
            return result;
        }
        
        /// <summary>
        /// Is called if validation is failed, disables submit button, changes colours and posts a message
        /// </summary>
        /// <param name="userInput">is the control that has failed</param>
        private void validation_failed(Control userInput)
        {
            //start a fresh each time
            string errorMsg = "";
            switch (userInput.Name)
            {
                case "NHNumber":
                    //https://stackoverflow.com/questions/4085739/how-to-insert-newline-in-string-literal
                    errorMsg += userInput.Tag + " - Field must be 10 digits long and only numbers." + Environment.NewLine;
                    break;
                case "txtFName":
                case "txtSName":
                    errorMsg += userInput.Tag + " - Field must be less than 16 characters but more than 0 and only letters." + Environment.NewLine;
                    break;
                case "comboTitle":
                    errorMsg += userInput.Tag + " - Field must be one of the drop down options." + Environment.NewLine;
                    break;
                case "dtpDOB":
                    errorMsg += userInput.Tag + " - Field must before current day." + Environment.NewLine;
                    break;
                case "txtPhoneNumber":
                    errorMsg += userInput.Tag + " - Field must be 11 digits and numbers only." + Environment.NewLine;
                    break;
                case "txtAddress1":
                    errorMsg += userInput.Tag + " - Field must be less than 20 characters but more than 0." + Environment.NewLine;
                    break;
                case "txtAddress2":
                case "txtAddress3":
                    errorMsg += userInput.Tag + " - Field must be less than 20 characters." + Environment.NewLine;
                    break;
                //this can be removed, isnt required and is txt
                case "txtAllergies":
                    errorMsg += userInput.Tag + " - Field must be less than 64 characters." + Environment.NewLine;
                    break;
            }
            lblErrorMsg.Text = errorMsg;
            userInput.BackColor = Color.LightCoral;
            btnSubmit.Enabled = false;
        }
        /// <summary>
        /// is called when the logo is clicked, can also be called from in code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toDashboard(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Visible = true;
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

        /// <summary>
        /// a text validation method which checks the length of the compulsory fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtText_validation(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// A validation check to make sure number fields are numbers and correct length
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumber_validation(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boxInput"></param>
        private void validation_passed(TextBox boxInput)
        {
            btnSubmit.Enabled = true;
            boxInput.BackColor = Color.White;
        }
        /// <summary>
        /// Shows a messagebox
        /// </summary>
        public static void showMessage(string message, string title)
        {
            MessageBox.Show(title, message);
        }

    }
}
