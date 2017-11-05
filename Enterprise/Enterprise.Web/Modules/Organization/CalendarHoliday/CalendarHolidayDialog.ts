
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CalendarHolidayDialog extends Serenity.EntityDialog<CalendarHolidayRow, any> {
        protected getFormKey() { return CalendarHolidayForm.formKey; }
        protected getIdProperty() { return CalendarHolidayRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarHolidayRow.localTextPrefix; }
        protected getNameProperty() { return CalendarHolidayRow.nameProperty; }
        protected getService() { return CalendarHolidayService.baseUrl; }

        protected form = new CalendarHolidayForm(this.idPrefix);

    }
}