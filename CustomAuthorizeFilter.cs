using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Nomadwork.ViewObject;
using System.Linq;
using System.Threading.Tasks;

namespace Nomadwork
{
    public class CustomAuthorizeFilter : IAsyncAuthorizationFilter
    {
        private readonly AuthorizationPolicy _policy;

        public CustomAuthorizeFilter(AuthorizationPolicy policy)
        {
            _policy = policy;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            // Allow Anonymous skips all authorization
            if (context.Filters.Any(item => item is IAllowAnonymousFilter))
            {
                return;
            }

            var policyEvaluator = context.HttpContext.RequestServices.GetRequiredService<IPolicyEvaluator>();
            var authenticateResult = await policyEvaluator.AuthenticateAsync(_policy, context.HttpContext);
            var authorizeResult = await policyEvaluator.AuthorizeAsync(_policy, authenticateResult, context.HttpContext, context);


            if (authorizeResult.Challenged)
            {
                // Return custom 401 result
                context.Result = Json.Unauthorized();
            }
            else if (authorizeResult.Forbidden)
            {
                // Return default 403 result
                context.Result = Json.Forbidden(_policy.AuthenticationSchemes.ToArray());
            }
        }
    }
}
