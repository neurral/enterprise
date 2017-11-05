
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class TimeRecordGrid extends Serenity.EntityGrid<TimeRecordRow, any> {
        protected getColumnsKey() { return 'Organization.TimeRecord'; }
        protected getDialogType() { return TimeRecordDialog; }
        protected getIdProperty() { return TimeRecordRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordRow.localTextPrefix; }
        protected getService() { return TimeRecordService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}