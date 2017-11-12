
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class OrganizationGrid extends Serenity.EntityGrid<OrganizationRow, any> {
        protected getColumnsKey() { return 'Organization.Organization'; }
        protected getDialogType() { return OrganizationDialog; }
        protected getIdProperty() { return OrganizationRow.idProperty; }
        protected getLocalTextPrefix() { return OrganizationRow.localTextPrefix; }
        protected getService() { return OrganizationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected addButtonClick() {
            this.editItem(<OrganizationRow>{
                OwnerId: Utils.getUser().UserId
            });
        }
    }
}