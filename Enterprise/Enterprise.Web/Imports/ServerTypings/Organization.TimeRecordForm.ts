namespace Enterprise.Organization {
    export class TimeRecordForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.TimeRecord';

    }

    export interface TimeRecordForm {
        PersonnelId: Serenity.LookupEditor;
        WorkDate: Serenity.DateEditor;
        TimeRecordTypeId: Serenity.LookupEditor;
        TimeStart: Serenity.TimeEditor;
        TimeEnd: Serenity.TimeEditor;
        Remarks: Serenity.TextAreaEditor;
        Status: Serenity.EnumEditor;
    }

    [['PersonnelId', () => Serenity.LookupEditor], ['WorkDate', () => Serenity.DateEditor], ['TimeRecordTypeId', () => Serenity.LookupEditor], ['TimeStart', () => Serenity.TimeEditor], ['TimeEnd', () => Serenity.TimeEditor], ['Remarks', () => Serenity.TextAreaEditor], ['Status', () => Serenity.EnumEditor]].forEach(x => Object.defineProperty(TimeRecordForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

