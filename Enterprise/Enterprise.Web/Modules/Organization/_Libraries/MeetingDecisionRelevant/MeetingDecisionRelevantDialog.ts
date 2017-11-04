
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MeetingDecisionRelevantDialog extends TemplateDialog<MeetingDecisionRelevantRow, any> {
        protected getFormKey() { return MeetingDecisionRelevantForm.formKey; }
        protected getIdProperty() { return MeetingDecisionRelevantRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingDecisionRelevantRow.localTextPrefix; }
        protected getService() { return MeetingDecisionRelevantService.baseUrl; }

        protected form = new MeetingDecisionRelevantForm(this.idPrefix);

    }
}