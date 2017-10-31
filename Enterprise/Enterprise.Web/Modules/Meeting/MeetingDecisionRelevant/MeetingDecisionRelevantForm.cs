
namespace Enterprise.Organization.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Organization.MeetingDecisionRelevant")]
    [BasedOnRow(typeof(Entities.MeetingDecisionRelevantRow))]
    public class MeetingDecisionRelevantForm
    {
        public Int32 DecisionId { get; set; }
        public Int32 ContactId { get; set; }
    }
}