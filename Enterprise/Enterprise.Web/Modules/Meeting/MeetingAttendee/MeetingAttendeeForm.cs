
namespace Enterprise.Organization.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Organization.MeetingAttendee")]
    [BasedOnRow(typeof(Entities.MeetingAttendeeRow))]
    public class MeetingAttendeeForm
    {
        public Int32 MeetingId { get; set; }
        public Int32 ContactId { get; set; }
        public Int32 AttendeeType { get; set; }
        public Int32 AttendanceStatus { get; set; }
    }
}