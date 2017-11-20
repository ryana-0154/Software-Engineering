// Author: Ryan Alderton
// SID: 1609275
namespace BasicGP
{
    class Constants
    {
        // Select Statements
        public static string checkLogin = "SELECT * FROM users WHERE userName = @username AND password = @password";
        public static string getPatientByID = "SELECT * FROM patients WHERE NationalHealthNumber = @id";
        // In?
        public static string getPatientByDOB = "SELECT * FROM patients WHERE name IN (@name) AND DOB IN (@DOB)";
        public static string getAllPatients = "SELECT TOP 15 * FROM patients ORDER BY Name DESC";
        public static string getAppointments = "SELECT * FROM appointment WHERE NationalHealthNumber = @id";
        //TODO: use join and make this display patient name and employee name and date and time and description
        //returns all the data so it can be edited
        public static string getAppointmentsForEdit = "SELECT * FROM appointment WHERE (NationalHealthNumber = @id OR EmployeeID = @id) AND date >= @date";
        //displays the appointments to show to then be chosen
        public static string getAppointmentsForView = "SELECT employee.title, Employee.FirstName,Employee.LastName,appointment.Date,appointment.Time, patients.name FROM appointment " +
        "right JOIN Employee ON appointment.EmployeeID = Employee.EmployeeID " +
        "right join patients on appointment.NationalHealthNumber = patients.NationalHealthNumber " +
        "WHERE (appointment.NationalHealthNumber = @ID OR appointment.EmployeeID = @ID) AND appointment.Date >= @date";
        public static string getTestResults = "SELECT * FROM testresults WHERE NationalHealthNumber = @id";
        public static string getPrescriptions = "SELECT * FROM prescriptions WHERE NationalHealthNumber = @id";
        //TODO: Not necessary
        public static string getAvailability = "SELECT * FROM availability WHERE NationalHealthNumber = @id";
        //public static string getDuty = "SELECT * FROM rota WHERE Shift1 = @day OR Shift2 = @day OR Shift3 = @day OR Shift4 = @day OR Shift5 = @day OR Shift6 = @day OR Shift7 = @day";
        //TODO: Use a join here and then use IN instead of all the ORs
        public static string getDuty = "SELECT Title, FirstName, LastName, Occupation FROM employee WHERE rotaID IN (SELECT rotaID FROM rota WHERE Shift1 = @day OR Shift2 = @day OR Shift3 = @day OR Shift4 = @day OR Shift5 = @day OR Shift6 = @day OR Shift7 = @day)";
        public static string getPrescriptionDuration = "SELECT duration FROM prescriptions WHERE prescriptionID = @id";
        public static string getEmployeeIDByName = "SELECT employeeID FROM employee WHERE title = @title AND firstName = @firstName and lastName = @lastName";
        public static string isEmployeeAvailable = "";//join employee rota and appointments, and show which one is on and that day and doesnt have a conflicting appointment
        public static string showEmployeeAvailability = "SELECT * FROM appointment WHERE EmployeeID = @employeeID AND Date = @date";

        // Insert Statements
        public static string postPatient = "INSERT INTO patients (NationalHealthNumber, Name, Title, DOB, PhoneNumber, Address, Diabetes, Smoker, Asthma, Allergies) " +
                        "VALUES (@NHNumber, @name, @title, @DOB, @phoneNumber, @address, @diabetes, @smoker, @asthma, @allergies)";
        public static string postAppointment = "INSERT INTO appointment (EmployeeID, NationalHealthNumber, Date, Time, Description) VALUES ( " +
            "(SELECT EmployeeID FROM Employee WHERE Title = @title AND FirstName = @firstname AND LastName = @lastname), @NHNumber, @Date, @Time, @Description)";

        // UPDATE statements
        public static string extendPrescriptionDuration = "UPDATE prescriptions SET DatePrescribed = @date WHERE PrescriptionID = @prescriptionID";
        //public static string updateAppointment = "UPDATE appointments SET ";

        // DELETE statements
        public static string cancelAppointment = "DELETE FROM appointment WHERE NHNumber = @NHNumber AND date = @date AND time = @time";
    }
}