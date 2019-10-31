using Nomadwork.Infra.Converts;
using System;

namespace Nomadwork.ViewObject.User
{

    public class Token
    {
        public Token(bool authenticated, int expirationInSeconds, string accessToken)
        {
            Authenticated = authenticated;
            Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Expiration = (DateTime.Now + TimeSpan.FromSeconds(expirationInSeconds)).ToString("yyyy-MM-dd HH:mm:ss");
            AccessToken = accessToken;
        }


        public bool Authenticated { get; private set; }
        public string Created { get; private set; }
        public string Expiration { get; private set; }
        public string AccessToken { get; private set; }


        public static Token Create(int expirationInSeconds, string accessToken)
          => new Token(true, expirationInSeconds, accessToken);

    }

}
