using System.Text.RegularExpressions;

namespace Nomadwork
{
    public static class Validate
    {
        public static bool IsEmail(this string email)
            => new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$").IsMatch(email);

    }
}
