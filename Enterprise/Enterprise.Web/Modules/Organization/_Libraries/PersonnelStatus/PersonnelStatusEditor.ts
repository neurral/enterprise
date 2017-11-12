namespace Enterprise.Organization {

    @Serenity.Decorators.registerEditor()
    export class PersonnelStatusEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, PersonnelStatusRow> {

        constructor(hidden: JQuery) {
            super(hidden);
        }

        protected getLookupKey() {
            return PersonnelStatusRow.lookupKey;
        }

        protected getItemText(item: PersonnelStatusRow, lookup) {
            return super.getItemText(item, lookup) + ' [' + item.PersonnelStatusId + ']';
        }
    }
}