

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Nomadwork.Controllers
{
    public class TokenController : Controller
    {
        private readonly IConfiguration _confguration;

        public TokenController (IConfiguration configuration){
            _confguration = configuration;
        }
    }
}