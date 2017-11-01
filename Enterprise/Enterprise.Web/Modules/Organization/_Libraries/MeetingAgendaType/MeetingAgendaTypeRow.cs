

namespace Enterprise.Organization.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default")]
    [TableName(TableName)]
    [DisplayName("Agenda Types"), InstanceName("Agenda Type"), TwoLevelCached]
    [ReadPermission(Keys.General)]
    [ModifyPermission(Keys.Libraries.Modify)]
    [LookupScript(Ks.Module + "." + Ks.MeetingAgendaType, Permission = Keys.General)]
    public sealed class MeetingAgendaTypeRow : Row, IIdRow, INameRow
    {
        public const string TableName = Constants.SCHEMA + "MeetingAgendaType";

        [DisplayName("Agenda Type Id"), Identity]
        public Int32? AgendaTypeId
        {
            get { return Fields.AgendaTypeId[this]; }
            set { Fields.AgendaTypeId[this] = value; }
        }

        [DisplayName("Name"), Size(100), NotNull, QuickSearch, Width(350)]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.AgendaTypeId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Name; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MeetingAgendaTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field AgendaTypeId;
            public StringField Name;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Meeting.MeetingAgendaType";
            }
        }
    }
}