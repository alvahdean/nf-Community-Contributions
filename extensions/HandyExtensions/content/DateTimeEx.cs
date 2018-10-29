using System;

namespace nanoFramework.Contrib.HandyExtensions.TimeExtensions
{
    public enum DateTimeKindEx
    {
        Utc=DateTimeKind.Utc,
        Local=Utc+1
    }

    public class DateTimeEx
    {
        private static double _utcOffset = 0;

        /// <summary>
        /// Gets the local time offset from UTC in fractional hours
        /// </summary>
        public static double UtcOffset
        {
            get => _utcOffset;
            set => _utcOffset = value;
        }

        public static DateTime Now => DateTime.UtcNow.LocalTime();
    }

}
