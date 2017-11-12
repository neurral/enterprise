
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using static Constants;

    [ColumnsScript("Organization.TimeRecord")]
    [BasedOnRow(typeof(Entities.TimeRecordRow))]
    public class TimeRecordColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 TimeRecordId { get; set; }
        [Visible(false)]
        public Int64 PersonnelId { get; set; }
        public String PersonnelIdentificationNo { get; set; }
        public DateTime WorkDate { get; set; }
        public Int64 TimeRecordTypeId;
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        [EditLink]
        public String Remarks { get; set; }
        public ApprovalStatuses Status { get; set; }
        public DateTime InsertDate { get; set; }
        public String InsertUserUsername { get; set; }
    }
}