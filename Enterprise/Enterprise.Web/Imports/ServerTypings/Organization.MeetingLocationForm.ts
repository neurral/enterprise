namespace Enterprise.Organization {
    export class MeetingLocationForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.MeetingLocation';

    }

    export interface MeetingLocationForm {
        Name: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Latitude: Serenity.DecimalEditor;
        Longitude: Serenity.DecimalEditor;
    }

    [['Name', () => Serenity.StringEditor], ['Address', () => Serenity.StringEditor], ['Latitude', () => Serenity.DecimalEditor], ['Longitude', () => Serenity.DecimalEditor]].forEach(x => Object.defineProperty(MeetingLocationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

