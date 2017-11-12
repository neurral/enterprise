namespace Enterprise.Organization {
    export class TimeRecordApprovalForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.TimeRecordApproval';

    }

    export interface TimeRecordApprovalForm {
        TimeRecordId: Serenity.StringEditor;
        RequestorId: Serenity.StringEditor;
        ApprovalStatus: Serenity.EnumEditor;
        RequestorLocked: Serenity.BooleanEditor;
        ApproverLocked: Serenity.BooleanEditor;
        DateReviewed: Serenity.DateEditor;
    }

    [['TimeRecordId', () => Serenity.StringEditor], ['RequestorId', () => Serenity.StringEditor], ['ApprovalStatus', () => Serenity.EnumEditor], ['RequestorLocked', () => Serenity.BooleanEditor], ['ApproverLocked', () => Serenity.BooleanEditor], ['DateReviewed', () => Serenity.DateEditor]].forEach(x => Object.defineProperty(TimeRecordApprovalForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

