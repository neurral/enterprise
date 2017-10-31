
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
    [DisplayName("Meeting"), InstanceName("Meeting"), TwoLevelCached]
    [ReadPermission("Organization:General")]
    [ModifyPermission("Organization:General")]
    public sealed class MeetingRow : Row, IIdRow, INameRow
    {
        public const string TableName = Constants.SCHEMA + "Meetings";

        [DisplayName("Meeting Id"), Identity]
        public Int32? MeetingId
        {
            get { return Fields.MeetingId[this]; }
            set { Fields.MeetingId[this] = value; }
        }

        [DisplayName("Meeting Name"), Size(100), NotNull, QuickSearch]
        public String MeetingName
        {
            get { return Fields.MeetingName[this]; }
            set { Fields.MeetingName[this] = value; }
        }

        [DisplayName("Meeting Number"), Size(20)]
        public String MeetingNumber
        {
            get { return Fields.MeetingNumber[this]; }
            set { Fields.MeetingNumber[this] = value; }
        }

        [DisplayName("Meeting Guid"), NotNull]
        public Guid? MeetingGuid
        {
            get { return Fields.MeetingGuid[this]; }
            set { Fields.MeetingGuid[this] = value; }
        }

        [DisplayName("Meeting Type"), NotNull, ForeignKey("[dbo].[MeetingTypes]", "MeetingTypeId"), LeftJoin("jMeetingType"), TextualField("MeetingTypeName")]
        public Int32? MeetingTypeId
        {
            get { return Fields.MeetingTypeId[this]; }
            set { Fields.MeetingTypeId[this] = value; }
        }

        [DisplayName("Start Date"), NotNull]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
        }

        [DisplayName("End Date"), NotNull]
        public DateTime? EndDate
        {
            get { return Fields.EndDate[this]; }
            set { Fields.EndDate[this] = value; }
        }

        [DisplayName("Location"), ForeignKey("[dbo].[MeetingLocations]", "LocationId"), LeftJoin("jLocation"), TextualField("LocationName")]
        public Int32? LocationId
        {
            get { return Fields.LocationId[this]; }
            set { Fields.LocationId[this] = value; }
        }

        [DisplayName("Organizer Contact"), ForeignKey("[dbo].[Contacts]", "ContactId"), LeftJoin("jOrganizerContact"), TextualField("OrganizerContactTitle")]
        public Int32? OrganizerContactId
        {
            get { return Fields.OrganizerContactId[this]; }
            set { Fields.OrganizerContactId[this] = value; }
        }

        [DisplayName("Reporter Contact"), ForeignKey("[dbo].[Contacts]", "ContactId"), LeftJoin("jReporterContact"), TextualField("ReporterContactTitle")]
        public Int32? ReporterContactId
        {
            get { return Fields.ReporterContactId[this]; }
            set { Fields.ReporterContactId[this] = value; }
        }

        [DisplayName("Insert User Id"), NotNull]
        public Int32? InsertUserId
        {
            get { return Fields.InsertUserId[this]; }
            set { Fields.InsertUserId[this] = value; }
        }

        [DisplayName("Insert Date"), NotNull]
        public DateTime? InsertDate
        {
            get { return Fields.InsertDate[this]; }
            set { Fields.InsertDate[this] = value; }
        }

        [DisplayName("Update User Id")]
        public Int32? UpdateUserId
        {
            get { return Fields.UpdateUserId[this]; }
            set { Fields.UpdateUserId[this] = value; }
        }

        [DisplayName("Update Date")]
        public DateTime? UpdateDate
        {
            get { return Fields.UpdateDate[this]; }
            set { Fields.UpdateDate[this] = value; }
        }

        [DisplayName("Meeting Type Name"), Expression("jMeetingType.[Name]")]
        public String MeetingTypeName
        {
            get { return Fields.MeetingTypeName[this]; }
            set { Fields.MeetingTypeName[this] = value; }
        }
        [DisplayName("Location Name"), Expression("jLocation.[Name]")]
        public String LocationName
        {
            get { return Fields.LocationName[this]; }
            set { Fields.LocationName[this] = value; }
        }
        [DisplayName("Location Address"), Expression("jLocation.[Address]")]
        public String LocationAddress
        {
            get { return Fields.LocationAddress[this]; }
            set { Fields.LocationAddress[this] = value; }
        }
        [DisplayName("Location Latitude"), Expression("jLocation.[Latitude]")]
        public Double? LocationLatitude
        {
            get { return Fields.LocationLatitude[this]; }
            set { Fields.LocationLatitude[this] = value; }
        }
        [DisplayName("Location Longitude"), Expression("jLocation.[Longitude]")]
        public Double? LocationLongitude
        {
            get { return Fields.LocationLongitude[this]; }
            set { Fields.LocationLongitude[this] = value; }
        }
        [DisplayName("Organizer Contact Title"), Expression("jOrganizerContact.[Title]")]
        public String OrganizerContactTitle
        {
            get { return Fields.OrganizerContactTitle[this]; }
            set { Fields.OrganizerContactTitle[this] = value; }
        }
        [DisplayName("Organizer Contact First Name"), Expression("jOrganizerContact.[FirstName]")]
        public String OrganizerContactFirstName
        {
            get { return Fields.OrganizerContactFirstName[this]; }
            set { Fields.OrganizerContactFirstName[this] = value; }
        }
        [DisplayName("Organizer Contact Last Name"), Expression("jOrganizerContact.[LastName]")]
        public String OrganizerContactLastName
        {
            get { return Fields.OrganizerContactLastName[this]; }
            set { Fields.OrganizerContactLastName[this] = value; }
        }
        [DisplayName("Organizer Contact Email"), Expression("jOrganizerContact.[Email]")]
        public String OrganizerContactEmail
        {
            get { return Fields.OrganizerContactEmail[this]; }
            set { Fields.OrganizerContactEmail[this] = value; }
        }
        [DisplayName("Organizer Contact Identity No"), Expression("jOrganizerContact.[IdentityNo]")]
        public String OrganizerContactIdentityNo
        {
            get { return Fields.OrganizerContactIdentityNo[this]; }
            set { Fields.OrganizerContactIdentityNo[this] = value; }
        }
        [DisplayName("Organizer Contact User Id"), Expression("jOrganizerContact.[UserId]")]
        public Int32? OrganizerContactUserId
        {
            get { return Fields.OrganizerContactUserId[this]; }
            set { Fields.OrganizerContactUserId[this] = value; }
        }
        [DisplayName("Reporter Contact Title"), Expression("jReporterContact.[Title]")]
        public String ReporterContactTitle
        {
            get { return Fields.ReporterContactTitle[this]; }
            set { Fields.ReporterContactTitle[this] = value; }
        }
        [DisplayName("Reporter Contact First Name"), Expression("jReporterContact.[FirstName]")]
        public String ReporterContactFirstName
        {
            get { return Fields.ReporterContactFirstName[this]; }
            set { Fields.ReporterContactFirstName[this] = value; }
        }
        [DisplayName("Reporter Contact Last Name"), Expression("jReporterContact.[LastName]")]
        public String ReporterContactLastName
        {
            get { return Fields.ReporterContactLastName[this]; }
            set { Fields.ReporterContactLastName[this] = value; }
        }
        [DisplayName("Reporter Contact Email"), Expression("jReporterContact.[Email]")]
        public String ReporterContactEmail
        {
            get { return Fields.ReporterContactEmail[this]; }
            set { Fields.ReporterContactEmail[this] = value; }
        }
        [DisplayName("Reporter Contact Identity No"), Expression("jReporterContact.[IdentityNo]")]
        public String ReporterContactIdentityNo
        {
            get { return Fields.ReporterContactIdentityNo[this]; }
            set { Fields.ReporterContactIdentityNo[this] = value; }
        }
        [DisplayName("Reporter Contact User Id"), Expression("jReporterContact.[UserId]")]
        public Int32? ReporterContactUserId
        {
            get { return Fields.ReporterContactUserId[this]; }
            set { Fields.ReporterContactUserId[this] = value; }
        }
        IIdField IIdRow.IdField
        {
            get { return Fields.MeetingId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MeetingName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MeetingRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MeetingId;
            public StringField MeetingName;
            public StringField MeetingNumber;
            public GuidField MeetingGuid;
            public Int32Field MeetingTypeId;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public Int32Field LocationId;
            public Int32Field OrganizerContactId;
            public Int32Field ReporterContactId;
            public Int32Field InsertUserId;
            public DateTimeField InsertDate;
            public Int32Field UpdateUserId;
            public DateTimeField UpdateDate;

            public StringField MeetingTypeName;

            public StringField LocationName;
            public StringField LocationAddress;
            public DoubleField LocationLatitude;
            public DoubleField LocationLongitude;

            public StringField OrganizerContactTitle;
            public StringField OrganizerContactFirstName;
            public StringField OrganizerContactLastName;
            public StringField OrganizerContactEmail;
            public StringField OrganizerContactIdentityNo;
            public Int32Field OrganizerContactUserId;

            public StringField ReporterContactTitle;
            public StringField ReporterContactFirstName;
            public StringField ReporterContactLastName;
            public StringField ReporterContactEmail;
            public StringField ReporterContactIdentityNo;
            public Int32Field ReporterContactUserId;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Organization.Meeting";
            }
        }
    }
}
