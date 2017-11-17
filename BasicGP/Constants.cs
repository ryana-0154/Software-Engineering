// Author: Ryan Alderton
// SID: 1609275
namespace BasicGP
{
    class Constants
    {
        // Select Statements
        public static string checkLogin = "SELECT * FROM users WHERE userName = @username AND password = @password";
        public static string getPatientByID = "SELECT * FROM patients WHERE NationalHealthNumber = @id";
        public static string getPatientByDOB = "SELECT * FROM patients WHERE name = @name AND DOB = @DOB";
        public static string getAppointments = "SELECT * FROM appointment WHERE NationalHealthNumber = @id";
        //TODO: use join and make this display patient name and employee name and date and time and description
        public static string getAppointmentsForEdit = "SELECT * FROM appointment WHERE NationalHealthNumber = @id OR EmployeeID = @id";
        public static string getTestResults = "SELECT * FROM testresults WHERE NationalHealthNumber = @id";
        public static string getPrescriptions = "SELECT * FROM prescriptions WHERE NationalHealthNumber = @id";
        public static string getAvailability = "SELECT * FROM availability WHERE NationalHealthNumber = @id";
        //public static string getDuty = "SELECT * FROM rota WHERE Shift1 = @day OR Shift2 = @day OR Shift3 = @day OR Shift4 = @day OR Shift5 = @day OR Shift6 = @day OR Shift7 = @day";
        public static string getDuty = "SELECT Title, FirstName, LastName, Occupation FROM employee WHERE rotaID = (SELECT rotaID FROM rota WHERE Shift1 = @day OR Shift2 = @day OR Shift3 = @day OR Shift4 = @day OR Shift5 = @day OR Shift6 = @day OR Shift7 = @day)";
        public static string getPrescriptionDuration = "SELECT duration FROM prescriptions WHERE prescriptionID = @id";
        //public static string getEmployeeIDByName = "SELECT * FROM employee WHERE firstName = @firstName and lastName = @lastName";
        public static string isEmployeeAvailable = "";//join employee rota and appointments, and show which one is on and that day and doesnt have a conflicting appointment

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