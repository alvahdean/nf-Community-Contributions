using System;

namespace nanoFramework.Contrib.HandyExtensions.TimeExtensions
{

    public static class TimeSpanEx
    {
        
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of days, where the
        //     specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of days, accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or- value is System.Double.PositiveInfinity. -or- value is System.Double.NegativeInfinity.
        //
        //   T:System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromDays(double value) => TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerDay));
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of hours, where
        //     the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of hours accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or- value is System.Double.PositiveInfinity. -or- value is System.Double.NegativeInfinity.
        //
        //   T:System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromHours(double value) => TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerDay));
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of milliseconds.
        //
        // Parameters:
        //   value:
        //     A number of milliseconds.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or- value is System.Double.PositiveInfinity. -or- value is System.Double.NegativeInfinity.
        //
        //   T:System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromMilliseconds(double value) => TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerMillisecond));

        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of minutes, where
        //     the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of minutes, accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or- value is System.Double.PositiveInfinity. -or- value is System.Double.NegativeInfinity.
        //
        //   T:System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromMinutes(double value) => TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerMinute));
        //
        // Summary:
        //     Returns a System.TimeSpan that represents a specified number of seconds, where
        //     the specification is accurate to the nearest millisecond.
        //
        // Parameters:
        //   value:
        //     A number of seconds, accurate to the nearest millisecond.
        //
        // Returns:
        //     An object that represents value.
        //
        // Exceptions:
        //   T:System.OverflowException:
        //     value is less than System.TimeSpan.MinValue or greater than System.TimeSpan.MaxValue.
        //     -or- value is System.Double.PositiveInfinity. -or- value is System.Double.NegativeInfinity.
        //
        //   T:System.ArgumentException:
        //     value is equal to System.Double.NaN.
        public static TimeSpan FromSeconds(double value) => TimeSpan.FromTicks((long)(value * TimeSpan.TicksPerSecond));

    }

}
