using FluentMigrator;
using static Enterprise.Constants.PersonnelStatus;

namespace Enterprise.Migrations.DefaultDB
{
    [Migration(20161126200000)]
    public class EnterpriseDB_20161126_200000_Organization : AutoReversingMigration
    {
        private const string SCHEMA = Constants.Enterprise_SCHEMA;
        public override void Up()
        {
            Create.Schema(SCHEMA);

            this.CreateTableWithId64("BusinessUnit", "UnitId", s => s
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("ParentUnitId").AsInt64().Nullable()
                    .ForeignKey("FK_BusinessUnit_ParentUnit", SCHEMA, "BusinessUnit", "UnitId"),                    
                    schema: SCHEMA,
                    checkExists: true);

            Insert.IntoTable("BusinessUnit").InSchema(SCHEMA)
               .Row(new { Name = "Administration" })
               .Row(new { Name = "Management" })
               .Row(new { Name = "Human Resources", ParentUnitId = 2 })
               .Row(new { Name = "Finance", ParentUnitId = 2 });
            

            this.CreateTableWithId64("PersonnelStatus", "PersonnelStatusId", s => s
                .WithColumn("Sequence").AsInt64().NotNullable()
                .WithColumn("PersonnelStatusName").AsString(100).NotNullable(), 
                schema: SCHEMA);

            Insert.IntoTable("PersonnelStatus").InSchema(SCHEMA)
                .Row(new { Sequence = 0, PersonnelStatusName = UNVERIFIED }) 
                .Row(new { Sequence = 1, PersonnelStatusName = INACTIVE}) 
                .Row(new { Sequence = 2, PersonnelStatusName = ACTIVATED }) 
                .Row(new { Sequence = 3, PersonnelStatusName = SUSPENDED }) 
                .Row(new { Sequence = 4, PersonnelStatusName = TERMINATED }); 

            this.CreateTableWithId64("Personnel", "PersonnelId", s => s
                .WithColumn("IdentificationNo").AsString(20).Nullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("MiddleName").AsString(50).Nullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Email").AsString(100).Nullable()
                .WithColumn("ContactNumber").AsString(20).Nullable()
                .WithColumn("PersonnelStatus").AsInt64().WithDefaultValue(0)
                    .ForeignKey("FK_Personnel_StatusId", SCHEMA, "PersonnelStatus", "PersonnelStatusId")
                .WithColumn("Gender").AsString(3)
                .WithColumn("DateStarted").AsDate().Nullable()
                .WithColumn("DateExited").AsDate().Nullable()
                .WithColumn("DateOfBirth").AsDate().NotNullable()
                .WithColumn("UserId").AsInt64().Nullable()
                    .ForeignKey("FK_Personnel_UserId", "User", "UserId"),
                //.WithColumn("OrganizationId").AsInt64().Nullable()
                //   .ForeignKey("FK_Personnel_OrganizationId", "Organization", "OrganizationId"),
                    schema: SCHEMA, 
                    checkExists: true);
        }
    }
}