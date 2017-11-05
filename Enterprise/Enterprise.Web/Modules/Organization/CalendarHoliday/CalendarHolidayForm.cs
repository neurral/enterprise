
namespace Enterprise.Organization.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Organization.CalendarHoliday")]
    [BasedOnRow(typeof(Entities.CalendarHolidayRow))]
    public class CalendarHolidayForm
    {
        public DateTime Date { get; set; }
        public TimeSpan TimeStart { get; set; }
        public String Description { get; set; }
        public Boolean NonWorkday { get; set; }
        public DateTime InsertDate { get; set; }
        public Int64 InsertUserId { get; set; }
    }
}