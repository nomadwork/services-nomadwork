namespace Nomadwork.Model_View
{
    public class Json
    {
        private string _message;
        private object _result;

        private Json()
        {

        }

        public static Json Create(string message, object result)
        {
            return new Json
            {
                _message = message,
                _result = result
            };
        }


        public string Message
        {
            get
            {
                return _message;
            }
        }
        public object Result
        {
            get
            {
                return _result;
            }
        }





    }
}