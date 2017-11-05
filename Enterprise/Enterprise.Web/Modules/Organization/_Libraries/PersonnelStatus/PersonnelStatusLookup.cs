
namespace Enterprise.Organization
{
    using Enterprise.Organization.Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript(Ks.Module + "." + Ks.PersonnelStatus)]
    public sealed class PersonnelStatusLookup : RowLookupScript<PersonnelStatusRow>
    {
        private PersonnelStatusRow.RowFields flds = PersonnelStatusRow.Fields;

        public PersonnelStatusLookup()
        {
            IdField = flds.PersonnelStatusId.PropertyName;
            TextField = flds.PersonnelStatusName.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            query.Select(flds.PersonnelStatusId, flds.PersonnelStatusName, flds.Sequence);
        }

        protected override void ApplyOrder(SqlQuery query)
        {
            query.OrderBy(flds.Sequence);
            base.ApplyOrder(query);
        }
    }
}