
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class TimeRecordApprovalGrid extends Serenity.EntityGrid<TimeRecordApprovalRow, any> {
        protected getColumnsKey() { return 'Organization.TimeRecordApproval'; }
        protected getDialogType() { return TimeRecordApprovalDialog; }
        protected getIdProperty() { return TimeRecordApprovalRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordApprovalRow.localTextPrefix; }
        protected getService() { return TimeRecordApprovalService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}