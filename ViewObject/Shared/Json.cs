namespace Nomadwork.ViewObject
{
    public class Json
    {
        private Json()
        {
        }

        public static Json Create(string message, object result)
            => new Json
                {
                    Message = message,
                    Result = result
                };
                        
        public static Json Create(string message, int code,object result)
            => new Json
                {
                    Message = message,
                    Result = result   ,
                    Code = code
                };


        public int Code { get; private set; }
        public string Message { get; private set; }
        public object Result { get; private set; }
    }
}