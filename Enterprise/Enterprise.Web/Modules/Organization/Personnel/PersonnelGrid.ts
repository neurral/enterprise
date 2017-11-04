/// <reference path="../../_Common/Templates/TemplateGrid.ts" />

namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class PersonnelGrid extends TemplateGrid<PersonnelRow, any> {
        protected getColumnsKey() { return 'Organization.Personnel'; }
        protected getDialogType() { return PersonnelDialog; }
        protected getIdProperty() { return PersonnelRow.idProperty; }
        protected getLocalTextPrefix() { return PersonnelRow.localTextPrefix; }
        protected getService() { return PersonnelService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}