/// <reference path="../_Common/Helpers/LanguageList.ts" />
/// <reference path="../_Common/Templates/TemplateGrid.ts" />
/// <reference path="../_Common/Templates/TemplateDialog.ts" />

namespace Enterprise.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('Enterprise');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}

namespace Enterprise {
    export class Options {
        private Vegas = {
            delay: 1e4,
            transitionDuration: 8e3,
            cover: true,
            overlay: Q.resolveUrl("~/Scripts/vegas/overlays/06.png"),
            slidesToKeep: 1,
            transition: ['fade2', 'blur', 'fade', 'blur2'],
            animation: "random",
            slides: []
        };

        public VegasSlides = () => {
            let v = this.Vegas;
            for (var i = 1; i <= 10; i++) {
                v.slides.push({
                    src: Q.resolveUrl('~/Content/site/slides/slide' + i + '.jpg')
                });
            }
            return v;
        };

        static PlugVegas(jquerySelector: string) {
            //element is usually just 'body'. make sure vegas.js is included in the cshtml.
            ($(jquerySelector) as any).vegas(new Options().VegasSlides());
        }
    }

    export class Utils {
        static isMobile(): boolean {
            return $('body').hasClass("mobile-device");
        }
    }

}