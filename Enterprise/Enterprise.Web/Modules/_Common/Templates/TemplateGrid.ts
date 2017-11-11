
namespace Enterprise {

    @Serenity.Decorators.registerClass()
    export class TemplateGrid<TItem, TOptions> extends Serenity.EntityGrid<TItem, TOptions> {
        constructor(container: JQuery, options?: any) {
            super(container, options);
            
        }

        protected getSlickOptions() {
            let opt = super.getSlickOptions();
            if (Utils.isMobile()) {
                opt.rowHeight = 50; //must have equivalent px in site.less for .slick-row
            }
            opt.frozenColumn = 0;
            return opt;
        }

        protected getCssClass() {
            let klass = Q.trimToEmpty(super.getCssClass());
            klass += " s-TemplateGrid";
            return klass;
        }

        protected getColumns() {
            var columns = super.getColumns();

            columns.unshift({
                field: 'View Details',
                name: '',
                format: ctx =>
                    '<a class="grid-action action-open btn btn-primary" title="view details">View</a>',
                width: 80,
                maxWidth: 100
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