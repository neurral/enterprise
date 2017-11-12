
namespace Enterprise.Organization
{
    using Enterprise.Organization.Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript(Ks.Module + "." + Ks.PersonnelStatus)]
    public sealed class TimeRecordTypeLookup : RowLookupScript<TimeRecordTypeRow>
    {
        private TimeRecordTypeRow.RowFields flds = TimeRecordTypeRow.Fields;

        public TimeRecordTypeLookup()
        {
            IdField = flds.TimeRecordTypeId.PropertyName;
            TextField = flds.TimeRecordTypeName.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            query.Select(flds.TimeRecordTypeId, flds.TimeRecordTypeName);
        }

        protected override void ApplyOrder(SqlQuery query)
        {
            base.ApplyOrder(query);
        }
    }
}