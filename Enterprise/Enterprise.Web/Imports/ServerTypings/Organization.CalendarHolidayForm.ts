namespace Enterprise.Organization {
    export class CalendarHolidayForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.CalendarHoliday';

    }

    export interface CalendarHolidayForm {
        Date: Serenity.DateEditor;
        TimeStart: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        NonWorkday: Serenity.BooleanEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.StringEditor;
    }

    [['Date', () => Serenity.DateEditor], ['TimeStart', () => Serenity.StringEditor], ['Description', () => Serenity.StringEditor], ['NonWorkday', () => Serenity.BooleanEditor], ['InsertDate', () => Serenity.DateEditor], ['InsertUserId', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(CalendarHolidayForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

