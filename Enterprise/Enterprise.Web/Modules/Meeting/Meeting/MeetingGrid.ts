
namespace Enterprise.Organization {
    
    @Serenity.Decorators.registerClass()
    export class MeetingGrid extends Serenity.EntityGrid<MeetingRow, any> {
        protected getColumnsKey() { return 'Organization.Meeting'; }
        protected getDialogType() { return MeetingDialog; }
        protected getIdProperty() { return MeetingRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingRow.localTextPrefix; }
        protected getService() { return MeetingService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}