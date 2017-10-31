
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.PersonnelStatus")]
    [BasedOnRow(typeof(Entities.PersonnelStatusRow))]
    public class PersonnelStatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PersonnelStatusId { get; set; }
        public Int32 Sequence { get; set; }
        [EditLink]
        public String PersonnelStatusName { get; set; }
    }
}