
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.Meeting")]
    [BasedOnRow(typeof(Entities.MeetingRow))]
    public class MeetingColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MeetingId { get; set; }
        [EditLink]
        public String MeetingName { get; set; }
        public String MeetingNumber { get; set; }
        public Guid MeetingGuid { get; set; }
        public String MeetingTypeName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String LocationName { get; set; }
        public String OrganizerContactTitle { get; set; }
        public String ReporterContactTitle { get; set; }
        public Int32 InsertUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int32 UpdateUserId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}