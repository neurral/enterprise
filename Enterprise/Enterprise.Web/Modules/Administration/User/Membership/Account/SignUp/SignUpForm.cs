
namespace Enterprise.Membership
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;

    [FormScript("Membership.SignUp")]
    public class SignUpForm
    {
        [Required(true), Placeholder("First Name")]
        public String FirstName { get; set; }

        [Required(true), Placeholder("Last Name")]
        public String LastName { get; set; }

        [Required(true), Placeholder("Date of Birth"),
            DateTimeKind(DateTimeKind.Utc), 
            DateEditor]
        public DateTime DateOfBirth { get; set; }


        [EmailEditor, Required(true), Placeholder("Email")]
        public String Email { get; set; }

        [EmailEditor, Required(true), Placeholder("Confirm email")]
        public String ConfirmEmail { get; set; }

        [PasswordEditor, Required(true), Placeholder("Password")]
        public String Password { get; set; }

        [PasswordEditor, Required(true), Placeholder("Confirm password")]
        public String ConfirmPassword { get; set; }
    }
}
