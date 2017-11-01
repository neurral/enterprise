
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
    [DisplayName("Personnel"), InstanceName("Personnel"), TwoLevelCached]
    [ReadPermission(Keys.Personnel.Access)]
    [ModifyPermission(Keys.Personnel.Modify)]
    [LookupScript(Ks.Module + "." + Ks.Personnel, Permission = Keys.General)]
    public sealed class PersonnelRow : Row, IIdRow, INameRow
    {
        public const string TableName = Constants.SCHEMA + Ks.Personnel;

        [DisplayName("Personnel Id"), Identity]
        public Int64? PersonnelId
        {
            get { return Fields.PersonnelId[this]; }
            set { Fields.PersonnelId[this] = value; }
        }

        [DisplayName("Company ID"), Size(20), QuickSearch]
        public String IdentificationNo
        {
            get { return Fields.IdentificationNo[this]; }
            set { Fields.IdentificationNo[this] = value; }
        }

        [DisplayName("First Name"), Size(50), NotNull]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Middle Name"), Size(50)]
        public String MiddleName
        {
            get { return Fields.MiddleName[this]; }
            set { Fields.MiddleName[this] = value; }
        }

        [DisplayName("Last Name"), Size(50), NotNull]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("Email"), Size(100), NotNull]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Personnel Status"), NotNull, 
            DefaultValue(0),
            ForeignKey(PersonnelStatusRow.TableName, "PersonnelStatusId"), LeftJoin("jPersonnelStatus"), TextualField("PersonnelStatusPersonnelStatusName")]
        [LookupEditor(typeof(Entities.PersonnelStatusRow), InplaceAddPermission = Keys.Personnel.Modify)]
        [ModifyPermission(Keys.Personnel.Modify)]
        public Int64? PersonnelStatus
        {
            get { return Fields.PersonnelStatus[this]; }
            set { Fields.PersonnelStatus[this] = value; }
        }

        [DisplayName("Gender"), Size(3), NotNull]
        public String Gender
        {
            get { return Fields.Gender[this]; }
            set { Fields.Gender[this] = value; }
        }

        [DisplayName("Date Started"), NotNull]
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? DateStarted
        {
            get { return Fields.DateStarted[this]; }
            set { Fields.DateStarted[this] = value; }
        }

        [DisplayName("Date Exited")]
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? DateExited
        {
            get { return Fields.DateExited[this]; }
            set { Fields.DateExited[this] = value; }
        }

        [DisplayName("Date Of Birth"), NotNull]
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? DateOfBirth
        {
            get { return Fields.DateOfBirth[this]; }
            set { Fields.DateOfBirth[this] = value; }
        }

        [DisplayName("User"), ForeignKey("User", "UserId"), LeftJoin("jUser"), TextualField("UserUsername")]
        [LookupEditor(typeof(Administration.Entities.UserRow), InplaceAdd =true, 
            InplaceAddPermission = Keys.Personnel.Modify)]
        [ModifyPermission(Keys.Personnel.Modify)]
        public Int64? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("Personnel Status Sequence"), Expression("jPersonnelStatus.[Sequence]")]
        public Int64? PersonnelStatusSequence
        {
            get { return Fields.PersonnelStatusSequence[this]; }
            set { Fields.PersonnelStatusSequence[this] = value; }
        }
        [DisplayName("Personnel Status Personnel Status Name"), Expression("jPersonnelStatus.[PersonnelStatusName]")]
        public String PersonnelStatusPersonnelStatusName
        {
            get { return Fields.PersonnelStatusPersonnelStatusName[this]; }
            set { Fields.PersonnelStatusPersonnelStatusName[this] = value; }
        }
        [DisplayName("User Username"), Expression("jUser.[Username]")]
        public String UserUsername
        {
            get { return Fields.UserUsername[this]; }
            set { Fields.UserUsername[this] = value; }
        }
        
        [DisplayName("User Email"), Expression("jUser.[Email]")]
        public String UserEmail
        {
            get { return Fields.UserEmail[this]; }
            set { Fields.UserEmail[this] = value; }
        }
        [DisplayName("User Source"), Expression("jUser.[Source]")]
        public String UserSource
        {
            get { return Fields.UserSource[this]; }
            set { Fields.UserSource[this] = value; }
        }
        [DisplayName("User Password Hash"), Expression("jUser.[PasswordHash]")]
        public String UserPasswordHash
        {
            get { return Fields.UserPasswordHash[this]; }
            set { Fields.UserPasswordHash[this] = value; }
        }
        [DisplayName("User Password Salt"), Expression("jUser.[PasswordSalt]")]
        public String UserPasswordSalt
        {
            get { return Fields.UserPasswordSalt[this]; }
            set { Fields.UserPasswordSalt[this] = value; }
        }
        [DisplayName("User Last Directory Update"), Expression("jUser.[LastDirectoryUpdate]")]
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? UserLastDirectoryUpdate
        {
            get { return Fields.UserLastDirectoryUpdate[this]; }
            set { Fields.UserLastDirectoryUpdate[this] = value; }
        }
        [DisplayName("User User Image"), Expression("jUser.[UserImage]")]
        public String UserUserImage
        {
            get { return Fields.UserUserImage[this]; }
            set { Fields.UserUserImage[this] = value; }
        }
        [DisplayName("User Insert Date"), Expression("jUser.[InsertDate]")]
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? UserInsertDate
        {
            get { return Fields.UserInsertDate[this]; }
            set { Fields.UserInsertDate[this] = value; }
        }
        [DisplayName("User Insert User Id"), Expression("jUser.[InsertUserId]")]
        public Int64? UserInsertUserId
        {
            get { return Fields.UserInsertUserId[this]; }
            set { Fields.UserInsertUserId[this] = value; }
        }
        [DisplayName("User Update Date"), Expression("jUser.[UpdateDate]")]
        [DateTimeKind(DateTimeKind.Utc)]
        public DateTime? UserUpdateDate
        {
            get { return Fields.UserUpdateDate[this]; }
            set { Fields.UserUpdateDate[this] = value; }
        }
        [DisplayName("User Update User Id"), Expression("jUser.[UpdateUserId]")]
        public Int64? UserUpdateUserId
        {
            get { return Fields.UserUpdateUserId[this]; }
            set { Fields.UserUpdateUserId[this] = value; }
        }
        [DisplayName("User Is Verified"), Expression("jUser.[IsActive]")]
        public Int16? UserIsActive
        {
            get { return Fields.UserIsActive[this]; }
            set { Fields.UserIsActive[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.PersonnelId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.IdentificationNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PersonnelRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field PersonnelId;
            public StringField IdentificationNo;
            public StringField FirstName;
            public StringField MiddleName;
            public StringField LastName;
            public StringField Email;
            public Int64Field PersonnelStatus;
            public StringField Gender;
            public DateTimeField DateStarted;
            public DateTimeField DateExited;
            public DateTimeField DateOfBirth;
            public Int64Field UserId;

            public Int64Field PersonnelStatusSequence;
            public StringField PersonnelStatusPersonnelStatusName;

            public StringField UserUsername;
            public StringField UserEmail;
            public StringField UserSource;
            public StringField UserPasswordHash;
            public StringField UserPasswordSalt;
            public DateTimeField UserLastDirectoryUpdate;
            public StringField UserUserImage;
            public DateTimeField UserInsertDate;
            public Int64Field UserInsertUserId;
            public DateTimeField UserUpdateDate;
            public Int64Field UserUpdateUserId;
            public Int16Field UserIsActive;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Organization.Personnel";
            }
        }
    }
}
