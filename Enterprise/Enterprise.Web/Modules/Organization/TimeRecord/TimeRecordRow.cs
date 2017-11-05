
namespace Enterprise.Organization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[ent].[TimeRecord]")]
    [DisplayName("Time Record"), InstanceName("Time Record"), TwoLevelCached]
    [ReadPermission("Organization:General")]
    [ModifyPermission("Organization:General")]
    public sealed class TimeRecordRow : Row, IIdRow, INameRow
    {
        [DisplayName("Time Record Id"), Identity]
        public Int64? TimeRecordId
        {
            get { return Fields.TimeRecordId[this]; }
            set { Fields.TimeRecordId[this] = value; }
        }

        [DisplayName("Personnel"), NotNull, ForeignKey("[ent].[Personnel]", "PersonnelId"), LeftJoin("jPersonnel"), TextualField("PersonnelIdentificationNo")]
        public Int64? PersonnelId
        {
            get { return Fields.PersonnelId[this]; }
            set { Fields.PersonnelId[this] = value; }
        }

        [DisplayName("Work Date"), NotNull]
        public DateTime? WorkDate
        {
            get { return Fields.WorkDate[this]; }
            set { Fields.WorkDate[this] = value; }
        }

        [DisplayName("Time Start"), NotNull]
        public TimeSpan? TimeStart
        {
            get { return Fields.TimeStart[this]; }
            set { Fields.TimeStart[this] = value; }
        }

        [DisplayName("Time End")]
        public TimeSpan? TimeEnd
        {
            get { return Fields.TimeEnd[this]; }
            set { Fields.TimeEnd[this] = value; }
        }

        [DisplayName("Remarks"), Size(100), NotNull, QuickSearch]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Status"), Size(20), NotNull]
        public String Status
        {
            get { return Fields.Status[this]; }
            set { Fields.Status[this] = value; }
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

        [DisplayName("Personnel Identification No"), Expression("jPersonnel.[IdentificationNo]")]
        public String PersonnelIdentificationNo
        {
            get { return Fields.PersonnelIdentificationNo[this]; }
            set { Fields.PersonnelIdentificationNo[this] = value; }
        }
        [DisplayName("Personnel First Name"), Expression("jPersonnel.[FirstName]")]
        public String PersonnelFirstName
        {
            get { return Fields.PersonnelFirstName[this]; }
            set { Fields.PersonnelFirstName[this] = value; }
        }
        [DisplayName("Personnel Middle Name"), Expression("jPersonnel.[MiddleName]")]
        public String PersonnelMiddleName
        {
            get { return Fields.PersonnelMiddleName[this]; }
            set { Fields.PersonnelMiddleName[this] = value; }
        }
        [DisplayName("Personnel Last Name"), Expression("jPersonnel.[LastName]")]
        public String PersonnelLastName
        {
            get { return Fields.PersonnelLastName[this]; }
            set { Fields.PersonnelLastName[this] = value; }
        }
        [DisplayName("Personnel Email"), Expression("jPersonnel.[Email]")]
        public String PersonnelEmail
        {
            get { return Fields.PersonnelEmail[this]; }
            set { Fields.PersonnelEmail[this] = value; }
        }
        [DisplayName("Personnel Contact Number"), Expression("jPersonnel.[ContactNumber]")]
        public String PersonnelContactNumber
        {
            get { return Fields.PersonnelContactNumber[this]; }
            set { Fields.PersonnelContactNumber[this] = value; }
        }
        [DisplayName("Personnel Personnel Status"), Expression("jPersonnel.[PersonnelStatus]")]
        public Int64? PersonnelPersonnelStatus
        {
            get { return Fields.PersonnelPersonnelStatus[this]; }
            set { Fields.PersonnelPersonnelStatus[this] = value; }
        }
        [DisplayName("Personnel Gender"), Expression("jPersonnel.[Gender]")]
        public String PersonnelGender
        {
            get { return Fields.PersonnelGender[this]; }
            set { Fields.PersonnelGender[this] = value; }
        }
        [DisplayName("Personnel Date Started"), Expression("jPersonnel.[DateStarted]")]
        public DateTime? PersonnelDateStarted
        {
            get { return Fields.PersonnelDateStarted[this]; }
            set { Fields.PersonnelDateStarted[this] = value; }
        }
        [DisplayName("Personnel Date Exited"), Expression("jPersonnel.[DateExited]")]
        public DateTime? PersonnelDateExited
        {
            get { return Fields.PersonnelDateExited[this]; }
            set { Fields.PersonnelDateExited[this] = value; }
        }
        [DisplayName("Personnel Date Of Birth"), Expression("jPersonnel.[DateOfBirth]")]
        public DateTime? PersonnelDateOfBirth
        {
            get { return Fields.PersonnelDateOfBirth[this]; }
            set { Fields.PersonnelDateOfBirth[this] = value; }
        }
        [DisplayName("Personnel User Id"), Expression("jPersonnel.[UserId]")]
        public Int64? PersonnelUserId
        {
            get { return Fields.PersonnelUserId[this]; }
            set { Fields.PersonnelUserId[this] = value; }
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
            get { return Fields.TimeRecordId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Remarks; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TimeRecordRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field TimeRecordId;
            public Int64Field PersonnelId;
            public DateTimeField WorkDate;
            public TimeSpanField TimeStart;
            public TimeSpanField TimeEnd;
            public StringField Remarks;
            public StringField Status;
            public DateTimeField InsertDate;
            public Int64Field InsertUserId;

            public StringField PersonnelIdentificationNo;
            public StringField PersonnelFirstName;
            public StringField PersonnelMiddleName;
            public StringField PersonnelLastName;
            public StringField PersonnelEmail;
            public StringField PersonnelContactNumber;
            public Int64Field PersonnelPersonnelStatus;
            public StringField PersonnelGender;
            public DateTimeField PersonnelDateStarted;
            public DateTimeField PersonnelDateExited;
            public DateTimeField PersonnelDateOfBirth;
            public Int64Field PersonnelUserId;

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
                LocalTextPrefix = "Organization.TimeRecord";
            }
        }
    }
}
