
namespace Enterprise.Organization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[ent].[TimeRecordType]")]
    [DisplayName("Time Record Type"), InstanceName("Time Record Type"), TwoLevelCached]
    [ReadPermission("Organization:General")]
    [ModifyPermission("Organization:General")]
    public sealed class TimeRecordTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Time Record Type Id"), Identity]
        public Int64? TimeRecordTypeId
        {
            get { return Fields.TimeRecordTypeId[this]; }
            set { Fields.TimeRecordTypeId[this] = value; }
        }

        [DisplayName("Code"), Size(10), NotNull, QuickSearch]
        public String Code
        {
            get { return Fields.Code[this]; }
            set { Fields.Code[this] = value; }
        }

        [DisplayName("Time Record Type Name"), Size(100), NotNull]
        public String TimeRecordTypeName
        {
            get { return Fields.TimeRecordTypeName[this]; }
            set { Fields.TimeRecordTypeName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.TimeRecordTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Code; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TimeRecordTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field TimeRecordTypeId;
            public StringField Code;
            public StringField TimeRecordTypeName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Organization.TimeRecordType";
            }
        }
    }
}
