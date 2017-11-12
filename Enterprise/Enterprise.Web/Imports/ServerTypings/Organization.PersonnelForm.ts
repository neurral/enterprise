namespace Enterprise.Organization {
    export class PersonnelForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.Personnel';

    }

    export interface PersonnelForm {
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        MiddleName: Serenity.StringEditor;
        Gender: Serenity.EnumEditor;
        DateOfBirth: Serenity.DateEditor;
        Email: Serenity.StringEditor;
        ContactNumber: Serenity.StringEditor;
        IdentificationNo: Serenity.StringEditor;
        PersonnelStatus: Serenity.LookupEditor;
        UserId: Serenity.LookupEditor;
        DateStarted: Serenity.DateEditor;
        DateExited: Serenity.DateEditor;
    }

    [['FirstName', () => Serenity.StringEditor], ['LastName', () => Serenity.StringEditor], ['MiddleName', () => Serenity.StringEditor], ['Gender', () => Serenity.EnumEditor], ['DateOfBirth', () => Serenity.DateEditor], ['Email', () => Serenity.StringEditor], ['ContactNumber', () => Serenity.StringEditor], ['IdentificationNo', () => Serenity.StringEditor], ['PersonnelStatus', () => Serenity.LookupEditor], ['UserId', () => Serenity.LookupEditor], ['DateStarted', () => Serenity.DateEditor], ['DateExited', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(PersonnelForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

