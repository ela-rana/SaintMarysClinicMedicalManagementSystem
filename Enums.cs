//THis file consists of all enums used in this project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintMarysClinicMedicalManagementSystem
{
    /// <summary>
    /// Enum that represents all possible User types for the MMSUser table integer field UserType
    /// </summary>
    public enum UserTypes
    {
        Patient=1,
        MedicalCareTeamMember,
        AdministrativeTeamMember
    }

    /// <summary>
    /// Enum that represents all possible Employee types for the MMSUser table integer field UserType
    /// </summary>
    public enum EmpTypes
    {
        AdministrativeTeamMember = 1,
        MedicalDoctor,
        PhysiciansAssistant,
        NursePractitioner,
        Nurse,
        MedicalTech
    }

    /// <summary>
    /// Enum that represents all possible Specialties for the Employee table field Specialty
    /// </summary>
    public enum Specialties
    {
        General=1,
        PrimaryCare,
        MedicalSurgical,
        Surgical,
        Dermatology,
        Cardiology,
        EarNoseThroat,
        Other
    }

    /// <summary>
    /// Enum that represents all possible appointment length types for the Appointment table integer field Duration
    /// </summary>
    public enum Durations
    {
        ThirtyMinutes = 30,
        SixtyMinutes = 60
    }



}
