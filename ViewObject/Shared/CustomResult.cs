namespace Nomadwork.ViewObject.Shared
{
    public class CustomResult
    {
        private CustomResult(string message, int code, object result)
        {
            Message = message;
            Code = code;
            Result = result;
        }

        public static CustomResult Create(string message, int code, object result)
            => new CustomResult(message, code, result);

        public string Message { get;private set; }
        public int Code { get;private set; }
        public object Result { get;private set; }

    }


}
