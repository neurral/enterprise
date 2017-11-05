
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.Personnel")]
    [BasedOnRow(typeof(Entities.PersonnelRow))]
    public class PersonnelForm
    {
        public String IdentificationNo { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String ContactNumber { get; set; }
        public Int32 PersonnelStatus { get; set; }
        public String Gender { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateExited { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Int32 UserId { get; set; }
    }
}