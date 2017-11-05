namespace Enterprise.Organization {
    export class TimeRecordApprovalForm extends Serenity.PrefixedContext {
        static formKey = 'Organization.TimeRecordApproval';

    }

    export interface TimeRecordApprovalForm {
        TimeRecordId: Serenity.StringEditor;
        RequestorId: Serenity.StringEditor;
        ApprovalStatus: Serenity.StringEditor;
        RequestorLocked: Serenity.BooleanEditor;
        ApproverLocked: Serenity.BooleanEditor;
        DateReviewed: Serenity.DateEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.StringEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.StringEditor;
    }

    [['TimeRecordId', () => Serenity.StringEditor], ['RequestorId', () => Serenity.StringEditor], ['ApprovalStatus', () => Serenity.StringEditor], ['RequestorLocked', () => Serenity.BooleanEditor], ['ApproverLocked', () => Serenity.BooleanEditor], ['DateReviewed', () => Serenity.DateEditor], ['UpdateDate', () => Serenity.DateEditor], ['UpdateUserId', () => Serenity.StringEditor], ['InsertDate', () => Serenity.DateEditor], ['InsertUserId', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(TimeRecordApprovalForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

