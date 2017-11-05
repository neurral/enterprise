namespace Enterprise.Organization {
    export class TimeRecordTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.TimeRecordType';

    }

    export interface TimeRecordTypeForm {
        Code: Serenity.StringEditor;
        TimeRecordTypeName: Serenity.StringEditor;
    }

    [['Code', () => Serenity.StringEditor], ['TimeRecordTypeName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(TimeRecordTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

