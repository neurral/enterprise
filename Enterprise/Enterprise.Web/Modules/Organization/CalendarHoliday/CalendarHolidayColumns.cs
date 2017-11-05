
namespace Enterprise.Organization.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Organization.CalendarHoliday")]
    [BasedOnRow(typeof(Entities.CalendarHolidayRow))]
    public class CalendarHolidayColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 CalendarHolidayId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan TimeStart { get; set; }
        [EditLink]
        public String Description { get; set; }
        public Boolean NonWorkday { get; set; }
        public DateTime InsertDate { get; set; }
        public String InsertUserUsername { get; set; }
    }
}