using System;
using System.Data;
using System.Data.SqlClient;

namespace BasicGP
{
    class DBAccess
    {
        // Set the connection string (conStr) to be the value from the properties of the DB
        private static string conStr = Properties.Settings.Default.OverGPDBConnectionString;
        // Declare the connection, dataadapter and sqlcommand for use below
        private static SqlConnection DBConnection;
        private static SqlDataAdapter dataAdapter;
        private static SqlCommand sqlCommand;


        /// <summary>
        /// Opens the connection based on the string passed in DatabaseConnection
        /// </summary>
        public static void OpenConnection()
        {
            // Set the value of DBCOnnection to instantiate a new sqlconnection on the connection string supplied above
            DBConnection = new SqlConnection(conStr);
            // Open the DBConnection
            DBConnection.Open();
        }

        /// <summary>
        /// Closes the DB Connection
        /// </summary>
        public static void CloseConnection()
        {
            // Close the DBConnection
            DBConnection.Close();
        }
       
        /// <summary>
        /// Fetches data from the server
        /// </summary>
        /// <param name="data">Data to be passed to the server - first element should always be the function</param>
        public static DataSet GetData(params string[] data)
        {
            // Create a dataset called dataSet
            DataSet dataSet;
            // Clean the dataSet and the dataAdapter
            dataSet = null;
            dataAdapter = null;
            
            // Open the DB Connection
            OpenConnection();
            
            // Try to parse the value of data[1] into a int called ID
            Int32.TryParse(data[1], out int ID);
            
            //ID = data.Length <= 0 ? Int32.Parse(data[1]) : 0;

            // Switch statement based on what is in data[0]
            switch (data[0])
            {
                case "login":
                    // set the SQL command to be the value of checkLogin on the DBConnection
                    sqlCommand = new SqlCommand(Constants.checkLogin, DBConnection);
                    // Add the parameters to the SQL Command
                    sqlCommand.Parameters.AddWithValue("@username", data[1]);
                    sqlCommand.Parameters.AddWithValue("@password", data[2]);
                    break;
                case "findPatient":
                    // Switch based on data[1] which is ID or name and DOB
                    switch (data[1])
                    {
                        case "id":
                            // Try to parse data[2] (ID) to an int32 and output as an int findID
                            Int32.TryParse(data[2], out int findID);
                            // Instantiate an sqlCommand on the DBConnection
                            sqlCommand = new SqlCommand(Constants.getPatientByID, DBConnection);
                            // add parameters to the sql command (Prevents again SQLI)
                            sqlCommand.Parameters.AddWithValue("@id", findID);
                            break;
                        case "name&dob":
                            // 
                            sqlCommand = new SqlCommand(Constants.getPatientByDOB, DBConnection);
                            sqlCommand.Parameters.AddWithValue("@name", data[2]);
                            sqlCommand.Parameters.AddWithValue("@DOB", DateTime.Parse(data[3]));
                            break;
                        default:
                            //dataSet = null;
                            break;
                    }
                    break;
                case "patientAppointments":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getAppointments, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    break;
                case "patientAppointmentsView":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getAppointmentsForView, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Today.ToString("yyyy-MM-dd")));
                    break;
                case "patientAppointmentsEdit":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getAppointmentsForEdit, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(DateTime.Today.ToString("yyyy-MM-dd")));
                    break;
                case "testResults":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getTestResults, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    break;
                case "patientPresciptions":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getPrescriptions, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    break;
                case "availability":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getAvailability, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    break;
                case "duty":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getDuty, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@day", data[1]);
                    break;
                case "prescriptionDuration":
                    // Instantiate an sqlCommand on the DBConnection
                    sqlCommand = new SqlCommand(Constants.getPrescriptionDuration, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    sqlCommand.Parameters.AddWithValue("@id", ID);
                    break;
                case "employeeID":
                    // Instantiate a new sqlcommand with the SQL statement from the constants file
                    sqlCommand = new SqlCommand(Constants.getEmployeeIDByName, DBConnection);
                    // Add parameters to this sqlcommand
                    sqlCommand.Parameters.AddWithValue("@title", data[1]);
                    sqlCommand.Parameters.AddWithValue("@firstname", data[2]);
                    sqlCommand.Parameters.AddWithValue("@lastname", data[3]);
                    break;
                case "showEmployeeAvailability":
                    sqlCommand = new SqlCommand(Constants.showEmployeeAvailability, DBConnection);
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(data[1]));
                    sqlCommand.Parameters.AddWithValue("@title", data[2]);
                    sqlCommand.Parameters.AddWithValue("@firstname", data[3]);
                    sqlCommand.Parameters.AddWithValue("@lastname", data[4]);
                    break;
                case "selectAllPatients":
                    sqlCommand = new SqlCommand(Constants.getAllPatients, DBConnection);
                    break;
                case "getAppointmentID":
                    sqlCommand = new SqlCommand(Constants.getAppointmentID, DBConnection);
                    // add the parameters to the sql query, and parse the data required into the correct data format
                    sqlCommand.Parameters.AddWithValue("@eID", Int32.Parse(data[1]));
                    sqlCommand.Parameters.AddWithValue("@NHNumber", Int32.Parse(data[2]));
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(data[3]));
                    sqlCommand.Parameters.AddWithValue("@time", data[4]);
                    Console.WriteLine(data[1], data[2], DateTime.Parse(data[3]), DateTime.Parse(data[4]).ToShortTimeString());
                    break;
                case "getAppointmentsToCheckAvail":
                    sqlCommand = new SqlCommand(Constants.getAppointmentsToCheckBook, DBConnection);
                    sqlCommand.Parameters.AddWithValue("@time", data[1]);
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(data[2]));
                    sqlCommand.Parameters.AddWithValue("@firstname", data[3]);
                    sqlCommand.Parameters.AddWithValue("@lastname", data[4]);
                    Console.WriteLine(data[1] + data[2] + data[3] + data[4]);
                    break;
                default:
                    // If it matches none of the cases above, set the dataSet to null; It should never use this case.
                    dataSet = null;
                    break;
            }
            // Add the value of the sqlCommand to the sqlDataAdapter
            dataAdapter = new SqlDataAdapter(sqlCommand);
            // create a data set
            dataSet = new DataSet();
            // Fill the dataAdapter with the data from the dataSet
            dataAdapter.Fill(dataSet);
            // Close the DB Connection
            CloseConnection();
            // Return the dataset
            return dataSet;
        }

        /// <summary>
        /// Posts Data to DB
        /// </summary>
        /// <param name="data">Data to be passed to the DB - first element should always be the function</param>
        public static DataSet PostData(params string[] data)
        {
            // Integer variable to hold the number of rows that were affected by the query
            int count;
            DataSet dataSet;

            // clean the dataSet and dataAdapter
            dataSet = null;
            dataAdapter = null;
            // Open the DB Connection
            OpenConnection();

            // Switch statement to judge what aspect of the postData query you need
            switch (data[0])
            {
                case "registerPatient":
                    // Instantiate an sqlCommand on the DBConnection
                    SqlCommand sqlCommand = new SqlCommand(Constants.postPatient, DBConnection);
                    // add parameters to the sql command (Prevents again SQLI)
                    //database will auto increment the id
                    //sqlCommand.Parameters.AddWithValue("@NHNumber", data[1]);
                    sqlCommand.Parameters.AddWithValue("@Name", data[1]);
                    sqlCommand.Parameters.AddWithValue("@Title", data[2]);
                    sqlCommand.Parameters.AddWithValue("@DOB", DateTime.Parse(data[3]));
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", data[4]);
                    sqlCommand.Parameters.AddWithValue("@Address", data[5]);
                    sqlCommand.Parameters.AddWithValue("@Allergies", data[6]);
                    sqlCommand.Parameters.AddWithValue("@Diabetes", data[7]);
                    sqlCommand.Parameters.AddWithValue("@Smoker", data[8]);
                    sqlCommand.Parameters.AddWithValue("@Asthma", data[9]);

                    // Execute the query and set the number of rows affected to the count variable
                    count = sqlCommand.ExecuteNonQuery();

                    // If more than 0 rows were affected, show a message to tell users the result of their operation
                    if(count > 0)
                    {
                        RegisterForm.ShowMessage("Success!", "Patient was added successfully!");
                    } else
                    {
                        RegisterForm.ShowMessage("Error!", "There was an error and the patient was not added.");
                    }
                    count = 0;
                    break;
                case "newAppointment":
                    sqlCommand = new SqlCommand(Constants.postAppointment, DBConnection);
                    // Add params to the above SQL query (Prevents against SQLI)  
                    sqlCommand.Parameters.AddWithValue("@NHNumber", data[1]);
                    sqlCommand.Parameters.AddWithValue("@Date", DateTime.Parse(data[2]));
                    sqlCommand.Parameters.AddWithValue("@Time", DateTime.Parse(data[3]));
                    sqlCommand.Parameters.AddWithValue("@title", data[4]);
                    sqlCommand.Parameters.AddWithValue("@firstname",data[5]);
                    sqlCommand.Parameters.AddWithValue("@lastname",data[6]);
                    sqlCommand.Parameters.AddWithValue("@Description", data[7]);

                    count = sqlCommand.ExecuteNonQuery();

                    if(count > 0)
                    {
                        RegisterForm.ShowMessage("Success!", "Patient was added successfully!");
                    } else
                    {
                        RegisterForm.ShowMessage("Error!", "There was an error and the patient was not added.");
                    }

                    count = 0;
                    break;
                default:
                    dataSet = null;
                    break;
            }
            
            return dataSet;
        }

        /// <summary>
        /// Method to update data in the database
        /// </summary>
        /// <param name="data">parameters for the method; The first element of the parameters should always be the function needed</param>
        public static void UpdateData(params string[] data)
        {
            // Open the DB Connection
            OpenConnection();
            // Switch to decide what function is needed in this method
            switch(data[0])
            {
                case "editAppointment":
                    sqlCommand = new SqlCommand(Constants.updateAppointment, DBConnection);
                    sqlCommand.Parameters.AddWithValue("@NHNumber", Int32.Parse(data[1]));
                    sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(data[2]));
                    sqlCommand.Parameters.AddWithValue("@time", DateTime.Parse(data[3]));
                    sqlCommand.Parameters.AddWithValue("@desc", data[4]);
                    sqlCommand.Parameters.AddWithValue("@aID", Int32.Parse(data[5]));
                    sqlCommand.Parameters.AddWithValue("@firstname", data[6]);
                    sqlCommand.Parameters.AddWithValue("@lastname", data[7]);
                    int count = sqlCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        RegisterForm.ShowMessage("Success!", "Appointment was edited sucessfully!");
                    }
                    else
                    {
                        RegisterForm.ShowMessage("Error!", "There was an error and the appointment was not edited.");
                    }
                    break;
                case "extendPrescription":
                    sqlCommand = new SqlCommand(Constants.extendPrescriptionDuration, DBConnection);
                    sqlCommand.Parameters.AddWithValue("@Date", DateTime.Today);
                    sqlCommand.Parameters.AddWithValue("@prescriptionID", data[1]);
                    count = sqlCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        RegisterForm.ShowMessage("Success!", "Prescription was extended sucessfully!");
                    }
                    else
                    {
                        RegisterForm.ShowMessage("Error!", "There was an error and the prescription was not extended.");
                    }
                    break;
            }

           
        }

        /// <summary>
        /// Method used to delete data from the DB
        /// </summary>
        /// <param name="data"></param>
        public static void DeleteData(params string[] data)
        {
            OpenConnection();
            sqlCommand = new SqlCommand(Constants.cancelAppointment, DBConnection);
            sqlCommand.Parameters.AddWithValue("@NHNumber", data[0]);
            sqlCommand.Parameters.AddWithValue("@date", DateTime.Parse(data[1]));
            sqlCommand.Parameters.AddWithValue("@time", data[2]);
            int count = sqlCommand.ExecuteNonQuery();

            if (count > 0)
            {
                RegisterForm.ShowMessage("Success!", "Sucessfully Deleted.");
            }
            else
            {
                RegisterForm.ShowMessage("Error!", "There was an error and the entry was not deleted.");
            }

        }
    }
}
