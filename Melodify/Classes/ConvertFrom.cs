using System;

namespace Melodify.Classes
{
    internal class ConvertFrom
    {
        public static double TimeToSeconds(TimeSpan time)
        {
            string timeMinuteString = time.ToString("mm");
            string timeSecondString = time.ToString("ss");

            double timeMinuteToSecond = Convert.ToDouble(timeMinuteString) * 60;

            double timeSecond = Convert.ToDouble(timeSecondString);

            return timeMinuteToSecond + timeSecond;
        }

        public static double TimeToPercent(TimeSpan totalTime, TimeSpan partTime)
        {
            return (TimeToSeconds(partTime) / TimeToSeconds(totalTime)) * 100;
        }

        public static TimeSpan SecondsToTime(int second)
        {
            return TimeSpan.FromSeconds(second);
        }

    }
}