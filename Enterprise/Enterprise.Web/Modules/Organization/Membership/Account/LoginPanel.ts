namespace Enterprise.Membership {

    @Serenity.Decorators.registerClass()
    export class LoginPanel extends Serenity.PropertyPanel<LoginRequest, any> {

        protected getFormKey() { return LoginForm.formKey; }

        private form: LoginForm;

        constructor(container: JQuery) {
            super(container);

            var vegasOptions = {
                delay: 1e4,
                transitionDuration: 8e3,
                cover: true,
                overlay: Q.resolveUrl("~/Scripts/vegas/overlays/06.png"),
                slidesToKeep: 1,
                transition: ['fade2', 'blur', 'fade', 'zoomOut2'],
                animation: "random",
                slides: []
            };
            for (var i = 1; i <= 10; i++) {
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