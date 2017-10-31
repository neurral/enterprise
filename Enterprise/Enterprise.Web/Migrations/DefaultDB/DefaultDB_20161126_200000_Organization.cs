using FluentMigrator;
using static Enterprise.Constants.PersonnelStatus;

namespace Enterprise.Migrations.DefaultDB
{
    [Migration(20161126200000)]
    public class DefaultDB_20161126_200000_Organization : AutoReversingMigration
    {
        private const string SCHEMA = Constants.Enterprise_SCHEMA;
        public override void Up()
        {
            Create.Schema(SCHEMA);

            this.CreateTableWithId32("BusinessUnits", "UnitId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("ParentUnitId").AsInt32().Nullable()
                    .ForeignKey("FK_BusinessUnits_ParentUnit", SCHEMA, "BusinessUnits", "UnitId"),                    
                    schema: SCHEMA,
                    checkExists: true);

            Insert.IntoTable("BusinessUnits").InSchema(SCHEMA)
               .Row(new { Name = "Administration" })
               .Row(new { Name = "Management" })
               .Row(new { Name = "Human Resources", ParentUnitId = 2 })
               .Row(new { Name = "Finance", ParentUnitId = 2 });
            

            this.CreateTableWithId32("PersonnelStatus", "PersonnelStatusId", s => s
                .WithColumn("Sequence").AsInt32().NotNullable()
                .WithColumn("PersonnelStatusName").AsString(100).NotNullable(), 
                schema: SCHEMA);

            Insert.IntoTable("PersonnelStatus").InSchema(SCHEMA)
                .Row(new { Sequence = 0, PersonnelStatusName = INACTIVE}) //initial status
                .Row(new { Sequence = 1, PersonnelStatusName = ACTIVATED }) //usable account, included in transactions
                .Row(new { Sequence = 2, PersonnelStatusName = SUSPENDED }) //unusable, included in transactions
                .Row(new { Sequence = 3, PersonnelStatusName = TERMINATED }); //ignored in transactions except history

            this.CreateTableWithId32("Personnel", "PersonnelId", s => s
                .WithColumn("IdentificationNo").AsString(20).Nullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("MiddleName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Email").AsString(100).NotNullable()
                .WithColumn("PersonnelStatus").AsInt32().WithDefaultValue(0)
                    .ForeignKey("FK_Personnel_StatusId", SCHEMA, "PersonnelStatus", "PersonnelStatusId")
                .WithColumn("Gender").AsString(3)
                .WithColumn("DateStarted").AsDate()
                .WithColumn("DateExited").AsDate()
                .WithColumn("DateOfBirth").AsDate()
                .WithColumn("UserId").AsInt32().Nullable()
                    .ForeignKey("FK_Personnel_UserId", "Users", "UserId"),
                    schema: SCHEMA, 
                    checkExists: true);
        }
    }
}