
namespace Enterprise.Organization {
    export class OrganizationForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.Organization';
    }

    export interface OrganizationForm {
        Name: Serenity.StringEditor;
        OwnerId: Serenity.IntegerEditor;
    }

    [,
        ['Name', () => Serenity.StringEditor],
        ['OwnerId', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(OrganizationForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}