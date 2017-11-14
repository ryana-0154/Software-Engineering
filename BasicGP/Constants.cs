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
        public static string getAppointments = "SELECT * FROM appointment WHERE NationalHealthNumber = @id OR EmployeeID = @eID";
        public static string getTestResults = "SELECT * FROM testresults WHERE NationalHealthNumber = @id";
        public static string getPrescriptions = "SELECT * FROM prescriptions WHERE NationalHealthNumber = @id";
        public static string getAvailability = "SELECT * FROM availability WHERE NationalHealthNumber = @id";
        public static string getDuty = "SELECT * FROM duty WHERE NationalHealthNumber = @id";
        public static string getPrescriptionDuration = "SELECT duration FROM prescriptions WHERE prescriptionID = @id";
        //public static string getEmployeeIDByName = "SELECT * FROM employee WHERE firstName = @firstName and lastName = @lastName";

        // Insert Statements
        public static string postPatient = "INSERT INTO patients (NationalHealthNumber, Name, Title, DOB, PhoneNumber, Address, Diabetes, Smoker, Asthma, Allergies) " +
                        "VALUES (@NHNumber, @name, @title, @DOB, @phoneNumber, @address, @diabetes, @smoker, @asthma, @allergies)";
        public static string postAppointment = "INSERT INTO appointment ( EmployeeID, NationalHealthNumber, Date, Time, Description) VALUES ( " +
            "(SELECT EmployeeID FROM Employee WHERE Title = @title AND FirstName = @firstname AND LastName = @lastname), @NHNumber, @Date, @Time, @Description)";

        // UPDATE statements
        public static string extendPrescriptionDuration = "UPDATE prescriptions SET DatePrescribed = @date WHERE PrescriptionID = @prescriptionID";
        //public static string updateAppointment = "UPDATE appointments SET ";

        // DELETE statements
        public static string cancelAppointment = "DELETE FROM appointment WHERE AppointmentID = @appointmentID";
    }
}
