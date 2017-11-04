
namespace Enterprise {

    @Serenity.Decorators.registerClass()
    export class TemplateGrid<TItem, TOptions> extends Serenity.EntityGrid<TItem, TOptions> {
        constructor(container: JQuery, options: any) {
            super(container, options);
        }
    }
}