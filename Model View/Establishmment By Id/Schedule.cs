namespace Nomadwork.Model_View
{
    public class Schedule
    {
        private string _open;
        private string _close;

        private Schedule()
        {
        }

        public static Schedule Create(string open, string close)
        {
            return new Schedule
            {
                _open = open,
                _close = close
            };
        }

        public string Open { get { return _open; } }
        public string Close { get { return _close; } }
    }
}