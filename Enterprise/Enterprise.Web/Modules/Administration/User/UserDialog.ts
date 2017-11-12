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
        private profileMode = false;

        constructor(option? : any) {
            super();
            this.form.Password.addValidationRule(this.uniqueName, e => {
                if (this.form.Password.value.length < 7)
                    return "Password must be at least 7 characters!";
            });

            this.form.PasswordConfirm.addValidationRule(this.uniqueName, e => {
                if (this.form.Password.value != this.form.PasswordConfirm.value)
                    return "The passwords entered doesn't match!";
            });

            if (option) {
                this.profileMode = option.profileMode || false;
            }

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
            if (this.profileMode) {
                this.toolbar.findButton("edit-permissions-button").hide(1);
                this.toolbar.findButton("edit-roles-button").hide(1);
                this.toolbar.findButton("activate-user-button").hide(1);
                this.deleteButton.hide(1);
                this.form.Source.element.parent().hide(1);
            }
            else {
                this.toolbar.findButton('edit-roles-button').toggleClass('disabled', this.isNewOrDeleted());
                this.toolbar.findButton("edit-permissions-button").toggleClass("disabled", this.isNewOrDeleted());

            }
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

        static showProfile(userId: number) {
            (new UserDialog({ profileMode: true })).loadByIdAndOpenDialog(userId);               
            //(new Enterprise.Organization.PersonnelDialog({ profileMode: true })).loadByIdAndOpenDialog(userId);               
        }
    }
}