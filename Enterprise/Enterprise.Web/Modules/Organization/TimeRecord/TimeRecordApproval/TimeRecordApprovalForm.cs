
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.TimeRecordApproval")]
    [BasedOnRow(typeof(Entities.TimeRecordApprovalRow))]
    public class TimeRecordApprovalForm
    {
        public Int64 TimeRecordId { get; set; }
        public Int64 RequestorId { get; set; }
        public String ApprovalStatus { get; set; }
        public Boolean RequestorLocked { get; set; }
        public Boolean ApproverLocked { get; set; }
        public DateTime DateReviewed { get; set; }
        public DateTime UpdateDate { get; set; }
        public Int64 UpdateUserId { get; set; }
        public DateTime InsertDate { get; set; }
        public Int64 InsertUserId { get; set; }
    }
}