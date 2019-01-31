using System;

using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class DateTimeExtensionsTest
    {
        [Fact]
        public void currentTimeMillis()
        {
            DateTime d = DateTime.Now;
            var r = DateTimeExtensions.currentTimeMillis(d);
            Assert.IsType<long>(r);
        }
    }
}
