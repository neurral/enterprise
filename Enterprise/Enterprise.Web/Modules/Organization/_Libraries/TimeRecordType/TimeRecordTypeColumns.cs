
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.TimeRecordType")]
    [BasedOnRow(typeof(Entities.TimeRecordTypeRow))]
    public class TimeRecordTypeColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 TimeRecordTypeId { get; set; }
        [EditLink]
        public String Code { get; set; }
        public String TimeRecordTypeName { get; set; }
    }
}