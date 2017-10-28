namespace Enterprise.Administration {

    @Serenity.Decorators.registerClass()
    export class UserDialog extends Serenity.EntityDialog<UserRow, any> {
        protected getFormKey() { return UserForm.formKey; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getIsActiveProperty() { return UserRow.isActiveProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getNameProperty() { return UserRow.nameProperty; }
        protected getService() { return UserService.baseUrl; }

        protected form = new UserForm(this.idPrefix);
        private activateBtn: JQuery;

        constructor() {
            super();

            this.form.Password.addValidationRule(this.uniqueName, e => {
                if (this.form.Password.value.length < 7)
                    return "Password must be at least 7 characters!";
            });

            this.form.PasswordConfirm.addValidationRule(this.uniqueName, e => {
                if (this.form.Password.value != this.form.PasswordConfirm.value)
                    return "The passwords entered doesn't match!";
            });
        }

        protected getToolbarButtons() {
            let buttons = super.getToolbarButtons();

            buttons.push({
                title: Q.text('Site.UserDialog.EditRolesButton'),
                cssClass: 'edit-roles-button',
                icon: 'icon-people text-blue',
                onClick: () => {
                    new UserRoleDialog({
                        userID: this.entity.UserId,
                        username: this.entity.Username
                    }).dialogOpen();
                }
            });

            buttons.push({
                title: Q.text('Site.UserDialog.EditPermissionsButton'),
                cssClass: 'edit-permissions-button',
                icon: 'icon-lock-open text-green',
                onClick: () => {
                    new UserPermissionDialog({
                        userID: this.entity.UserId,
                        username: this.entity.Username
                    }).dialogOpen();
                }
            });

            buttons.push({
                title: 'Resend Activation Link', //TODO add to Texts
                cssClass: 'activate-user-button disabled',
                icon: 'icon-check text-blue',
                onClick: () => {

                    Q.confirm("Confirm resend of activation link?",
                        () => {
                            this.activateBtn.addClass("disabled");
                            UserService.ResendActivationLink({
                                EntityId: this.entityId
                            },
                            (response) => {
                                Q.notifyInfo("Activation link sent.");
                            });
                        }

                    );
                }
            });



            return buttons;
        }

        protected updateInterface() {
            super.updateInterface();

            this.toolbar.findButton('edit-roles-button').toggleClass('disabled', this.isNewOrDeleted());
            this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // these fields are only required in new record mode
            this.form.Password.element.toggleClass('required', this.isNew())
                .closest('.field').find('sup').toggle(this.isNew());
            this.form.PasswordConfirm.element.toggleClass('required', this.isNew())
                .closest('.field').find('sup').toggle(this.isNew());

            this.activateBtn = $(".activate-user-button");
            if (this.entity[UserRow.isActiveProperty] != 1) {
                this.activateBtn.removeClass("disabled");
            }
            else {
                this.activateBtn.hide(1);
            }
        }
    }
}