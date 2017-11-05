
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class CalendarHolidayGrid extends Serenity.EntityGrid<CalendarHolidayRow, any> {
        protected getColumnsKey() { return 'Organization.CalendarHoliday'; }
        protected getDialogType() { return CalendarHolidayDialog; }
        protected getIdProperty() { return CalendarHolidayRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarHolidayRow.localTextPrefix; }
        protected getService() { return CalendarHolidayService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}