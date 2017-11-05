
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.TimeRecordType")]
    [BasedOnRow(typeof(Entities.TimeRecordTypeRow))]
    public class TimeRecordTypeForm
    {
        public String Code { get; set; }
        public String TimeRecordTypeName { get; set; }
    }
}