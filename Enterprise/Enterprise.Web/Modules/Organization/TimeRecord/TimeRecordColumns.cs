
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight, SortOrder(2)]
        public Int64 TimeRecordId { get; set; }

        [Visible(false)]
        public Int64 PersonnelId { get; set; }
        [Width(90)]
        public String PersonnelIdentificationNo { get; set; }
        public String PersonnelFullName { get; set; }

        [SortOrder(1,true)]
        public DateTime WorkDate { get; set; }

        public Int64 TimeRecordTypeId;
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public String Remarks { get; set; }

        [Width(100)]
        public ApprovalStatuses Status { get; set; }
    }
}