﻿//CRUD: Create Read Update Delete
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
        Nullable<UserTypes> ValidLogin(string email, string password); //to check if the email and password are for the same account
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
    }

}