//CRUD: Create Read Update Delete
//In this file, we create an interface with all the CRUD and find operations that we would need to do on our MMS database
//Then we implement this interface in the MMSCRUD class, where we define how we would do the CRUD/find operations on the database

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintMarysClinicMedicalManagementSystem
{
    /// <summary>
    /// An interface with all the CRUD and find operations that we can do on the database.
    /// (CRUD: Create Read Update Delete)
    /// </summary>
    interface CRUD
    {
        /// <summary>
        /// To search for a passed email in the database to see if it is already in the database
        /// </summary>
        /// <param name="email">the email string that we want to find</param>
        /// <returns>Boolean true if given email is already in the database records, and false if not</returns>
        bool emailAlreadyExists(string email); //to check if the passed email is already in database

        /// <summary>
        /// checks whether the email argument passed is associated with the password argument passed
        /// </summary>
        /// <param name="email">the string to represent the email you want to check</param>
        /// <param name="password">the string to represent the password you want to check</param>
        /// <returns>returns UserType for the email and password matched account or null if it doesn't match</returns>
        Nullable<UserTypes> ValidLogin(string email, string password);

        /// <summary>
        /// Adds passed user and corresponding patient record to database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="patient"></param>
        void AddNewPatient(MMSUser user, Patient patient);

        void AddNewEmployee(MMSUser user, Employee employee);

        MMSUser GetPatient(string email, out Patient patient);
        MMSUser GetEmployee(string email, out Employee employee);

        void UpdatePatient(MMSUser user, Patient patient);
        void UpdateEmployee(MMSUser user, Employee employee);

        int MaxUserID();

        List<Appointment> GetPatientAppointments(int id);
        List<Appointment> GetProviderAppointments(int id);
        List<Appointment> GetAllAppointments();
        List<MMSUser> GetAllPatientUsers();
        List<MMSUser> GetAllProviderUsers();

        void VerifyAppointment(int ApptID);

        Appointment GetAppointment(int ApptID);
    }

    /// <summary>
    /// A class that implements the CRUD interface to perform all CRUD/Find operations required on the database.
    /// (CRUD: Create Read Update Delete)
    /// </summary>
    class MMSCRUD : CRUD
    {
        MMSEntities DB; //makes an object variable of the MMS database's representation
                                            //(DBContext) within this project
                                           
        public MMSCRUD()
        {
            DB = new MMSEntities(); //initialize our database representing object
        }

        public void AddNewEmployee(MMSUser user, Employee employee)
        {
            DB.MMSUsers.Add(user);
            DB.Employees.Add(employee);
            DB.SaveChanges();
        }

        public void AddNewPatient(MMSUser user, Patient patient)
        {
            DB.MMSUsers.Add(user);
            DB.Patients.Add(patient);
            DB.SaveChanges();
        }

        public void AddNewAppointment(Appointment appointment)
        {
            DB.Appointments.Add(appointment);
            DB.SaveChanges();
        }

        public void DeleteAppointment(int id)
        {
            DB.Appointments.Remove(DB.Appointments.Find(id));
            DB.SaveChanges();
        }

        public bool emailAlreadyExists(string email)
        {
            bool found = false; //to set a default value of whether email was found in the database as false
            List<MMSUser> allUsers = DB.MMSUsers.ToList();  //to create a list to hold all User records
            foreach(MMSUser user in allUsers)   //go through each record in the User table
            {
                if(user.Email == email) //if the passed email matches the table record's email
                {
                    found = true;   //then set found to true
                    break;  //break out of the foreach loop. We don't need to search anymore since we already found a match
                }
            }
            return found; //return whether email matched the records or not. if it didn't then found will retain its default 
                            //false value and return it
        }

        public MMSUser GetPatient(string email, out Patient patient)
        {
            MMSUser currentUser = null;
            patient = null;
            List<MMSUser> allUsers = DB.MMSUsers.ToList();  //to create a list to hold all User records
            foreach (MMSUser user in allUsers)   //go through each record in the User table
            {
                if (user.Email == email) //if the passed email matches the table record's email
                {
                    currentUser = user;
                    patient = DB.Patients.Find(user.UserID); //return the Patient record for that email
                    break;  //break out of the foreach loop. We don't need to search anymore since we already found a match
                }
            }
            return currentUser; //return the User record for that email
        }

        public MMSUser GetEmployee(string email, out Employee employee)
        {
            MMSUser currentUser = null;
            employee = null;
            List<MMSUser> allUsers = DB.MMSUsers.ToList();  //to create a list to hold all User records
            foreach (MMSUser user in allUsers)   //go through each record in the User table
            {
                if (user.Email == email) //if the passed email matches the table record's email
                {
                    currentUser = user;
                    employee = DB.Employees.Find(user.UserID); //return the record for that email
                    break;  //break out of the foreach loop. We don't need to search anymore since we already found a match
                }
            }
            return currentUser; //return the User record for that email
        }

        public List<Appointment> GetPatientAppointments(int id)
        {
            List<Appointment> allAppointments = DB.Appointments.ToList();
            List<Appointment> thisPatientsAppointments = new List<Appointment>();
            foreach (Appointment a in allAppointments)
            {
                if (a.PatientUserID == id)
                {
                    thisPatientsAppointments.Add(a);
                }
            }
            return thisPatientsAppointments;
        }
        public List<Appointment> GetProviderAppointments(int id)
        {
            List<Appointment> allAppointments = DB.Appointments.ToList();
            List<Appointment> thisProvidersAppointments = new List<Appointment>();
            foreach (Appointment a in allAppointments)
            {
                if (a.ProviderUserID == id)
                {
                    thisProvidersAppointments.Add(a);
                }
            }
            return thisProvidersAppointments;
        }

        public int MaxUserID()
        {
            return DB.MMSUsers.Max(x => x.UserID);
        }
        public int MaxApptID()
        {
            return DB.Appointments.Max(x => x.ApptID);
        }

        public void UpdatePatient(MMSUser user, Patient patient)
        {
            MMSUser userToUpdate = DB.MMSUsers.Find(user.UserID);
            Patient patientToUpdate = DB.Patients.Find(user.UserID);
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.MiddleName = user.MiddleName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Phone = user.Phone;
            patientToUpdate.Address = patient.Address;
            patientToUpdate.DOB = patient.DOB;
            DB.SaveChanges();
        }
        public void UpdateEmployee(MMSUser user, Employee employee)
        {
            MMSUser userToUpdate = DB.MMSUsers.Find(user.UserID);
            Employee employeeToUpdate = DB.Employees.Find(user.UserID);
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.MiddleName = user.MiddleName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Phone = user.Phone;
            employeeToUpdate.EmpType = employee.EmpType;
            employeeToUpdate.Specialty = employee.Specialty;
            DB.SaveChanges();
        }

        public Nullable<UserTypes> ValidLogin(string email, string password)
        {
            Nullable<UserTypes> ut = null; //to set a default null value of whether email and password matched
            List<MMSUser> allUsers = DB.MMSUsers.ToList();  //to create a list to hold all User records
            foreach (MMSUser user in allUsers)   //go through each record in the User table
            {
                if (user.Email == email) //if the passed email matches the table record's email
                {
                    if(user.Passwrd == password)   //if the user provided password matches what is in the record for this email address
                    {
                        ut = (UserTypes)user.UserType;
                    }
                    break;  //break out of the foreach loop. We don't need to search anymore since we already found the email in our records
                }
            }
            return ut; //if the passed email is found and the password for that email matches the passed password the valid is set to true
                          //and returned, otherwise default false value is returned
        }

        public List<Appointment> GetAllAppointments()
        {
            return DB.Appointments.ToList();
        }

        public void VerifyAppointment(int ApptID)
        {
            Appointment ap = DB.Appointments.Find(ApptID);
            ap.Verified = true;
            DB.SaveChanges();
        }

        public Appointment GetAppointment(int ApptID)
        {
            return DB.Appointments.Find(ApptID);
        }

        public List<MMSUser> GetAllPatientUsers()
        {
            List<MMSUser> allUsers = DB.MMSUsers.ToList();  //to create a list to hold all User records
            List<MMSUser> patientUsers = new List<MMSUser>();  //to create a list to hold all patients' User records

            foreach (MMSUser user in allUsers)   //go through each record in the User table
            {
                if (user.UserType == 1) //if it is a patient record (user type 1)
                {
                    patientUsers.Add(user);
                }
            }
            return patientUsers;
        }
        public List<MMSUser> GetAllProviderUsers()
        {
            List<MMSUser> allUsers = DB.MMSUsers.ToList();  //to create a list to hold all User records
            List<MMSUser> providerUsers = new List<MMSUser>();  //to create a list to hold all providers' User records

            foreach (MMSUser user in allUsers)   //go through each record in the User table
            {
                
                if (user.UserType == 2) //if it is a medical employee record (user type 2)
                {
                    Employee e = DB.Employees.Find(user.UserID);    
                    if(e.EmpType>1 && e.EmpType<5)  //employee type 2,3,4 are providers (see enums.cs for all employee types)
                        providerUsers.Add(user);
                }
            }
            return providerUsers;
        }
    }

}
