using FluentMigrator;

namespace Enterprise.Migrations.DefaultDB
{
    [Migration(20141111113000)]
    public class DefaultDB_20141111_113000_Permissions : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("UserPermission", "UserPermissionId", s => s
                .WithColumn("UserId").AsInt64().NotNullable()
                    .ForeignKey("FK_UserPermission_UserId", "User", "UserId")
                .WithColumn("PermissionKey").AsString(100).NotNullable()
                .WithColumn("Granted").AsBoolean().NotNullable().WithDefaultValue(true));

            Create.Index("UQ_UserPerm_UserId_PermKey")
                .OnTable("UserPermission")
                .OnColumn("UserId").Ascending()
                .OnColumn("PermissionKey").Ascending()
                .WithOptions().Unique();

            this.CreateTableWithId64("Role", "RoleId", s => s
                .WithColumn("RoleName").AsString(100).NotNullable());

            this.CreateTableWithId64("RolePermission", "RolePermissionId", s => s
                .WithColumn("RoleId").AsInt64().NotNullable()
                    .ForeignKey("FK_RolePermission_RoleId", "Role", "RoleId")
                .WithColumn("PermissionKey").AsString(100).NotNullable());

            Create.Index("UQ_RolePerm_RoleId_PermKey")
                .OnTable("RolePermission")
                .OnColumn("RoleId").Ascending()
                .OnColumn("PermissionKey").Ascending()
                .WithOptions().Unique();

            this.CreateTableWithId64("UserRole", "UserRoleId", s => s
                .WithColumn("UserId").AsInt64().NotNullable()
                    .ForeignKey("FK_UserRole_UserId", "User", "UserId")
                .WithColumn("RoleId").AsInt64().NotNullable()
                    .ForeignKey("FK_UserRole_RoleId", "Role", "RoleId"));

            Create.Index("UQ_UserRole_UserId_RoleId")
                .OnTable("UserRole")
                .OnColumn("UserId").Ascending()
                .OnColumn("RoleId").Ascending()
                .WithOptions().Unique();

            Create.Index("IX_UserRole_RoleId_UserId")
                .OnTable("UserRole")
                .OnColumn("RoleId").Ascending()
                .OnColumn("UserId").Ascending();


            Insert.IntoTable("Role")
              .Row(new { RoleName = "_Administrator" })
              .Row(new { RoleName = "Bot" })
              .Row(new { RoleName = "Account" })
              .Row(new { RoleName = "Sub-Account" });
              
        }
    }
}