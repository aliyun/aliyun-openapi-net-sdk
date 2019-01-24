using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Utils
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
