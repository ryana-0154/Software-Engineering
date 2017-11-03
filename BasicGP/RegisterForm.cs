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
            CheckValidation();
            //attributes
            string[] patientDetails = new string[7];
            bool[] additionalInfo = new bool[3];
            string address = ConcatAddress();
            Console.WriteLine(address);

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
            Boolean[] valid = new bool[7];
            TextBox[] txtBoxes = new TextBox[7];
            txtBoxes[0] = txtNHNumber;
            txtBoxes[1] = txtFName;
            txtBoxes[2] = txtSName;
            txtBoxes[3] = txtPhoneNumber;
            txtBoxes[4] = txtAddress1;
            txtBoxes[5] = txtAddress2;
            txtBoxes[6] = txtAddress3;
            //does not require validation
            txtBoxes[7] = txtAllergies;

            //title
            //DOB
            
            //applies onto names
            for (int i = 1; i <= 2; i++)
            {
                if ((txtBoxes[i].Text.Length <= 16 && txtBoxes[i].Text.Length > 0) && Regex.IsMatch(txtBoxes[i].Text, @"^[\p{L}]+$"))
                {
                    valid[i] = true;
                }
            }
            //applies onto numbers


            //applies onto address
            for (int i = 4; i <= 6; i++)
            {
                //if its txtAddress1
                if (i == 4)
                {
                    if (txtBoxes[i].Text.Length <= 64 && txtBoxes[i].Text.Length > 0)
                    {
                        valid[i] = true;
                    }
                }
                else //if it isnt txtAddress1 - therefore txtAddress2 and 3
                {
                    //only check if its input is less that 64
                    if (txtBoxes[i].Text.Length <= 64)
                    {
                        valid[i] = true;
                    }
                }
            }


            return true;
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
            TextBox boxInput = (TextBox)sender;
            switch (boxInput.Name)
            {
                case "txtFName":
                case "txtSName":
                    //checks to see if the input is less that or equal to 16 bits, but not 0 and is only letters
                    //REFERENCE https://stackoverflow.com/questions/273141/regex-for-numbers-only
                    if ((boxInput.Text.Length <= 16 && boxInput.Text.Length > 0) && Regex.IsMatch(boxInput.Text, @"^[\p{L}]+$"))
                    {
                        validation_passed(boxInput);
                        return;
                    }
                    break;
                case "txtAddress1":
                    //first part of the address cannot be null
                    if (boxInput.Text.Length <= 20 && boxInput.Text.Length > 0)
                    {
                        validation_passed(boxInput);
                        return;
                    }
                    break;
                case "txtAddress2":
                case "txtAddress3":
                    if (boxInput.Text.Length <= 20)
                    {
                        validation_passed(boxInput);
                        return;
                    }
                    break;
                    //this can be removed, isnt required and is txt
                case "txtAllergies":
                    if (boxInput.Text.Length <= 64)
                    {
                        validation_passed(boxInput);
                        return;
                    }
                    break;
            }

            validation_failed(boxInput, "you need to enter Text here");

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
            if (boxInput.Text != "" && Regex.IsMatch(boxInput.Text, @"^\d+$"))
            {
                //assuming NHNumber is meant to be 10 digits
                if (boxInput.Name == "txtNHNumber" && boxInput.Text.Length == 10)
                {
                    //passes the validation
                    validation_passed(boxInput);
                    return;
                }
                else if (boxInput.Name == "txtPhoneNumber" && boxInput.Text.Length == 11)
                {
                    //passes the validation
                    validation_passed(boxInput);
                    return;
                }
                else
                {
                    validation_failed(boxInput, "Entry is incorrect Length");
                }
            }
            else
            {
                validation_failed(boxInput, "You need to enter a number");
            }
        }
        /// <summary>
        /// Is called if validation is failed, disables submit button, changes colours and posts a message
        /// </summary>
        /// <param name="boxInput"></param>
        /// <param name="reason">the message to print</param>
        private void validation_failed(TextBox boxInput, string reason)
        {
            MessageBox.Show(reason);
            Console.WriteLine(reason);
            boxInput.BackColor = Color.LightCoral;
            btnSubmit.Enabled = false;
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

    }
}
