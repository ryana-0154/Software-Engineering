// Author: Ryan Alderton
// SID: 1609275

using System.Drawing;

namespace BasicGP
{
    class Constants
    {
        // Select Statements
        public static string checkLogin = "SELECT * FROM users WHERE userName = @username AND password = @password COLLATE SQL_Latin1_General_CP1_CS_AS";
        public static string getPatientByID = "SELECT * FROM patients WHERE NHNumber = @id";
        // In?
        public static string getPatientByDOB = "SELECT * FROM patients WHERE name IN (@name) AND DOB IN (@DOB)";
        public static string getAllPatients = "SELECT TOP 15 * FROM patients ORDER BY Name ASC";
        public static string getAppointments = "SELECT * FROM appointment WHERE NHNumber = @id";
        public static string getAppointmentsToCheckBook = "SELECT * FROM appointment WHERE Date = @date AND Time = @time AND EmployeeID = @eID";
        public static string getAppointmentID = "select AppointmentID from appointment where EmployeeID = @eID AND NHNumber = @NHNumber AND Date = @date AND Time = @time";
        //TODO: use join and make this display patient name and employee name and date and time and description
        //returns the data for the fields so it can be edited
        public static string getAppointmentsForEdit = "SELECT appointment.NHNumber,appointment.Date,appointment.time,Employee.Title, Employee.FirstName,Employee.LastName,appointment.Description, appointment.AppointmentID FROM appointment " +
        "INNER JOIN Employee ON appointment.EmployeeID = Employee.EmployeeID " +
        "INNER join patients on appointment.NHNumber = patients.NHNumber " +
        "WHERE(appointment.NHNumber = @ID OR appointment.EmployeeID = @ID) AND appointment.Date >= @date";
        //displays the key inforamtion about appointments to show to then be chosen
        public static string getAppointmentsForView = "SELECT employee.title, Employee.FirstName,Employee.LastName,appointment.Date,appointment.Time, patients.name FROM appointment " +
        "right JOIN Employee ON appointment.EmployeeID = Employee.EmployeeID " +
        "right join patients on appointment.NHNumber = patients.NHNumber " +
        "WHERE (appointment.NHNumber = @ID OR appointment.EmployeeID = @ID) AND appointment.Date >= @date";
        public static string getTestResults = "SELECT * FROM testresults WHERE NHNumber = @id";
        public static string getPrescriptions = "SELECT * FROM prescriptions WHERE NHNumber = @id";
        //TODO: Not necessary
        public static string getAvailability = "SELECT * FROM availability WHERE NHNumber = @id";
        //public static string getDuty = "SELECT * FROM rota WHERE Shift1 = @day OR Shift2 = @day OR Shift3 = @day OR Shift4 = @day OR Shift5 = @day OR Shift6 = @day OR Shift7 = @day";
        //TODO: Use a join here and then use IN instead of all the ORs
        public static string getDuty = "SELECT Title, FirstName, LastName, Occupation FROM employee WHERE rotaID IN (SELECT rotaID FROM rota WHERE Shift1 = @day OR Shift2 = @day OR Shift3 = @day OR Shift4 = @day OR Shift5 = @day OR Shift6 = @day OR Shift7 = @day)";
        public static string getPrescriptionDuration = "SELECT duration FROM prescriptions WHERE prescriptionID = @id";
        public static string getEmployeeIDByName = "SELECT employeeID FROM employee WHERE title = @title AND firstName = @firstName and lastName = @lastName";
        public static string isEmployeeAvailable = "";//join employee rota and appointments, and show which one is on and that day and doesnt have a conflicting appointment
        public static string showEmployeeAvailability = "SELECT * FROM appointment WHERE EmployeeID = @employeeID AND Date = @date";

        // Insert Statements
        public static string postPatient = "INSERT INTO patients (Name, Title, DOB, PhoneNumber, Address, Diabetes, Smoker, Asthma, Allergies) " +
                        "VALUES (@name, @title, @DOB, @phoneNumber, @address, @diabetes, @smoker, @asthma, @allergies)";
        public static string postAppointment = "INSERT INTO appointment (EmployeeID, NHNumber, Date, Time, Description) VALUES ( " +
            "(SELECT EmployeeID FROM Employee WHERE Title = @title AND FirstName = @firstname AND LastName = @lastname), @NHNumber, @Date, @Time, @Description)";

        // UPDATE statements
        public static string extendPrescriptionDuration = "UPDATE prescriptions SET DatePrescribed = @date WHERE PrescriptionID = @prescriptionID";
        public static string updateAppointment = "UPDATE appointment SET EmployeeID = @eID, NHNumber = @NHNumber, Date = @date, " +
            "Time = @time, Description = @desc WHERE AppointmentID = @aID ";

        // DELETE statements
        public static string cancelAppointment = "DELETE FROM appointment WHERE NHNumber = @NHNumber AND Date = @date AND Time = @time";




        //Colours
        public static Color TitleColor = Color.Blue;
        public static Color BtnColor = SystemColors.HotTrack;
        public static Color ErrorColor = Color.LightCoral;
        public static Color BkColor = Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(193)))), ((int)(((byte)(209)))));
        public static Color lblColor = Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
        
    }
    
}