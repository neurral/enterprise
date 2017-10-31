namespace Enterprise.Organization {
    export class PersonnelStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.PersonnelStatus';

    }

    export interface PersonnelStatusForm {
        Sequence: Serenity.IntegerEditor;
        PersonnelStatusName: Serenity.StringEditor;
    }

    [['Sequence', () => Serenity.IntegerEditor], ['PersonnelStatusName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(PersonnelStatusForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

