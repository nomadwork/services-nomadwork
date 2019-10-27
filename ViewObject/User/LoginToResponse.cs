using Nomadwork.ViewObject.User;

namespace Nomadwork.ViewObject
{
    public class LoginToResponse
    {
        private LoginToResponse()
        {
        }

        public static LoginToResponse Create(UserToDisplay user, Token token)
         => new LoginToResponse
         {
             Token = token,
             User = user
         };

        public Token Token { get; private set; }
        public UserToDisplay User { get; private set; }

    }
}
