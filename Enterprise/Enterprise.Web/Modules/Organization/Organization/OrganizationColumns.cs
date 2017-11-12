
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.Organization")]
    [BasedOnRow(typeof(Entities.OrganizationRow))]
    public class OrganizationColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 OrganizationId { get; set; }
        [EditLink]
        public String Name { get; set; }
        public String OwnerUsername { get; set; }
    }
}