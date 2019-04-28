using FluentMigrator;
using System;

namespace Enterprise.Migrations.DefaultDB
{

    [Migration(20141103140000)]
    public class DefaultDB_20141103_140000_Initial : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId64("User", "UserId", s => s
                .WithColumn("Username").AsString(100).NotNullable()
                //.WithColumn("DisplayName").AsString(100).NotNullable()
                .WithColumn("Email").AsString(100).Nullable()
                .WithColumn("Source").AsString(4).NotNullable()
                .WithColumn("PasswordHash").AsString(86).NotNullable()
                .WithColumn("PasswordSalt").AsString(10).NotNullable()
                .WithColumn("LastDirectoryUpdate").AsDateTime().Nullable()
                .WithColumn("UserImage").AsString(100).Nullable()
                .WithColumn("InsertDate").AsDateTime().NotNullable()
                .WithColumn("InsertUserId").AsInt64().NotNullable()
                .WithColumn("UpdateDate").AsDateTime().Nullable()
                .WithColumn("UpdateUserId").AsInt64().Nullable()
                .WithColumn("IsActive").AsInt16().NotNullable().WithDefaultValue(1));

            Insert.IntoTable("User").Row(new {
                Username = "admin",
                //DisplayName/PW = "admin/sysadmin",
                Email = "neurralsystems@gmail.com",
                Source = "site",
                PasswordHash = "R9//EDq9NNSogDpOcwowEmzmOOQmckYSn6PqiyNBWTAvFB73YofQq5W8nsssol/n+8TmF9Bl0Irsw9FlZk0BrA",
                PasswordSalt = "NdR&*",
                InsertDate = new DateTime(2014, 1, 1),
                InsertUserId = 1,
                IsActive = 1
            });

            this.CreateTableWithId64("Language", "Id", s => s
                .WithColumn("LanguageId").AsString(10).NotNullable()
                .WithColumn("LanguageName").AsString(50).NotNullable());

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "en",
                LanguageName = "English"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "ru",
                LanguageName = "Russian"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "es",
                LanguageName = "Spanish"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "tr",
                LanguageName = "Turkish"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "de",
                LanguageName = "German"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "zh-CN",
                LanguageName = "Chinese (Simplified)"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "it",
                LanguageName = "Italian"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "pt",
                LanguageName = "Portuguese"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "pt-BR",
                LanguageName = "Portuguese (Brazil)"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "fa",
                LanguageName = "Farsi"
            });

            Insert.IntoTable("Language").Row(new
            {
                LanguageId = "vi-VN",
                LanguageName = "Vietnamese (Vietnam)"
            });
        }
    }
}