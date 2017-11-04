
namespace Enterprise {

    @Serenity.Decorators.registerClass()
    export class TemplateGrid<TItem, TOptions> extends Serenity.EntityGrid<TItem, TOptions> {
        constructor(container: JQuery, options?: any) {
            super(container, options);
        }

        protected getColumns() {
            var columns = super.getColumns();

            columns.unshift({
                field: 'View Details',
                name: '',
                format: ctx =>
                    '<a class="grid-action action-open label label-primary" title="view details">View</a>',
                width: 60,
                maxWidth: 60
            });
            Q.tryFirst(columns, x => x.field == this.getIdProperty()).visible = false;
            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row);
            var target = $(e.target);

            // if user clicks "i" element, e.g. icon
            if (target.parent().hasClass('grid-action'))
                target = target.parent();

            if (target.hasClass('grid-action')) {
                e.preventDefault();

                if (target.hasClass('action-open')) {
                    this.editItem(item[this.getIdProperty()]);
                }
            }
        }

    }
}