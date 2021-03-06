﻿using System;

namespace Midgard.Utilities
{
    public class Time
    {
        public static long GetTimeStamp(DateTime time)
        {
            TimeSpan ts = time.ToUniversalTime() - new DateTime(1970, 1, 1);
            return (long)ts.TotalSeconds;
        }
        
        public static long GetTimeStamp13(DateTime time)
        {
            TimeSpan ts = time.ToUniversalTime() - new DateTime(1970, 1, 1);
            return (long)ts.TotalMilliseconds;
        }

        public static string GetSaltByTime(DateTime time)
        {
            return time.ToString("yyyyMMddHHmmss");
        }
    }
}