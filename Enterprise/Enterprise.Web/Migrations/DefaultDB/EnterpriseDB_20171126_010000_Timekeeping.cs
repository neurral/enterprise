using FluentMigrator;
using static Enterprise.Constants;

namespace Enterprise.Migrations.DefaultDB
{
    [Migration(20171126010000)]
    public class EnterpriseDB_20171126_010000_Timekeeping : AutoReversingMigration
    {
        private const string SCHEMA = Constants.Enterprise_SCHEMA;
        public override void Up()
        {
            this.CreateTableWithId64("CalendarHoliday", "CalendarHolidayId", s => s
               .WithColumn("Date").AsDate().NotNullable()
               .WithColumn("TimeStart").AsTime().Nullable()
               .WithColumn("Description").AsString(100).NotNullable()
               .WithColumn("NonWorkday").AsBoolean()
               .WithDefaultValue(true)
               .WithColumn("InsertDate").AsDateTime().Nullable()
               .WithColumn("InsertUserId").AsInt64().Nullable()
                   .ForeignKey("FK_CalendarHoliday_InsertUserId", "User", "UserId"),
                   schema: SCHEMA, checkExists: true);


            this.CreateTableWithId64("TimeRecordType", "TimeRecordTypeId", s => s
                .WithColumn("Code").AsString(10).NotNullable()
                .WithColumn("TimeRecordTypeName").AsString(100).NotNullable(),
                   schema: SCHEMA, checkExists: true);

            Insert.IntoTable("TimeRecordType").InSchema(SCHEMA)
                .Row(new { Code = TimeRecordType.DTR, TimeRecordTypeName = "Daily Time Record" })
                .Row(new { Code = TimeRecordType.OT, TimeRecordTypeName = "Overtime" })
                .Row(new { Code = TimeRecordType.UT, TimeRecordTypeName = "Undertime" })
                .Row(new { Code = TimeRecordType.LATE, TimeRecordTypeName = "Late/Tardiness" })
                .Row(new { Code = TimeRecordType.SPECIAL, TimeRecordTypeName = "Special Cases" });

            this.CreateTableWithId64("TimeRecord", "TimeRecordId", s => s
                .WithColumn("PersonnelId").AsInt64().NotNullable()
                   .ForeignKey("FK_TimeRecord_PersonnelId", SCHEMA, "Personnel", "PersonnelId")
                .WithColumn("WorkDate").AsDate().NotNullable()
                .WithColumn("TimeStart").AsTime().NotNullable()
                .WithColumn("TimeEnd").AsTime().Nullable()
                .WithColumn("Remarks").AsString(100).NotNullable()
                .WithColumn("Status").AsString(20).NotNullable()
                .WithColumn("InsertDate").AsDateTime().Nullable()
                .WithColumn("InsertUserId").AsInt64().Nullable()
                   .ForeignKey("FK_TimeRecord_InsertUserId", "User", "UserId"),
                   schema: SCHEMA, checkExists: true);

            this.CreateTableWithId64("TimeRecordApproval", "ApprovalId", s => s
                //.WithColumn("ModuleCode").AsString(5),
                .WithColumn("TimeRecordId").AsInt64().NotNullable()
                   .ForeignKey("FK_TimeRecordApproval_TimeRecordId", SCHEMA, "TimeRecord", "TimeRecordId")
                .WithColumn("RequestorId").AsInt64().NotNullable()
                   .ForeignKey("FK_TimeRecordApproval_PersonnelId", SCHEMA, "Personnel", "PersonnelId")
                .WithColumn("ApprovalStatus").AsFixedLengthString(1).NotNullable()
                .WithColumn("RequestorLocked").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("ApproverLocked").AsBoolean().NotNullable().WithDefaultValue(false)
                .WithColumn("DateReviewed").AsDateTime().Nullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt64().Nullable()
                   .ForeignKey("FK_TimeRecordApproval_UpdateUserId", "User", "UserId")
                .WithColumn("InsertDate").AsDateTime().Nullable()
                .WithColumn("InsertUserId").AsInt64().Nullable()
                   .ForeignKey("FK_TimeRecordApproval_InsertUserId", "User", "UserId"),
                   schema: SCHEMA, checkExists: true);


        }
    }
}