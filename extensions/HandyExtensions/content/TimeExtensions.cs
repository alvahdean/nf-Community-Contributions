using System;

namespace nanoFramework.Contrib.HandyExtensions.TimeExtensions
{

    public static class HandyDateTimeExtensions
    {
        public static DateTimeKind System(this DateTimeKindEx kind)
        {
            return (DateTimeKind)kind;
        }

        public static DateTimeKindEx Extended(this DateTimeKind kind)
        {
            return (DateTimeKindEx)kind;
        }

        public static DateTime LocalTime(this DateTime dt)
        {
            DateTimeKindEx srcKind = dt.Kind.Extended();
            DateTimeKind tgtKind = DateTimeKindEx.Local.System();
            switch (srcKind)
            {
                case DateTimeKindEx.Local:
                    return new DateTime(dt.Ticks, tgtKind);
                case DateTimeKindEx.Utc:
                default:
                    //Default is to assume date is UTC
                    return new DateTime(dt.Ticks,tgtKind);
            }
        }
    }

}
