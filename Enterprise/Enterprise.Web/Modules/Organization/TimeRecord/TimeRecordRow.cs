
namespace Enterprise.Organization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;
    using static Constants;

    [ConnectionKey("Default"), TableName(TableName)]
    [DisplayName("Time Record"), InstanceName("Time Record"), TwoLevelCached]
    [ReadPermission(Keys.TimeRecord.Access)]
    [ModifyPermission(Keys.TimeRecord.Modify)]
    [LookupScript(Ks.Module + "." + Ks.TimeRecord, Permission = Keys.General)]
    public sealed class TimeRecordRow : Row, IIdRow, INameRow
    {
        public const string TableName = Constants.SCHEMA + Ks.TimeRecord;

        [DisplayName("Time Record Id"), Identity]
        public Int64? TimeRecordId
        {
            get { return Fields.TimeRecordId[this]; }
            set { Fields.TimeRecordId[this] = value; }
        }

        [DisplayName("Personnel"), NotNull, ForeignKey("ent.Personnel", "PersonnelId"), 
            LeftJoin("jPersonnel"), TextualField("PersonnelIdentificationNo")]
        [LookupEditor(typeof(PersonnelRow), InplaceAddPermission = Keys.Personnel.Modify)]
        public Int64? PersonnelId
        {
            get { return Fields.PersonnelId[this]; } 
            set { Fields.PersonnelId[this] = value; }
        }

        [DisplayName("Work Date"), DateTimeKind(DateTimeKind.Utc), DisplayFormat("yyyy/MM/dd")]
        public DateTime? WorkDate
        {
            get { return Fields.WorkDate[this]; }
            set { Fields.WorkDate[this] = value; }
        }

        [DisplayName("Time Record Type"), NotNull,
            DefaultValue(0),
            ForeignKey(TimeRecordTypeRow.TableName, "TimeRecordTypeId"), 
            LeftJoin("jTimeRecordType"), TextualField("TimeRecordTypeName")]
        [LookupEditor(typeof(TimeRecordTypeRow), InplaceAddPermission = Keys.Libraries.Modify)]
        public Int64? TimeRecordTypeId
        {
            get { return Fields.TimeRecordTypeId[this]; }
            set { Fields.TimeRecordTypeId[this] = value; }
        }

        [DisplayName("Time Start"), NotNull]
        [DisplayFormat("hh:mm")]
        public TimeSpan? TimeStart
        {
            get { return Fields.TimeStart[this]; }
            set { Fields.TimeStart[this] = value; }
        }

        [DisplayName("Time End"), NotNull]
        [DisplayFormat("hh:mm")]
        public TimeSpan? TimeEnd
        {
            get { return Fields.TimeEnd[this]; }
            set { Fields.TimeEnd[this] = value; }
        }

        [DisplayName("Time Start"), NotMapped]
        public Int32? TimeStartInt
        {
            get { return Fields.TimeStartInt[this]; }
            set { Fields.TimeStartInt[this] = value; }
        }

        [DisplayName("Time End"), NotMapped]
        public Int32? TimeEndInt
        {
            get { return Fields.TimeEndInt[this]; }
            set { Fields.TimeEndInt[this] = value; }
        }


        [DisplayName("Remarks"), Size(100), NotNull, QuickSearch]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Approval Status"), OneWay, DefaultValue(0), EnumEditor]
        public ApprovalStatuses? Status
        {
            get { return (ApprovalStatuses?)Fields.Status[this]; }
            set { Fields.Status[this] = (Int16?)value; }
        }

        [DisplayName("Insert Date"), DateTimeKind(DateTimeKind.Utc)]
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


        [DisplayName("Requestor Full Name")]
        [Expression("CONCAT(jPersonnel.FirstName, CONCAT(' ',jPersonnel.LastName))")]
        public String PersonnelFullName
        {
            get { return Fields.PersonnelFullName[this]; }
            set { Fields.PersonnelFullName[this] = value; }
        }

        [DisplayName("Company ID"), Expression("jPersonnel.[IdentificationNo]")]
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
   
        [DisplayName("Personnel User Id"), Expression("jPersonnel.[UserId]")]
        public Int64? PersonnelUserId
        {
            get { return Fields.PersonnelUserId[this]; }
            set { Fields.PersonnelUserId[this] = value; }
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

        public void SyncTimesForSaving() {
            this.TimeStart = TimeSpan.FromMinutes(this.TimeStartInt.Value);
            this.TimeEnd = TimeSpan.FromMinutes(this.TimeEndInt.Value);
        }

        public void SyncTimesForDisplaying() {
            this.TimeStartInt = Convert.ToInt32(this.TimeStart.Value.TotalMinutes);
            this.TimeEndInt = Convert.ToInt32(this.TimeEnd.Value.TotalMinutes);
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field TimeRecordId;
            public Int64Field PersonnelId;
            public DateTimeField WorkDate;
            public Int64Field TimeRecordTypeId;
            public TimeSpanField TimeStart;
            public TimeSpanField TimeEnd;
            public Int32Field TimeStartInt;
            public Int32Field TimeEndInt;
            public StringField Remarks;
            public Int16Field Status;
            public DateTimeField InsertDate;
            public Int64Field InsertUserId;

            public StringField PersonnelIdentificationNo;
            public StringField PersonnelFullName;
            public StringField PersonnelFirstName;
            public StringField PersonnelLastName;
            public StringField PersonnelEmail;
            public StringField PersonnelContactNumber;
            public Int64Field PersonnelPersonnelStatus;
            public Int64Field PersonnelUserId;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Organization.TimeRecord";
            }
        }
    }
}
