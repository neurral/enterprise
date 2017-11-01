namespace Enterprise.Membership {
    export class SignUpForm extends Serenity.PrefixedContext {
        static formKey = 'Membership.SignUp';

    }

    export interface SignUpForm {
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        DateOfBirth: Serenity.DateEditor;
        Email: Serenity.EmailEditor;
        ConfirmEmail: Serenity.EmailEditor;
        Password: Serenity.PasswordEditor;
        ConfirmPassword: Serenity.PasswordEditor;
    }

    [['FirstName', () => Serenity.StringEditor], ['LastName', () => Serenity.StringEditor], ['DateOfBirth', () => Serenity.DateEditor], ['Email', () => Serenity.EmailEditor], ['ConfirmEmail', () => Serenity.EmailEditor], ['Password', () => Serenity.PasswordEditor], ['ConfirmPassword', () => Serenity.PasswordEditor]].forEach(x => Object.defineProperty(SignUpForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

