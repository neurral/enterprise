namespace Enterprise.Organization {
    export class MeetingForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.Meeting';

    }

    export interface MeetingForm {
        MeetingName: Serenity.StringEditor;
        MeetingTypeId: Serenity.IntegerEditor;
        MeetingNumber: Serenity.StringEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        LocationId: Serenity.IntegerEditor;
        UnitId: Serenity.IntegerEditor;
        OrganizerContactId: Serenity.IntegerEditor;
        ReporterContactId: Serenity.IntegerEditor;
        AttendeeList: Serenity.StringEditor;
    }

    [['MeetingName', () => Serenity.StringEditor], ['MeetingTypeId', () => Serenity.IntegerEditor], ['MeetingNumber', () => Serenity.StringEditor], ['StartDate', () => Serenity.DateEditor], ['EndDate', () => Serenity.DateEditor], ['LocationId', () => Serenity.IntegerEditor], ['UnitId', () => Serenity.IntegerEditor], ['OrganizerContactId', () => Serenity.IntegerEditor], ['ReporterContactId', () => Serenity.IntegerEditor], ['AttendeeList', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MeetingForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

