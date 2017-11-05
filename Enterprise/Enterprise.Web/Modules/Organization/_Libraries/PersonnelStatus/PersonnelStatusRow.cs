namespace Enterprise.Organization.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default")]
    [TableName(TableName)]
    [DisplayName("Personnel Status"), InstanceName("Personnel Status"), TwoLevelCached]
    [ReadPermission(Keys.General)]
    [ModifyPermission(Keys.Libraries.Modify)]
    [LookupScript(typeof(PersonnelStatusLookup))]
    public sealed class PersonnelStatusRow : Row, IIdRow, INameRow
    {
        public const string TableName = Constants.SCHEMA + Ks.PersonnelStatus;

        [DisplayName("Personnel Status Id"), Identity]
        public Int32? PersonnelStatusId
        {
            get { return Fields.PersonnelStatusId[this]; }
            set { Fields.PersonnelStatusId[this] = value; }
        }

        [DisplayName("Sequence"), NotNull]
        public Int32? Sequence
        {
            get { return Fields.Sequence[this]; }
            set { Fields.Sequence[this] = value; }
        }

        [DisplayName("Personnel Status Name"), Size(100), NotNull, QuickSearch]
        public String PersonnelStatusName
        {
            get { return Fields.PersonnelStatusName[this]; }
            set { Fields.PersonnelStatusName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PersonnelStatusId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PersonnelStatusName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PersonnelStatusRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PersonnelStatusId;
            public Int32Field Sequence;
            public StringField PersonnelStatusName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Organization.PersonnelStatus";
            }
        }
    }
}
