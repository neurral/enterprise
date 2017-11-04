
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MeetingDecisionDialog extends TemplateDialog<MeetingDecisionRow, any> {
        protected getFormKey() { return MeetingDecisionForm.formKey; }
        protected getIdProperty() { return MeetingDecisionRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingDecisionRow.localTextPrefix; }
        protected getNameProperty() { return MeetingDecisionRow.nameProperty; }
        protected getService() { return MeetingDecisionService.baseUrl; }

        protected form = new MeetingDecisionForm(this.idPrefix);

    }
}