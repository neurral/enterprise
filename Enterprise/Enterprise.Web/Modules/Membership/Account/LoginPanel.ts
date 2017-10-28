namespace Enterprise.Membership {

    @Serenity.Decorators.registerClass()
    export class LoginPanel extends Serenity.PropertyPanel<LoginRequest, any> {

        protected getFormKey() { return LoginForm.formKey; }

        private form: LoginForm;

        constructor(container: JQuery) {
            super(container);

            var vegasOptions = {
                delay: 10000,
                cover: true,
                overlay: Q.resolveUrl("~/Scripts/vegas/overlays/06.png"),
                slidesToKeep: 1,
                transition: ['fade2', 'blur', 'flash2', 'fade', 'zoomOut', 'burn2', 'zoomIn', 'zoomIn2'];
                animation: "random",
                slides: []
            };
            for (var i = 1; i <= 9; i++) {
                vegasOptions.slides.push({
                    src: Q.resolveUrl('~/Content/site/slides/slide'+i+'.jpg')
                });
            }

            $(function () {
                ($('body') as any).vegas(vegasOptions);
            });

            this.form = new LoginForm(this.idPrefix);

            this.byId('LoginButton').click(e => {
                e.preventDefault();

                if (!this.validateForm()) {
                    return;
                }

                var request = this.getSaveEntity();
                Q.serviceCall({
                    url: Q.resolveUrl('~/Account/Login'),
                    request: request,
                    onSuccess: function (response) {
                        var q = Q.parseQueryString();
                        var returnUrl = q['returnUrl'] || q['ReturnUrl'];
                        if (returnUrl) {
                            var hash = window.location.hash;
                            if (hash != null && hash != '#')
                                returnUrl += hash;
                            window.location.href = returnUrl;
                        }
                        else {
                            window.location.href = Q.resolveUrl('~/');
                        }
                    }
                });

            });
        }
    }
}