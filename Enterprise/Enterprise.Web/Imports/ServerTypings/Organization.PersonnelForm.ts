namespace Enterprise.Organization {
    export class PersonnelForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.Personnel';

    }

    export interface PersonnelForm {
        IdentificationNo: Serenity.StringEditor;
        FirstName: Serenity.StringEditor;
        MiddleName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        PersonnelStatus: Serenity.LookupEditor;
        Gender: Serenity.StringEditor;
        DateStarted: Serenity.DateEditor;
        DateExited: Serenity.DateEditor;
        DateOfBirth: Serenity.DateEditor;
        UserId: Serenity.LookupEditor;
        IsActive: Serenity.BooleanEditor;
    }

    [['IdentificationNo', () => Serenity.StringEditor], ['FirstName', () => Serenity.StringEditor], ['MiddleName', () => Serenity.StringEditor], ['LastName', () => Serenity.StringEditor], ['Email', () => Serenity.StringEditor], ['PersonnelStatus', () => Serenity.LookupEditor], ['Gender', () => Serenity.StringEditor], ['DateStarted', () => Serenity.DateEditor], ['DateExited', () => Serenity.DateEditor], ['DateOfBirth', () => Serenity.DateEditor], ['UserId', () => Serenity.LookupEditor], ['IsActive', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(PersonnelForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

