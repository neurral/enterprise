
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

        [Width(80)]
        public String IdentificationNo { get; set; }

        public String LastName { get; set; }
        public String FirstName { get; set; }
        public String Email { get; set; }

        [Width(130)]
        public String ContactNumber { get; set; }

        [Width(80)]
        public String PersonnelStatusName { get; set; }

        [DateTimeFormatter(DisplayFormat ="yyyy/MM/dd")]
        public DateTime DateStarted { get; set; }

        [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd")]
        public DateTime DateExited { get; set; }

        [DateTimeFormatter(DisplayFormat = "yyyy/MM/dd")]
        public DateTime DateOfBirth { get; set; }

        public String UserUsername { get; set; }
    }
}