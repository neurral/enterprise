
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PersonnelStatusDialog extends TemplateDialog<PersonnelStatusRow, any> {
        protected getFormKey() { return PersonnelStatusForm.formKey; }
        protected getIdProperty() { return PersonnelStatusRow.idProperty; }
        protected getLocalTextPrefix() { return PersonnelStatusRow.localTextPrefix; }
        protected getNameProperty() { return PersonnelStatusRow.nameProperty; }
        protected getService() { return PersonnelStatusService.baseUrl; }

        protected form = new PersonnelStatusForm(this.idPrefix);

    }
}