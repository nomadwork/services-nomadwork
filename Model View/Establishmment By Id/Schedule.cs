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
            => new Schedule
            {
                _open = open,
                _close = close
            };

        public string Open { get => _open; }
        public string Close { get => _close; }
    }
}