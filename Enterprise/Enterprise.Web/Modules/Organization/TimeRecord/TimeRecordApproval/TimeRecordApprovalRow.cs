
namespace Enterprise.Organization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[ent].[TimeRecordApproval]")]
    [DisplayName("Time Record Approval"), InstanceName("Time Record Approval"), TwoLevelCached]
    [ReadPermission("Organization:General")]
    [ModifyPermission("Organization:General")]
    public sealed class TimeRecordApprovalRow : Row, IIdRow, INameRow
    {
        [DisplayName("Approval Id"), Identity]
        public Int64? ApprovalId
        {
            get { return Fields.ApprovalId[this]; }
            set { Fields.ApprovalId[this] = value; }
        }

        [DisplayName("Time Record"), NotNull, ForeignKey("[ent].[TimeRecord]", "TimeRecordId"), LeftJoin("jTimeRecord"), TextualField("TimeRecordRemarks")]
        public Int64? TimeRecordId
        {
            get { return Fields.TimeRecordId[this]; }
            set { Fields.TimeRecordId[this] = value; }
        }

        [DisplayName("Requestor"), NotNull, ForeignKey("[ent].[Personnel]", "PersonnelId"), LeftJoin("jRequestor"), TextualField("RequestorIdentificationNo")]
        public Int64? RequestorId
        {
            get { return Fields.RequestorId[this]; }
            set { Fields.RequestorId[this] = value; }
        }

        [DisplayName("Approval Status"), Size(1), NotNull, QuickSearch]
        public String ApprovalStatus
        {
            get { return Fields.ApprovalStatus[this]; }
            set { Fields.ApprovalStatus[this] = value; }
        }

        [DisplayName("Requestor Locked"), NotNull]
        public Boolean? RequestorLocked
        {
            get { return Fields.RequestorLocked[this]; }
            set { Fields.RequestorLocked[this] = value; }
        }

        [DisplayName("Approver Locked"), NotNull]
        public Boolean? ApproverLocked
        {
            get { return Fields.ApproverLocked[this]; }
            set { Fields.ApproverLocked[this] = value; }
        }

        [DisplayName("Date Reviewed")]
        public DateTime? DateReviewed
        {
            get { return Fields.DateReviewed[this]; }
            set { Fields.DateReviewed[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Update User"), ForeignKey("[dbo].[User]", "UserId"), LeftJoin("jUpdateUser"), TextualField("UpdateUserUsername")]
        public Int64? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
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

        [DisplayName("Time Record Personnel Id"), Expression("jTimeRecord.[PersonnelId]")]
        public Int64? TimeRecordPersonnelId
        {
            get { return Fields.TimeRecordPersonnelId[this]; }
            set { Fields.TimeRecordPersonnelId[this] = value; }
        }
        [DisplayName("Time Record Work Date"), Expression("jTimeRecord.[WorkDate]")]
        public DateTime? TimeRecordWorkDate
        {
            get { return Fields.TimeRecordWorkDate[this]; }
            set { Fields.TimeRecordWorkDate[this] = value; }
        }
        [DisplayName("Time Record Time Start"), Expression("jTimeRecord.[TimeStart]")]
        public TimeSpan? TimeRecordTimeStart
        {
            get { return Fields.TimeRecordTimeStart[this]; }
            set { Fields.TimeRecordTimeStart[this] = value; }
        }
        [DisplayName("Time Record Time End"), Expression("jTimeRecord.[TimeEnd]")]
        public TimeSpan? TimeRecordTimeEnd
        {
            get { return Fields.TimeRecordTimeEnd[this]; }
            set { Fields.TimeRecordTimeEnd[this] = value; }
        }
        [DisplayName("Time Record Remarks"), Expression("jTimeRecord.[Remarks]")]
        public String TimeRecordRemarks
        {
            get { return Fields.TimeRecordRemarks[this]; }
            set { Fields.TimeRecordRemarks[this] = value; }
        }
        [DisplayName("Time Record Status"), Expression("jTimeRecord.[Status]")]
        public String TimeRecordStatus
        {
            get { return Fields.TimeRecordStatus[this]; }
            set { Fields.TimeRecordStatus[this] = value; }
        }
        [DisplayName("Time Record Insert Date"), Expression("jTimeRecord.[InsertDate]")]
        public DateTime? TimeRecordInsertDate
        {
            get { return Fields.TimeRecordInsertDate[this]; }
            set { Fields.TimeRecordInsertDate[this] = value; }
        }
        [DisplayName("Time Record Insert User Id"), Expression("jTimeRecord.[InsertUserId]")]
        public Int64? TimeRecordInsertUserId
        {
            get { return Fields.TimeRecordInsertUserId[this]; }
            set { Fields.TimeRecordInsertUserId[this] = value; }
        }
        [DisplayName("Requestor Identification No"), Expression("jRequestor.[IdentificationNo]")]
        public String RequestorIdentificationNo
        {
            get { return Fields.RequestorIdentificationNo[this]; }
            set { Fields.RequestorIdentificationNo[this] = value; }
        }
        [DisplayName("Requestor First Name"), Expression("jRequestor.[FirstName]")]
        public String RequestorFirstName
        {
            get { return Fields.RequestorFirstName[this]; }
            set { Fields.RequestorFirstName[this] = value; }
        }
        [DisplayName("Requestor Middle Name"), Expression("jRequestor.[MiddleName]")]
        public String RequestorMiddleName
        {
            get { return Fields.RequestorMiddleName[this]; }
            set { Fields.RequestorMiddleName[this] = value; }
        }
        [DisplayName("Requestor Last Name"), Expression("jRequestor.[LastName]")]
        public String RequestorLastName
        {
            get { return Fields.RequestorLastName[this]; }
            set { Fields.RequestorLastName[this] = value; }
        }
        [DisplayName("Requestor Email"), Expression("jRequestor.[Email]")]
        public String RequestorEmail
        {
            get { return Fields.RequestorEmail[this]; }
            set { Fields.RequestorEmail[this] = value; }
        }
        [DisplayName("Requestor Contact Number"), Expression("jRequestor.[ContactNumber]")]
        public String RequestorContactNumber
        {
            get { return Fields.RequestorContactNumber[this]; }
            set { Fields.RequestorContactNumber[this] = value; }
        }
        [DisplayName("Requestor Personnel Status"), Expression("jRequestor.[PersonnelStatus]")]
        public Int64? RequestorPersonnelStatus
        {
            get { return Fields.RequestorPersonnelStatus[this]; }
            set { Fields.RequestorPersonnelStatus[this] = value; }
        }
        [DisplayName("Requestor Gender"), Expression("jRequestor.[Gender]")]
        public String RequestorGender
        {
            get { return Fields.RequestorGender[this]; }
            set { Fields.RequestorGender[this] = value; }
        }
        [DisplayName("Requestor Date Started"), Expression("jRequestor.[DateStarted]")]
        public DateTime? RequestorDateStarted
        {
            get { return Fields.RequestorDateStarted[this]; }
            set { Fields.RequestorDateStarted[this] = value; }
        }
        [DisplayName("Requestor Date Exited"), Expression("jRequestor.[DateExited]")]
        public DateTime? RequestorDateExited
        {
            get { return Fields.RequestorDateExited[this]; }
            set { Fields.RequestorDateExited[this] = value; }
        }
        [DisplayName("Requestor Date Of Birth"), Expression("jRequestor.[DateOfBirth]")]
        public DateTime? RequestorDateOfBirth
        {
            get { return Fields.RequestorDateOfBirth[this]; }
            set { Fields.RequestorDateOfBirth[this] = value; }
        }
        [DisplayName("Requestor User Id"), Expression("jRequestor.[UserId]")]
        public Int64? RequestorUserId
        {
            get { return Fields.RequestorUserId[this]; }
            set { Fields.RequestorUserId[this] = value; }
        }
        [DisplayName("Update User Username"), Expression("jUpdateUser.[Username]")]
        public String UpdateUserUsername
        {
            get { return Fields.UpdateUserUsername[this]; }
            set { Fields.UpdateUserUsername[this] = value; }
        }
        [DisplayName("Update User Email"), Expression("jUpdateUser.[Email]")]
        public String UpdateUserEmail
        {
            get { return Fields.UpdateUserEmail[this]; }
            set { Fields.UpdateUserEmail[this] = value; }
        }
        [DisplayName("Update User Source"), Expression("jUpdateUser.[Source]")]
        public String UpdateUserSource
        {
            get { return Fields.UpdateUserSource[this]; }
            set { Fields.UpdateUserSource[this] = value; }
        }
        [DisplayName("Update User Password Hash"), Expression("jUpdateUser.[PasswordHash]")]
        public String UpdateUserPasswordHash
        {
            get { return Fields.UpdateUserPasswordHash[this]; }
            set { Fields.UpdateUserPasswordHash[this] = value; }
        }
        [DisplayName("Update User Password Salt"), Expression("jUpdateUser.[PasswordSalt]")]
        public String UpdateUserPasswordSalt
        {
            get { return Fields.UpdateUserPasswordSalt[this]; }
            set { Fields.UpdateUserPasswordSalt[this] = value; }
        }
        [DisplayName("Update User Last Directory Update"), Expression("jUpdateUser.[LastDirectoryUpdate]")]
        public DateTime? UpdateUserLastDirectoryUpdate
        {
            get { return Fields.UpdateUserLastDirectoryUpdate[this]; }
            set { Fields.UpdateUserLastDirectoryUpdate[this] = value; }
        }
        [DisplayName("Update User User Image"), Expression("jUpdateUser.[UserImage]")]
        public String UpdateUserUserImage
        {
            get { return Fields.UpdateUserUserImage[this]; }
            set { Fields.UpdateUserUserImage[this] = value; }
        }
        [DisplayName("Update User Insert Date"), Expression("jUpdateUser.[InsertDate]")]
        public DateTime? UpdateUserInsertDate
        {
            get { return Fields.UpdateUserInsertDate[this]; }
            set { Fields.UpdateUserInsertDate[this] = value; }
        }
        [DisplayName("Update User Insert User Id"), Expression("jUpdateUser.[InsertUserId]")]
        public Int64? UpdateUserInsertUserId
        {
            get { return Fields.UpdateUserInsertUserId[this]; }
            set { Fields.UpdateUserInsertUserId[this] = value; }
        }
        [DisplayName("Update User Update Date"), Expression("jUpdateUser.[UpdateDate]")]
        public DateTime? UpdateUserUpdateDate
        {
            get { return Fields.UpdateUserUpdateDate[this]; }
            set { Fields.UpdateUserUpdateDate[this] = value; }
        }
        [DisplayName("Update User Update User Id"), Expression("jUpdateUser.[UpdateUserId]")]
        public Int64? UpdateUserUpdateUserId
        {
            get { return Fields.UpdateUserUpdateUserId[this]; }
            set { Fields.UpdateUserUpdateUserId[this] = value; }
        }
        [DisplayName("Update User Is Active"), Expression("jUpdateUser.[IsActive]")]
        public Int16? UpdateUserIsActive
        {
            get { return Fields.UpdateUserIsActive[this]; }
            set { Fields.UpdateUserIsActive[this] = value; }
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
            get { return Fields.ApprovalId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ApprovalStatus; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TimeRecordApprovalRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field ApprovalId;
            public Int64Field TimeRecordId;
            public Int64Field RequestorId;
            public StringField ApprovalStatus;
            public BooleanField RequestorLocked;
            public BooleanField ApproverLocked;
            public DateTimeField DateReviewed;
            public DateTimeField UpdateDate;
            public Int64Field UpdateUserId;
            public DateTimeField InsertDate;
            public Int64Field InsertUserId;

            public Int64Field TimeRecordPersonnelId;
            public DateTimeField TimeRecordWorkDate;
            public TimeSpanField TimeRecordTimeStart;
            public TimeSpanField TimeRecordTimeEnd;
            public StringField TimeRecordRemarks;
            public StringField TimeRecordStatus;
            public DateTimeField TimeRecordInsertDate;
            public Int64Field TimeRecordInsertUserId;

            public StringField RequestorIdentificationNo;
            public StringField RequestorFirstName;
            public StringField RequestorMiddleName;
            public StringField RequestorLastName;
            public StringField RequestorEmail;
            public StringField RequestorContactNumber;
            public Int64Field RequestorPersonnelStatus;
            public StringField RequestorGender;
            public DateTimeField RequestorDateStarted;
            public DateTimeField RequestorDateExited;
            public DateTimeField RequestorDateOfBirth;
            public Int64Field RequestorUserId;

            public StringField UpdateUserUsername;
            public StringField UpdateUserEmail;
            public StringField UpdateUserSource;
            public StringField UpdateUserPasswordHash;
            public StringField UpdateUserPasswordSalt;
            public DateTimeField UpdateUserLastDirectoryUpdate;
            public StringField UpdateUserUserImage;
            public DateTimeField UpdateUserInsertDate;
            public Int64Field UpdateUserInsertUserId;
            public DateTimeField UpdateUserUpdateDate;
            public Int64Field UpdateUserUpdateUserId;
            public Int16Field UpdateUserIsActive;

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
                LocalTextPrefix = "Organization.TimeRecordApproval";
            }
        }
    }
}
