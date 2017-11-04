/// <reference path="../../_Common/Templates/TemplateDialog.ts" />

namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BusinessUnitDialog extends TemplateDialog<BusinessUnitRow, any> {
        protected getFormKey() { return BusinessUnitForm.formKey; }
        protected getIdProperty() { return BusinessUnitRow.idProperty; }
        protected getLocalTextPrefix() { return BusinessUnitRow.localTextPrefix; }
        protected getNameProperty() { return BusinessUnitRow.nameProperty; }
        protected getService() { return BusinessUnitService.baseUrl; }

        protected form = new BusinessUnitForm(this.idPrefix);

    }
}