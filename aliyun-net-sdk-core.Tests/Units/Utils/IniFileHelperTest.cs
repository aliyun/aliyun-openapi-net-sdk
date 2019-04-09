using System;

using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class IniFileHelperTest
    {
        [Fact]
        public void TestDeleteSection()
        {
            TestHelper.CreateIniFileWithEcs();

            var result = IniFileHelper.DeleteSection("default", TestHelper.GetIniFilePath());

            TestHelper.DeleteIniFile();
            Assert.True(result);
        }

        [Fact]
        public void TestDeleteKey()
        {
            TestHelper.CreateIniFileWithAk();

            var result = IniFileHelper.DeleteKey("default", "region_id", TestHelper.GetIniFilePath());

            TestHelper.DeleteIniFile();
            Assert.True(result);
        }

        [Fact]
        public void TestReadKeys()
        {
            TestHelper.CreateIniFileWithAk();

            var result = IniFileHelper.ReadKeys("default", TestHelper.GetIniFilePath());

            TestHelper.DeleteIniFile();
            Assert.True(0 < result.Length);
        }
    }
}
