using Microsoft.AspNetCore.Mvc;
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
                StatusCode = (int)code ,
                

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
         
        internal static Json Conflit(string message, object value)
            => Create(message, HttpStatusCode.Conflict, value);


        struct CustomResult
        {
            private CustomResult(string message, int code, object result)
            {
                Message = message;
                Code = code;
                Result = result;
            }

            public static CustomResult Create(string message, int code, object result)
            => new CustomResult(message, code, result);

            public string Message { get; private set; }
            public int Code { get; private set; }
            public object Result { get; private set; }
        }

    }
}