
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;    
    using static Constants;

    [FormScript("Organization.Personnel")]
    [BasedOnRow(typeof(Entities.PersonnelRow))]
    public class PersonnelForm
    {
        [Category("Personal Info")]

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String MiddleName { get; set; }
        
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }

        [Category("Contact Info")]
        public String Email { get; set; }
        public String ContactNumber { get; set; }

        [Category("Employment Info")]
        public String IdentificationNo { get; set; }
        public Int32 PersonnelStatus { get; set; }
        public Int32 UserId { get; set; }
        [ReadOnly(true)]
        public DateTime DateStarted { get; set; }
        public DateTime DateExited { get; set; }

    }
}