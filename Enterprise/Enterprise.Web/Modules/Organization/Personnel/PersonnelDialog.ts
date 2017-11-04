
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PersonnelDialog extends TemplateDialog<PersonnelRow, any> {
        protected getFormKey() { return PersonnelForm.formKey; }
        protected getIdProperty() { return PersonnelRow.idProperty; }
        protected getLocalTextPrefix() { return PersonnelRow.localTextPrefix; }
        protected getNameProperty() { return PersonnelRow.nameProperty; }
        protected getService() { return PersonnelService.baseUrl; }

        protected form = new PersonnelForm(this.idPrefix);

    }
}