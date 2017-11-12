
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class OrganizationDialog extends Serenity.EntityDialog<OrganizationRow, any> {
        protected getFormKey() { return OrganizationForm.formKey; }
        protected getIdProperty() { return OrganizationRow.idProperty; }
        protected getLocalTextPrefix() { return OrganizationRow.localTextPrefix; }
        protected getNameProperty() { return OrganizationRow.nameProperty; }
        protected getService() { return OrganizationService.baseUrl; }

        protected form = new OrganizationForm(this.idPrefix);

    }
}