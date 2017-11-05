
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.TimeRecordApproval")]
    [BasedOnRow(typeof(Entities.TimeRecordApprovalRow))]
    public class TimeRecordApprovalColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 ApprovalId { get; set; }
        public String TimeRecordRemarks { get; set; }
        public String RequestorIdentificationNo { get; set; }
        [EditLink]
        public String ApprovalStatus { get; set; }
        public Boolean RequestorLocked { get; set; }
        public Boolean ApproverLocked { get; set; }
        public DateTime DateReviewed { get; set; }
        public DateTime UpdateDate { get; set; }
        public String UpdateUserUsername { get; set; }
        public DateTime InsertDate { get; set; }
        public String InsertUserUsername { get; set; }
    }
}