using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BasicGP
{
    public static class Utilities
    {
        // TODO: Put methods that are used a lot here to prevent 
        // writing the same things over and over again


        /// <summary>
        /// Is called if validation is failed, disables submit button, changes colours and posts a message
        /// </summary>
        /// <param name="userInput">is the control that has failed</param>
        public static string validation_failed(Control userInput, Label lblErrorMsg, Button btnSubmit,string errorMsg)
        {
            //start a fresh each time
            switch (userInput.Name)
            {
                case "txtNHNumber":
                    //https://stackoverflow.com/questions/4085739/how-to-insert-newline-in-string-literal
                    errorMsg += userInput.Tag + " - Field must be 10 digits long and only numbers." + Environment.NewLine;
                    break;
                case "txtFName":
                case "txtSName":
                    errorMsg += userInput.Tag + " - Field must be less than 16 characters but more than 0 and only letters." + Environment.NewLine;
                    break;
                    //these are panels because the control being passed over is the panel
                case "pnlTitle":
                    errorMsg += userInput.Tag + " - Must select one of the drop down options." + Environment.NewLine;
                    break;
                    //these are panels because the control being passed over is the panel
                case "pnlDOB":
                case "pnlBookedTime":
                    errorMsg += userInput.Tag + " - Field must before current day." + Environment.NewLine;
                    break;
                case "pnlBookedDate":
                    errorMsg += userInput.Tag + " - Field must in the future." + Environment.NewLine;
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
                case "txtDescription":
                    errorMsg += userInput.Tag + " - Field must not be empty(But less than 300 characters)." + Environment.NewLine;
                    break;
            }
            //highlights the failed control so it can be identified
            userInput.BackColor = System.Drawing.Color.LightCoral;
            return errorMsg;
        }
        /// <summary>
        /// is called when the logo is clicked, can also be called from in code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void toDashboard(object sender, EventArgs e, Form currentForm)
        {
            currentForm.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Visible = true;
        }
        /// <summary>
        /// validation for nhnumber
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static bool NHNumberValidation(string userInput)
        {
            //checks that there is only numbers or not
            if (Regex.IsMatch(userInput, @"^\d+$"))
            {
                return true;
            }
            else
            { return false; }
        }
        /// <summary>
        /// validation for any input on comboboxes
        /// </summary>
        /// <param name="userinput"></param>
        /// <returns></returns>
        public static bool ComboBoxValidation(int userinput)
        {
            if (userinput != -1)//checks something was selected
            { return true; }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// validation for first names OR last names
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static bool NameValidation(string userInput)
        {
            //checks if the length of the name is within 0 and 16 and checks that there is only letters
            if ((userInput.Length <= 16 && userInput.Length > 0) && Regex.IsMatch(userInput, @"^[\p{L}]+$"))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
        #region compare explaination
        /*Less than zero time1 is earlier than time2. Zero time1 is the same as time2. Greater than
        zero time1 is later than time2.
        this if is saying if the user has inputted a date in the future or exactly now, then it is not correct
        */
        #endregion
        /// <summary>
        /// validation for the date of a booking
        /// </summary>
        /// <param name="dtpDate"></param>
        /// <returns></returns>
        public static bool DateBookingValidation(DateTime dtpDate)
        {
            //checks to see if the input is in the future or today
            if ((DateTime.Compare(dtpDate, DateTime.Today)) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// validation of a Date of birth input
        /// </summary>
        /// <param name="dtpDOB"></param>
        /// <returns></returns>
        public static bool DOBValidation(DateTime dtpDOB)
        {
            //checks to see if the input is before today
            if ((DateTime.Compare(dtpDOB, DateTime.Today)) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// validation of phone number input
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static bool PhoneNumberValidation(string userInput)
        {
            //checks if it is 11 digits long exactly and is only numbers
            if (userInput.Length == 11 && Regex.IsMatch(userInput, @"^\d+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// validation of an address
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static bool AddressValidation(string name,string userInput)
        {
            //checks which input field we are validating
            if (userInput == "txtAddress1")
            {
                //if its the first field it must have input and no longer than 64 characters
                if (userInput.Length <= 64 && userInput.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //if it isnt the first input field then it can be empty but cannot be longer than 64 characters
                if (userInput.Length <= 64)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// validation for the appointment description
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        public static bool DescriptionValidation(string userInput)
        {
            //checks if the length is longer than 0 but less than 300 characters long
            if (userInput.Length > 0  && userInput.Length < 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="tb"></param>
        public static void CheckForResults(DataGridView dgv,DataTable tb)
        {
            if (tb.Rows.Count > 0)
            {
                dgv.DataSource = tb;
            }
            else
            {
                MessageBox.Show("No data was found");
            }
        }

    }
}
