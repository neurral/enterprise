namespace Enterprise.Organization {
    export class TimeRecordForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.TimeRecord';

    }

    export interface TimeRecordForm {
        PersonnelId: Serenity.LookupEditor;
        WorkDate: Serenity.DateEditor;
        TimeStart: Serenity.StringEditor;
        TimeEnd: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        Status: Serenity.StringEditor;
    }

    [['PersonnelId', () => Serenity.LookupEditor], ['WorkDate', () => Serenity.DateEditor], ['TimeStart', () => Serenity.StringEditor], ['TimeEnd', () => Serenity.StringEditor], ['Remarks', () => Serenity.StringEditor], ['Status', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(TimeRecordForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

