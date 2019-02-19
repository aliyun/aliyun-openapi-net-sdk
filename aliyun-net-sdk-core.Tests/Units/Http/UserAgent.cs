using Xunit;
using System.Text.RegularExpressions;
using System.Collections.Generic;

using Aliyun.Acs.Core.Http;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class UserAgentTest
    {

        [Fact]
        public void AppendUserAgentTest()
        {
            var userAgent = new UserAgent();
            userAgent.AppendUserAgent("test", "111");
            userAgent.AppendUserAgent("test", null);
            userAgent.AppendUserAgent("test", "");
            userAgent.AppendUserAgent("", "2.2.1");
            userAgent.AppendUserAgent(null, "2.2.1");
            userAgent.AppendUserAgent("Core", "22");

            var dict = userAgent.GetSysUserAgentDict();
            string result;
            dict.TryGetValue("test", out result);
            Assert.Equal("111", result);

            dict.TryGetValue("null", out result);
            Assert.Null(result);

            dict.TryGetValue("", out result);
            Assert.Null(result);

            dict.TryGetValue("Core", out result);
            Assert.Null(result);

        }

        [Fact]
        public void RuntimeDirectoryRegexTest()
        {
            Regex rx = new Regex(@"(Microsoft).*(\\|/).*(\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            char[] separator = { '\\', '/' };

            var directory1 = "C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.2.2\\";
            var directory2 = "/user/Microsoft.NETCore.App/2.2.1/";

            var matches1 = rx.Match(directory1);
            var matches2 = rx.Match(directory2);

            var result1 = matches1.Value.Split(separator);
            var result2 = matches2.Value.Split(separator);

            Assert.Equal("Microsoft.NETCore.App", result1[0]);
            Assert.Equal("2.2.2", result1[1]);

            Assert.Equal("Microsoft.NETCore.App", result2[0]);
            Assert.Equal("2.2.1", result2[1]);

        }

        [Fact]
        public void ResolveTest()
        {
            var userAgent = new UserAgent();
            var agent = userAgent.Resolve(userAgent, null);
            Assert.Equal(UserAgent.GetDefaultMessage(), agent);

            agent = userAgent.Resolve(null, userAgent);
            Assert.Equal(UserAgent.GetDefaultMessage(), agent);

            userAgent.AppendUserAgent("test", "2.2.3");
            userAgent.AppendUserAgent("Core", "22");
            var resultStr = UserAgent.GetDefaultMessage() + " test/2.2.3";

            agent = userAgent.Resolve(null, userAgent);
            Assert.Equal(resultStr, agent);

            agent = userAgent.Resolve(userAgent, null);
            Assert.Equal(resultStr, agent);

            agent = userAgent.Resolve(null, null);
            Assert.Equal(UserAgent.GetDefaultMessage(), agent);

            var requestUserAgent = new UserAgent();
            requestUserAgent.AppendUserAgent("requestUserAgent", "1.1.1");
            requestUserAgent.AppendUserAgent("test", "23");

            resultStr = UserAgent.GetDefaultMessage() + " requestUserAgent/1.1.1" + " test/23";
            agent = userAgent.Resolve(requestUserAgent, userAgent);

            Assert.Equal(resultStr, agent);

        }
    }
}
