
namespace Enterprise.Organization.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Organization.MeetingType")]
    [BasedOnRow(typeof(Entities.MeetingTypeRow))]
    public class MeetingTypeForm
    {
        public String Name { get; set; }
    }
}