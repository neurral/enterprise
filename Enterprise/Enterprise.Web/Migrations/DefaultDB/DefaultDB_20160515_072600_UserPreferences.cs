using FluentMigrator;

namespace Enterprise.Migrations.DefaultDB
{
    [Migration(20160515072600)]
    public class DefaultDB_20160515_072600_UserPreference : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("UserPreference", "UserPreferenceId", s => s
                .WithColumn("UserId").AsInt64().NotNullable()
                .WithColumn("PreferenceType").AsString(100).NotNullable()
                .WithColumn("Name").AsString(200).NotNullable()
                .WithColumn("Value").AsString(int.MaxValue).Nullable());

            Create.Index("IX_UserPref_UID_PrefType_Name")
                .OnTable("UserPreference")
                .OnColumn("UserId").Ascending()
                .OnColumn("PreferenceType").Ascending()
                .OnColumn("Name").Ascending()
                .WithOptions().Unique();
        }
    }
}