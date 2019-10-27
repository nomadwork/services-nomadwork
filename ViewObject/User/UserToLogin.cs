namespace Nomadwork.Controllers.ViewObject
{
    public class UserToLogin
    {
        public static UserToLogin Create(string email, string password)
            => new UserToLogin
            {
                Email = email,
                Password = password,
            };

        public UserToLogin()
        {
        }

        public string Email { get; set; }
        public string Password { get; set; }

    }
}
