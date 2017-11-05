
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.Personnel")]
    [BasedOnRow(typeof(Entities.PersonnelRow))]
    public class PersonnelColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PersonnelId { get; set; }
        [EditLink]
        public String IdentificationNo { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String ContactNumber { get; set; }
        public String PersonnelStatusName { get; set; }
        public String Gender { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateExited { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String UserUsername { get; set; }
    }
}