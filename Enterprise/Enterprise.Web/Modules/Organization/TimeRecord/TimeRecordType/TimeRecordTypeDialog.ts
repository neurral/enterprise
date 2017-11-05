
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TimeRecordTypeDialog extends Serenity.EntityDialog<TimeRecordTypeRow, any> {
        protected getFormKey() { return TimeRecordTypeForm.formKey; }
        protected getIdProperty() { return TimeRecordTypeRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordTypeRow.localTextPrefix; }
        protected getNameProperty() { return TimeRecordTypeRow.nameProperty; }
        protected getService() { return TimeRecordTypeService.baseUrl; }

        protected form = new TimeRecordTypeForm(this.idPrefix);

    }
}