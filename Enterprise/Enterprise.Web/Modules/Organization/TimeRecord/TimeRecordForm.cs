
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.TimeRecord")]
    [BasedOnRow(typeof(Entities.TimeRecordRow))]
    public class TimeRecordForm
    {
        public Int64 PersonnelId { get; set; }
        public DateTime WorkDate { get; set; }
        public TimeSpan TimeStart { get; set; }
        public TimeSpan TimeEnd { get; set; }
        public String Remarks { get; set; }
        public String Status { get; set; }
        public DateTime InsertDate { get; set; }
        public Int64 InsertUserId { get; set; }
    }
}