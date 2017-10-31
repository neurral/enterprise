using FluentMigrator;

namespace Enterprise.Migrations.DefaultDB
{
    [Migration(20161126210000)]
    public class DefaultDB_20161126_210000_Meeting_and_Contact : AutoReversingMigration
    {
        private const string SCHEMA = Constants.Enterprise_SCHEMA;
        public override void Up()
        {
            this.CreateTableWithId64("Contact", "ContactId", s => s
               .WithColumn("Title").AsString(30).Nullable()
               .WithColumn("FirstName").AsString(50).NotNullable()
               .WithColumn("LastName").AsString(50).NotNullable()
               .WithColumn("Email").AsString(100).NotNullable()
               .WithColumn("IdentityNo").AsString(20).Nullable()
               .WithColumn("UserId").AsInt64().Nullable()
                   .ForeignKey("FK_Contact_UserId", "User", "UserId"),
                   schema: SCHEMA, checkExists: true);

            this.CreateTableWithId64("MeetingLocation", "LocationId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Address").AsString(300).Nullable()
                .WithColumn("Latitude").AsDouble()
                .WithColumn("Longitude").AsDouble(), 
                schema: SCHEMA);

            this.CreateTableWithId64("MeetingTypes", "MeetingTypeId", s => s
                .WithColumn("Name").AsString(100).NotNullable(), 
                schema: SCHEMA);

            this.CreateTableWithId64("Meeting", "MeetingId", s => s
                .WithColumn("MeetingName").AsString(100).NotNullable()
                .WithColumn("MeetingNumber").AsString(20).Nullable()
                .WithColumn("MeetingGuid").AsGuid().NotNullable()
                .WithColumn("MeetingTypeId").AsInt64().NotNullable()
                    .ForeignKey("FK_Meeting_TypeId", "MeetingTypes", "MeetingTypeId")
                .WithColumn("StartDate").AsDateTime().NotNullable()
                .WithColumn("EndDate").AsDateTime().NotNullable()
                .WithColumn("LocationId").AsInt64().Nullable()
                    .ForeignKey("FK_Meeting_LocationId", "MeetingLocation", "LocationId")
                //.WithColumn("UnitId").AsInt64().Nullable()
                //    .ForeignKey("FK_Meeting_UnitId", "BusinessUnits", "UnitId")
                .WithColumn("OrganizerContactId").AsInt64().Nullable()
                    .ForeignKey("FK_Meeting_Organizer", "Contact", "ContactId")
                .WithColumn("ReporterContactId").AsInt64().Nullable()
                    .ForeignKey("FK_Meeting_Reporter", "Contact", "ContactId")
                .WithColumn("InsertUserId").AsInt64().NotNullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("UpdateUserId").AsInt64().Nullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable(),
                schema: SCHEMA);

            this.CreateTableWithId64("MeetingAgendaType", "AgendaTypeId", s => s
                .WithColumn("Name").AsString(100).NotNullable(),
                schema: SCHEMA);

            this.CreateTableWithId64("MeetingAgenda", "AgendaId", s => s
                .WithColumn("MeetingId").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetAgenda_MeetingId", "Meeting", "MeetingId")
                .WithColumn("AgendaNumber").AsInt64().NotNullable()
                .WithColumn("Title").AsString(2000).Nullable()
                .WithColumn("Description").AsString(int.MaxValue).Nullable()
                .WithColumn("AgendaTypeId").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetAgenda_AgendaTypeId", "MeetingAgendaType", "AgendaTypeId")
                .WithColumn("RequestedByContactId").AsInt64().Nullable()
                    .ForeignKey("FK_MeetAgenda_RequestedBy", "Contact", "ContactId")
                .WithColumn("Images").AsString(int.MaxValue).Nullable()
                .WithColumn("Attachments").AsString(int.MaxValue).Nullable(),
                schema: SCHEMA);

            this.CreateTableWithId64("MeetingAgendaRelevant", "AgendaRelevantId", s => s
                .WithColumn("AgendaId").AsInt64().NotNullable()
                    .ForeignKey("FK_AgendaRel_AgendaId", "MeetingAgenda", "AgendaId")
                .WithColumn("ContactId").AsInt64().NotNullable()
                    .ForeignKey("FK_AgendaRel_ContactId", "Contact", "ContactId"));

            this.CreateTableWithId64("MeetingAttendee", "AttendeeId", s => s
                .WithColumn("MeetingId").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetAttendee_MeetingId", "Meeting", "MeetingId")
                .WithColumn("ContactId").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetAttendee_ContactId", "Contact", "ContactId")
                .WithColumn("AttendeeType").AsInt64().NotNullable()
                .WithColumn("AttendanceStatus").AsInt64().NotNullable(),
                schema: SCHEMA);

            this.CreateTableWithId64("MeetingDecision", "DecisionId", s => s
                .WithColumn("MeetingId").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetDecision_MeetingId", "Meeting", "MeetingId")
                .WithColumn("AgendaId").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetDecision_AgendaId", "MeetingAgenda", "AgendaId")
                .WithColumn("Description").AsString(int.MaxValue).Nullable()
                .WithColumn("DecisionNumber").AsInt64().NotNullable()
                    .ForeignKey("FK_MeetDecision_AgendaType", "MeetingAgendaType", "AgendaTypeId")
                .WithColumn("ResponsibleContactId").AsInt64().Nullable()
                    .ForeignKey("FK_MeetDecision_RequestedBy", "Contact", "ContactId")
                .WithColumn("DueDate").AsDateTime().Nullable()
                .WithColumn("ResolutionStatus").AsInt64().NotNullable()
                .WithColumn("Images").AsString(int.MaxValue).Nullable()
                .WithColumn("Attachments").AsString(int.MaxValue).Nullable(),
                schema: SCHEMA);

            this.CreateTableWithId64("MeetingDecisionRelevant", "DecisionRelevantId", s => s
                .WithColumn("DecisionId").AsInt64().NotNullable()
                    .ForeignKey("FK_DecisionRel_DecisionId", "MeetingDecision", "DecisionId")
                .WithColumn("ContactId").AsInt64().NotNullable()
                    .ForeignKey("FK_DecisionRel_ContactId", "Contact", "ContactId"),
                schema: SCHEMA);
        }
    }
}