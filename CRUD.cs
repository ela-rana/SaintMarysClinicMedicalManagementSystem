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
    }

    /// <summary>
    /// A class that implements the CRUD interface to perform all CRUD/Find operations required on the database
    /// </summary>
    class MMSCRUD : CRUD
    {
        MedicalManagementSystemEntities DB; //makes an object variable of the MMS database's representation
                                            //(DBContext) within this project
                                           
        public MMSCRUD()
        {
            DB = new MedicalManagementSystemEntities(); //initialize our database representing object
            
        }
    }

}
