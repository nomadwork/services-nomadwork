namespace Nomadwork.Model_View
{
    public class Schedule
    {
        private Schedule()
        {
        }

        public static Schedule Create(string open, string close)
            => new Schedule
            {
                Open = open,
                Close = close
            };

        public string Open { get; private set; }
        public string Close { get; private set; }
    }
}