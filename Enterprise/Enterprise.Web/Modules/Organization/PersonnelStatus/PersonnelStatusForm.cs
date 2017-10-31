
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.PersonnelStatus")]
    [BasedOnRow(typeof(Entities.PersonnelStatusRow))]
    public class PersonnelStatusForm
    {
        public Int32 Sequence { get; set; }
        public String PersonnelStatusName { get; set; }
    }
}