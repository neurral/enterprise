﻿
namespace Enterprise.Organization {
    
    @Serenity.Decorators.registerClass()
    export class MeetingDecisionRelevantGrid extends TemplateGrid<MeetingDecisionRelevantRow, any> {
        protected getColumnsKey() { return 'Organization.MeetingDecisionRelevant'; }
        protected getDialogType() { return MeetingDecisionRelevantDialog; }
        protected getIdProperty() { return MeetingDecisionRelevantRow.idProperty; }
        protected getLocalTextPrefix() { return MeetingDecisionRelevantRow.localTextPrefix; }
        protected getService() { return MeetingDecisionRelevantService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}