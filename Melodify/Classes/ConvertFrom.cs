using System;

namespace Melodify.Classes
{
    class ConvertFrom
    {
        static public double TimeToSeconds(TimeSpan Time)
        {
            string TimeMinutString = Time.ToString("mm");
            string TimeSecondString = Time.ToString("ss");

            double TimeMinutToSecond = Convert.ToDouble(TimeMinutString) * 60;

            double TimeSecond = Convert.ToDouble(TimeSecondString);

            return TimeMinutToSecond + TimeSecond;
        }

        static public double TimeToPercent(TimeSpan TotalTime, TimeSpan PartTime)
        {
            return (TimeToSeconds(PartTime) / TimeToSeconds(TotalTime)) * 100;
        }

        static public TimeSpan SecondsToTime(int Second)
        {
            return TimeSpan.FromSeconds(Second);
        }

    }
}