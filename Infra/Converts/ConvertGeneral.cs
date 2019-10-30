using System;

namespace Nomadwork.Infra.Converts
{
    public static class ConvertGeneral
    {
        public static DateTime ToDate(this string date)
        {
            var split = date.Split('/');
            var day = int.Parse(split[0]);
            var month = int.Parse(split[1]);
            var year = int.Parse(split[2]);
            return new DateTime(year, month, day);
        }

        public static DateTime ToUtc(this DateTime date)
            => date;//TimeZoneInfo.ConvertTime(date, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));


        public static DateTime ToSchedule(this string time)
        {
            var data = time.Split(':');
            var hour = int.Parse(data[0]);
            var minute = int.Parse(data[1]);

            return new DateTime(2000, 1, 1, hour, minute, 0).ToUtc();
        }

    }
}
