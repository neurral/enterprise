
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

    [FormScript("Organization.TimeRecordApproval")]
    [BasedOnRow(typeof(Entities.TimeRecordApprovalRow))]
    public class TimeRecordApprovalForm
    {
        public Int64 TimeRecordId { get; set; }
        public Int64 RequestorId { get; set; }
        public ApprovalStatuses ApprovalStatus { get; set; }
        public Boolean RequestorLocked { get; set; }
        public Boolean ApproverLocked { get; set; }
        public DateTime DateReviewed { get; set; }
    }
}