using System;
using System.Data;

namespace BasicGP
{
    class HandleLogin
    {
        /// <summary>
        /// Checks user credentials against the DB
        /// </summary>
        /// <param name="username">The Username of the user</param>
        /// <param name="password">The password of the user</param>
        /// <returns>True if authenticated | false if not</returns>
        public static bool Authenticate(string username, string password)
        {
            // Define a dataSet from DBAccess with the SQL statement
            DataSet dataSet = DBAccess.getData("login", username, password);
            //Define a datatable with the tables from the dataset return
            DataTable table = dataSet.Tables[0];
            //If there is a user with those credentials, do this
            if (table.Rows.Count == 1)
            {
                return true;
            }
            // else show a message telling them their credentials are wrong.
            else
            {
                return false;
            }

        }

    }
}
