
namespace Enterprise.Organization {
    
    @Serenity.Decorators.registerClass()
    export class MeetingAgendaTypeGrid extends TemplateGrid<MeetingAgendaTypeRow, any> {
        protected getColumnsKey() { return 'Organization.MeetingAgendaType'; }
        protected getDialogType() { return MeetingAgendaTypeDialog; }
        protected getIdProperty() { return MeetingAgendaTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingAgendaTypeRow.localTextPrefix; }
        protected getService() { return MeetingAgendaTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}