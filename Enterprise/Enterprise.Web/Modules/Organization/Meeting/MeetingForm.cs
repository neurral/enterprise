
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.Meeting")]
    [BasedOnRow(typeof(Entities.MeetingRow))]
    public class MeetingForm
    {
        public String MeetingName { get; set; }
        public String MeetingNumber { get; set; }
        public Guid MeetingGuid { get; set; }
        public Int32 MeetingTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 LocationId { get; set; }
        public Int32 OrganizerContactId { get; set; }
        public Int32 ReporterContactId { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}