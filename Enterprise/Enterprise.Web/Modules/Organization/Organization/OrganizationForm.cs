
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.Organization")]
    [BasedOnRow(typeof(Entities.OrganizationRow))]
    public class OrganizationForm
    {
        public String Name { get; set; }
        public Int64 OwnerId { get; set; }
    }
}