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
        public static void validation_failed(Control userInput, Label lblErrorMsg, Button btnSubmit)
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
            userInput.BackColor = System.Drawing.Color.LightCoral;
            btnSubmit.Enabled = false;
        }


        #region Still needs fixing - not functional
        /*
    public bool CheckValidation(bool[] valid, Control[] userInputs)
    {
        bool result = false;
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
        Dashboard.Visible = false;
        Dashboard dashboard = new Dashboard();
        dashboard.Visible = true;
    }
        */
        #endregion
    }
}
