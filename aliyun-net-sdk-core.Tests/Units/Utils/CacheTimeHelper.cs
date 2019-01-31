using System;

using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class CacheTimeHelperTest
    {
        [Fact]
        public void CheckCacheIsExpire()
        {
            // When Not Exist
            Assert.False(CacheTimeHelper.CheckCacheIsExpire("someNotExist", "ch-hangzhou"));

            // When Exist
            DateTime lastClearTime = DateTime.Now.AddDays(-1);
            CacheTimeHelper.AddLastClearTimePerProduct("ecs", "ch-hangzhou", lastClearTime);
            Assert.True(CacheTimeHelper.CheckCacheIsExpire("ecs", "ch-hangzhou"));
        }

        [Fact]
        public void AddLastClearTimePerProduct()
        {
            DateTime lastClearTime = DateTime.Now.AddDays(-1);
            CacheTimeHelper.AddLastClearTimePerProduct("ecs", "ch-hangzhou", lastClearTime);
            Assert.True(CacheTimeHelper.CheckCacheIsExpire("ecs", "ch-hangzhou"));

            lastClearTime = DateTime.Now.AddDays(1);
            CacheTimeHelper.AddLastClearTimePerProduct("ecs", "ch-hangzhou", lastClearTime);
            Assert.False(CacheTimeHelper.CheckCacheIsExpire("ecs", "ch-hangzhou"));
        }
    }
}
