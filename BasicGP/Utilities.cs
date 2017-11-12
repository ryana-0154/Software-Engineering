using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BasicGP
{
    static class Utilities
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
                    errorMsg += userInput.Tag + " - Field must before current day." + Environment.NewLine;
                    break;
                case "pnlBookedDate":
                    errorMsg += userInput.Tag + " - Field must in the future." + Environment.NewLine;
                    break;
                case "pnlBookedTime":
                    errorMsg += userInput.Tag + " - Field must between 0800 and 1700." + Environment.NewLine;
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
        public static bool NHNumberValidation(TextBox userInput)
        {
            if (userInput.Text.Length == 10 && Regex.IsMatch(userInput.Text, @"^\d+$"))
            {
                return true;
            }
            else
            { return false; }
        }
        public static bool TitleValidation(ComboBox userinput)
        {
            if (userinput.SelectedIndex != -1)//something was selected
            { return true; }
            else
            {
                return false;
            }
        }
        public static bool NameValidation(TextBox userInput)
        {
            if ((userInput.Text.Length <= 16 && userInput.Text.Length > 0) && Regex.IsMatch(userInput.Text, @"^[\p{L}]+$"))
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
        // Check 
        public static bool TimeBookingValidation (DateTimePicker dtpTime)
        {
            //should only be 20 minutes
            if (true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool DateBookingValidation(DateTimePicker dtpDate)
        {
            if ((DateTime.Compare(dtpDate.Value, DateTime.Today)) >= 0)
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
        public static bool DOBValidation(DateTimePicker dtpDOB)
        {
            if ((DateTime.Compare(dtpDOB.Value, DateTime.Today)) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool PhoneNumberValidation(TextBox userInput)
        {
            if (userInput.Text.Length == 11 && Regex.IsMatch(userInput.Text, @"^\d+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool AddressValidation(TextBox userInput)
        {
            if (userInput.Name == "txtAddress1")
            {
                if (userInput.Text.Length <= 64 && userInput.Text.Length > 0)
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
                if (userInput.Text.Length <= 64)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool DescriptionValidation(TextBox userInput)
        {
            //TODO: Correct the allowed length of a description
            if (userInput.Text != "" && userInput.Text.Length < 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
}
}
