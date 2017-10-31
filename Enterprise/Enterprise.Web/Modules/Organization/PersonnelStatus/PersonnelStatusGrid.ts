
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class PersonnelStatusGrid extends Serenity.EntityGrid<PersonnelStatusRow, any> {
        protected getColumnsKey() { return 'Organization.PersonnelStatus'; }
        protected getDialogType() { return PersonnelStatusDialog; }
        protected getIdProperty() { return PersonnelStatusRow.idProperty; }
        protected getLocalTextPrefix() { return PersonnelStatusRow.localTextPrefix; }
        protected getService() { return PersonnelStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}