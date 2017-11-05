
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class TimeRecordTypeGrid extends Serenity.EntityGrid<TimeRecordTypeRow, any> {
        protected getColumnsKey() { return 'Organization.TimeRecordType'; }
        protected getDialogType() { return TimeRecordTypeDialog; }
        protected getIdProperty() { return TimeRecordTypeRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordTypeRow.localTextPrefix; }
        protected getService() { return TimeRecordTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}