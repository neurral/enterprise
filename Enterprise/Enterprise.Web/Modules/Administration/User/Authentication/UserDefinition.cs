namespace Enterprise
{
    using Serenity;
    using System;

    [Serializable]
    public class UserDefinition : IUserDefinition
    {
        public string Id { get { return UserId.ToInvariant(); } }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string UserImage { get; set; }
        public short IsActive { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Source { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? LastDirectoryUpdate { get; set; }
    }

    /// <summary>
    /// A handle for the current logged-in user, instead of always instantiating a <code>var user=((UserDefinition) Authorization.UserDefinition)</code>;
    /// Just use PMUOnline.LoggedIn.User();
    /// </summary>
    public static class LoggedIn
    {
        public static UserDefinition User
        {
            get { return (UserDefinition )Authorization.UserDefinition; }
        }
    }
}