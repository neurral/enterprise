
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using static Constants;

    [FormScript("Organization.TimeRecord")]
    [BasedOnRow(typeof(Entities.TimeRecordRow))]
    public class TimeRecordForm
    {
        public Int64 PersonnelId { get; set; }
        public DateTime WorkDate { get; set; }

        public Int64 TimeRecordTypeId { get; set; }
        [TimeEditor]
        public TimeSpan TimeStart { get; set; }
        [TimeEditor]
        public TimeSpan TimeEnd { get; set; }
        [TextAreaEditor]
        public String Remarks { get; set; }
        public ApprovalStatuses Status { get; set; }
    }
}