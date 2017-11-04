
namespace Enterprise.Organization {
    
    @Serenity.Decorators.registerClass()
    export class MeetingTypeGrid extends TemplateGrid<MeetingTypeRow, any> {
        protected getColumnsKey() { return 'Organization.MeetingType'; }
        protected getDialogType() { return MeetingTypeDialog; }
        protected getIdProperty() { return MeetingTypeRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingTypeRow.localTextPrefix; }
        protected getService() { return MeetingTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}