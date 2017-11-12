
namespace Enterprise.Organization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName(TableName)]
    [DisplayName("Calendar Holiday"), InstanceName("Calendar Holiday"), TwoLevelCached]
    [ReadPermission(Keys.General)]
    [ModifyPermission(Keys.Libraries.Modify)]
    [LookupScript(Ks.Module + "." + Ks.CalendarHoliday, Permission = Keys.General)]
    public sealed class CalendarHolidayRow : Row, IIdRow, INameRow
    {
        public const string TableName = Constants.SCHEMA + Ks.CalendarHoliday;

        [DisplayName("Calendar Holiday Id"), Identity]
        public Int64? CalendarHolidayId
        {
            get { return Fields.CalendarHolidayId[this]; }
            set { Fields.CalendarHolidayId[this] = value; }
        }

        [DisplayName("Date"), NotNull]
        public DateTime? Date
        {
            get { return Fields.Date[this]; }
            set { Fields.Date[this] = value; }
        }

        [DisplayName("Time Start")]
        public TimeSpan? TimeStart
        {
            get { return Fields.TimeStart[this]; }
            set { Fields.TimeStart[this] = value; }
        }

        [DisplayName("Description"), Size(100), NotNull, QuickSearch]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Non Workday"), NotNull]
        public Boolean? NonWorkday
        {
            get { return Fields.NonWorkday[this]; }
            set { Fields.NonWorkday[this] = value; }
        }

        [DisplayName("Insert Date")]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Insert User"), ForeignKey("[dbo].[User]", "UserId"), LeftJoin("jInsertUser"), TextualField("InsertUserUsername")]
        public Int64? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Insert User Username"), Expression("jInsertUser.[Username]")]
        public String InsertUserUsername
        {
            get { return Fields.InsertUserUsername[this]; }
            set { Fields.InsertUserUsername[this] = value; }
        }
        [DisplayName("Insert User Email"), Expression("jInsertUser.[Email]")]
        public String InsertUserEmail
        {
            get { return Fields.InsertUserEmail[this]; }
            set { Fields.InsertUserEmail[this] = value; }
        }
        [DisplayName("Insert User Source"), Expression("jInsertUser.[Source]")]
        public String InsertUserSource
        {
            get { return Fields.InsertUserSource[this]; }
            set { Fields.InsertUserSource[this] = value; }
        }
        [DisplayName("Insert User Password Hash"), Expression("jInsertUser.[PasswordHash]")]
        public String InsertUserPasswordHash
        {
            get { return Fields.InsertUserPasswordHash[this]; }
            set { Fields.InsertUserPasswordHash[this] = value; }
        }
        [DisplayName("Insert User Password Salt"), Expression("jInsertUser.[PasswordSalt]")]
        public String InsertUserPasswordSalt
        {
            get { return Fields.InsertUserPasswordSalt[this]; }
            set { Fields.InsertUserPasswordSalt[this] = value; }
        }
        [DisplayName("Insert User Last Directory Update"), Expression("jInsertUser.[LastDirectoryUpdate]")]
        public DateTime? InsertUserLastDirectoryUpdate
        {
            get { return Fields.InsertUserLastDirectoryUpdate[this]; }
            set { Fields.InsertUserLastDirectoryUpdate[this] = value; }
        }
        [DisplayName("Insert User User Image"), Expression("jInsertUser.[UserImage]")]
        public String InsertUserUserImage
        {
            get { return Fields.InsertUserUserImage[this]; }
            set { Fields.InsertUserUserImage[this] = value; }
        }
        [DisplayName("Insert User Insert Date"), Expression("jInsertUser.[InsertDate]")]
        public DateTime? InsertUserInsertDate
        {
            get { return Fields.InsertUserInsertDate[this]; }
            set { Fields.InsertUserInsertDate[this] = value; }
        }
        [DisplayName("Insert User Insert User Id"), Expression("jInsertUser.[InsertUserId]")]
        public Int64? InsertUserInsertUserId
        {
            get { return Fields.InsertUserInsertUserId[this]; }
            set { Fields.InsertUserInsertUserId[this] = value; }
        }
        [DisplayName("Insert User Update Date"), Expression("jInsertUser.[UpdateDate]")]
        public DateTime? InsertUserUpdateDate
        {
            get { return Fields.InsertUserUpdateDate[this]; }
            set { Fields.InsertUserUpdateDate[this] = value; }
        }
        [DisplayName("Insert User Update User Id"), Expression("jInsertUser.[UpdateUserId]")]
        public Int64? InsertUserUpdateUserId
        {
            get { return Fields.InsertUserUpdateUserId[this]; }
            set { Fields.InsertUserUpdateUserId[this] = value; }
        }
        [DisplayName("Insert User Is Active"), Expression("jInsertUser.[IsActive]")]
        public Int16? InsertUserIsActive
        {
            get { return Fields.InsertUserIsActive[this]; }
            set { Fields.InsertUserIsActive[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.CalendarHolidayId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CalendarHolidayRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field CalendarHolidayId;
            public DateTimeField Date;
            public TimeSpanField TimeStart;
            public StringField Description;
            public BooleanField NonWorkday;
            public DateTimeField InsertDate;
            public Int64Field InsertUserId;

            public StringField InsertUserUsername;
            public StringField InsertUserEmail;
            public StringField InsertUserSource;
            public StringField InsertUserPasswordHash;
            public StringField InsertUserPasswordSalt;
            public DateTimeField InsertUserLastDirectoryUpdate;
            public StringField InsertUserUserImage;
            public DateTimeField InsertUserInsertDate;
            public Int64Field InsertUserInsertUserId;
            public DateTimeField InsertUserUpdateDate;
            public Int64Field InsertUserUpdateUserId;
            public Int16Field InsertUserIsActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Organization.CalendarHoliday";
            }
        }
    }
}
