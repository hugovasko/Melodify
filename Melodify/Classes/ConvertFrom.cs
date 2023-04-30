using System;

namespace Melodify.Classes
{
    internal class ConvertFrom
    {
        public static double TimeToSeconds(TimeSpan time)
        {
            var timeMinuteString = time.ToString("mm");
            var timeSecondString = time.ToString("ss");

            var timeMinuteToSecond = Convert.ToDouble(timeMinuteString) * 60;

            var timeSecond = Convert.ToDouble(timeSecondString);

            return timeMinuteToSecond + timeSecond;
        }

        public static double TimeToPercent(TimeSpan totalTime, TimeSpan partTime)
        {
            return TimeToSeconds(partTime) / TimeToSeconds(totalTime) * 100;
        }

        public static TimeSpan SecondsToTime(int second)
        {
            return TimeSpan.FromSeconds(second);
        }
    }
}