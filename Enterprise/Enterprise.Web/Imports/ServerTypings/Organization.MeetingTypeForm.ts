namespace Enterprise.Organization {
    export class MeetingTypeForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.MeetingType';

    }

    export interface MeetingTypeForm {
        Name: Serenity.StringEditor;
    }

    [['Name', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(MeetingTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

