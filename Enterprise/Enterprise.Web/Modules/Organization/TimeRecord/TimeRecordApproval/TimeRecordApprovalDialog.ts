
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TimeRecordApprovalDialog extends TemplateDialog<TimeRecordApprovalRow, any> {
        protected getFormKey() { return TimeRecordApprovalForm.formKey; }
        protected getIdProperty() { return TimeRecordApprovalRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordApprovalRow.localTextPrefix; }
        protected getNameProperty() { return TimeRecordApprovalRow.nameProperty; }
        protected getService() { return TimeRecordApprovalService.baseUrl; }

        protected form = new TimeRecordApprovalForm(this.idPrefix);

    }
}