using System;
using System.Diagnostics;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util
{
    internal static partial class Extensions
    {
        private static readonly long ticksPerSecond = TimeSpan.FromSeconds(1).Ticks;
        private static readonly double tickFrequency = ticksPerSecond / (double)Stopwatch.Frequency;
        public static long GetElapsedDateTimeTicks(this Stopwatch self)
        {
            double stopwatchTicks = self.ElapsedTicks;
            long ticks = (long)(stopwatchTicks * tickFrequency);
            return ticks;
        }
    }
}
