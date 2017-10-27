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
            //Get the DB connection string from the properties
            string conString = Properties.Settings.Default.OverGPDBConnectionString;
            //Instantiate an instance of DBAccess with the connection string above
            DBAccess dbCon = new DBAccess(conString);
            //Open a connection to the database inside DBAccess
            dbCon.OpenConnection();
            // Define a dataSet from DBAccess with the SQL statement
            DataSet dataSet = dbCon.GetDataSet($"SELECT * FROM users WHERE userName = '{username}' AND password = '{password}'");
            //Define a datatable with the tables from the dataset return
            DataTable table = dataSet.Tables[0];
            //close the DB Connections
            dbCon.closeConnection();

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
