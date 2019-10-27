using Microsoft.AspNetCore.Mvc;
using Nomadwork.ViewObject.Shared;
using System.Net;

namespace Nomadwork.ViewObject
{
    public class Json : JsonResult
    {
        private Json(object value) : base(value)
        {
        }


        internal static Json Create(string message, HttpStatusCode code, object result)
        {
            var json = CustomResult.Create(message, (int)code, result);
            return new Json(json)
            {
                StatusCode = (int)code,
            };
        }


        internal static Json Ok(string message, object value)
           => Create(message, HttpStatusCode.OK, value);


        internal static Json NotFound(string message, object value)
            => Create(message, HttpStatusCode.NotFound, value);

        internal static Json Unauthorized()
            => Create("Authorization failed.", HttpStatusCode.Unauthorized, false);


        internal static Json Forbidden(string[] obj)
            => Create("Authorization Forbidden.", HttpStatusCode.Forbidden, obj);

        internal static Json BadRequest(string message, object value)
            => Create(message, HttpStatusCode.NotFound, value);

    }
}