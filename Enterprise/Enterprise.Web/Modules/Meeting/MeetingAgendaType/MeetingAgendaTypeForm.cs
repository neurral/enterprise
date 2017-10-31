
namespace Enterprise.Organization.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Organization.MeetingAgendaType")]
    [BasedOnRow(typeof(Entities.MeetingAgendaTypeRow))]
    public class MeetingAgendaTypeForm
    {
        public String Name { get; set; }
    }
}