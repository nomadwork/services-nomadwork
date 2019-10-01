namespace Nomadwork.ViewObject
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

        public string Open { get;  set; }
        public string Close { get;  set; }
    }
}