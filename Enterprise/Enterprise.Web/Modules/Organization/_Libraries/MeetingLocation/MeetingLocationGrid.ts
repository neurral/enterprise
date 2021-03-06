﻿
namespace Enterprise.Organization {
    
    @Serenity.Decorators.registerClass()
    export class MeetingLocationGrid extends TemplateGrid<MeetingLocationRow, any> {
        protected getColumnsKey() { return 'Organization.MeetingLocation'; }
        protected getDialogType() { return MeetingLocationDialog; }
        protected getIdProperty() { return MeetingLocationRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingLocationRow.localTextPrefix; }
        protected getService() { return MeetingLocationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}