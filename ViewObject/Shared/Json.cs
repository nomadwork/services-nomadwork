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



        public string Message { get; private set; }
        public object Result { get; private set; }
    }
}