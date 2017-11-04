namespace Enterprise {
    /**
     *  This is a custom editor that is derived from http://www.bootstraptoggle.com/
     *  It turns your checkbox into a toggle switch.
     */
    //@Serenity.Decorators.element("<input type=\"checkbox\"/>") //this does not work.
    @Serenity.Decorators.registerEditor()
    export class BSToggleEditor extends Serenity.BooleanEditor{// implements Serenity.IBooleanValue{
        private checked: boolean;
        constructor(element: JQuery, opt: BootstrapToggleOptions)
        {
            super(element);
            //First let's set the input element to be recognized by the bootstrap-toggle library.
            element.attr('data-toggle', 'toggle');
            element.removeClass('flexify');
            
            //Next, let's apply Bootstrap-Toggle options (if they exist) and Initialize
            if (opt) {
                if (opt.hideLabel) { element.closest('.field').find('.caption').hide(); }
                element.bootstrapToggle(opt);
            }
            else element.bootstrapToggle();            
        }

        public get_value(): boolean
        {
            return this.element.is(":checked"); 
        };

        public set_value(value: boolean): void
        {
            if (value) {
                this.element.bootstrapToggle('on');
            }
            else {
                this.element.bootstrapToggle('off');
            }
        };
    }

    export interface BootstrapToggleOptions {
        hideLabel?: boolean;
        on?: string;
        off?: string;
        size?: "large" | "normal" | "small" | "mini";
        onstyle?: string;
        offstyle?: string;
        style?: string;
        width?: number;
        height?: number;
    }
}