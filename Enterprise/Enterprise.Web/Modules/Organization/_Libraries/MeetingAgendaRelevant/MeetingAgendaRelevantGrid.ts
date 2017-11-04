
namespace Enterprise.Organization {
    
    @Serenity.Decorators.registerClass()
    export class MeetingAgendaRelevantGrid extends TemplateGrid<MeetingAgendaRelevantRow, any> {
        protected getColumnsKey() { return 'Organization.MeetingAgendaRelevant'; }
        protected getDialogType() { return MeetingAgendaRelevantDialog; }
        protected getIdProperty() { return MeetingAgendaRelevantRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingAgendaRelevantRow.localTextPrefix; }
        protected getService() { return MeetingAgendaRelevantService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}