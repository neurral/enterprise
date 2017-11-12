
namespace Enterprise.Organization {

    @Serenity.Decorators.registerClass()
    export class TimeRecordGrid extends TemplateGrid<TimeRecordRow, any> {
        protected getColumnsKey() { return 'Organization.TimeRecord'; }
        protected getDialogType() { return TimeRecordDialog; }
        protected getIdProperty() { return TimeRecordRow.idProperty; }
        protected getLocalTextPrefix() { return TimeRecordRow.localTextPrefix; }
        protected getService() { return TimeRecordService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected addButtonClick() {
            Utils.getPersonnelRecord(Utils.getUser().UserId)
                .then(
                (res) => {
                    this.editItem(<TimeRecordRow>{
                        PersonnelId: (<PersonnelRow>res.Entity).PersonnelId,
                        WorkDate: new Date().toUTCString()
                    });
                },
                (xhr, status, err) => {
                    console.log(JSON.stringify(err));
                    super.addButtonClick();
                }
                );

        }
    }
}