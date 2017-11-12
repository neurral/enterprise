
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

    [ColumnsScript("Organization.TimeRecordApproval")]
    [BasedOnRow(typeof(Entities.TimeRecordApprovalRow))]
    public class TimeRecordApprovalColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 ApprovalId { get; set; }
        public Int64 ApproverId { get; set; }
        public String ApproverFullName { get; set; }
        public Int64 TimeRecordId {get;set;}
        public String RequestorIdentificationNo { get; set; }
        public String RequestorFullName { get; set; }
        public ApprovalStatuses ApprovalStatus { get; set; }
        public String TimeRecordRemarks { get; set; }
        public Boolean RequestorLocked { get; set; }
        public Boolean ApproverLocked { get; set; }
        public DateTime DateReviewed { get; set; }
    }
}