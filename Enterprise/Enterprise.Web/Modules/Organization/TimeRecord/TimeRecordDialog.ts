
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TimeRecordDialog extends Serenity.EntityDialog<TimeRecordRow, any> {
        protected getFormKey() { return TimeRecordForm.formKey; }
        protected getIdProperty() { return TimeRecordRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordRow.localTextPrefix; }
        protected getNameProperty() { return TimeRecordRow.nameProperty; }
        protected getService() { return TimeRecordService.baseUrl; }

        protected form = new TimeRecordForm(this.idPrefix);

    }
}