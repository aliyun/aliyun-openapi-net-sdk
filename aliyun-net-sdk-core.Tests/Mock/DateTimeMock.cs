using System;

namespace Aliyun.Acs.Core.Tests.Mock
{
    public class DateTimeMock
    {

        public static DateTime getDateTimeNow()
        {
            return DateTime.Now;
        }

        public static string getNowDateTimeString()
        {
            return getDateTimeNow().ToString();
        }

        public static DateTime getExpiredDateTime()
        {
            return DateTime.Now.AddDays(-1);
        }

        public static string getExpiredDateTimeString()
        {
            return getExpiredDateTime().ToString();
        }

        public static DateTime getNotExpiredDateTime()
        {
            return DateTime.Now.AddDays(1);
        }

        public static string getNotExpiredDateTimeString()
        {
            return getNotExpiredDateTime().ToString();
        }

        public static DateTime getWillExpiredDateTime()
        {
            return DateTime.Now.AddMilliseconds(500);
        }

        public static string getWillExpiredDateTimeString()
        {
            return getWillExpiredDateTime().ToString();
        }
    }
}
