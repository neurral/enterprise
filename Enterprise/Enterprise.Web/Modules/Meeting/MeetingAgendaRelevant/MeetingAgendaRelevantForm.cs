
namespace Enterprise.Organization.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Organization.MeetingAgendaRelevant")]
    [BasedOnRow(typeof(Entities.MeetingAgendaRelevantRow))]
    public class MeetingAgendaRelevantForm
    {
        public Int32 AgendaId { get; set; }
        public Int32 ContactId { get; set; }
    }
}