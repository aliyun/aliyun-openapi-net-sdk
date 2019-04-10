using System;

using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class IniFileHelperTest
    {
        [Fact]
        public void TestGetValueWithNoParams()
        {
            TestHelper.CreateIniFileWithEcs();

            IniReader iniReader = new IniReader(TestHelper.GetIniFilePath());
            var value = iniReader.GetValue("region_id", "default");

            TestHelper.DeleteIniFile();
            Assert.Equal("cn-hangzhou", value);
        }

        [Fact]
        public void TestGetKeys()
        {
            TestHelper.CreateIniFileWithAk();

            IniReader iniReader = new IniReader(TestHelper.GetIniFilePath());
            var result = iniReader.GetKeys("default");

            TestHelper.DeleteIniFile();
            Assert.True(0 < result.Length);
        }
    }
}
