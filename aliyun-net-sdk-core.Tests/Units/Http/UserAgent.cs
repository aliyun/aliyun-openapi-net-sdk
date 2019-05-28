/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Text.RegularExpressions;

using Aliyun.Acs.Core.Http;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Http
{
    public class UserAgentTest
    {
        private string BuildClientVersion(string[] value)
        {
            var finalValue = "";
            for (var i = 0; i < value.Length - 1; ++i)
            {
                finalValue += value[i].Replace(".", "").ToLower();
            }

            finalValue += "/" + value[value.Length - 1];

            return finalValue;
        }

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

            userAgent.AppendUserAgent("test", "222");
            dict.TryGetValue("test", out result);
            Assert.Equal("222", result);

            dict.TryGetValue("null", out result);
            Assert.Null(result);

            dict.TryGetValue("", out result);
            Assert.Null(result);

            dict.TryGetValue("Core", out result);
            Assert.Null(result);
        }

        [Fact]
        public void FrameworkAndCoreRegexTest()
        {
            var dire1 = "C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\";
            var dire2 = "C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\2.1.8\\";
            char[] separator = {'\\', '/'};

            var rx = new Regex(@"(\.NET).*(\\|\/).*(\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = rx.Match(dire1);

            var clientVersion = "";
            if (matches.Success)
            {
                var array = matches.Value.Split(separator);
                clientVersion = BuildClientVersion(array);
            }

            Assert.Equal("netframework64/v4.0.30319", clientVersion);
            matches = rx.Match(dire2);
            if (matches.Success)
            {
                var array = matches.Value.Split(separator);
                clientVersion = BuildClientVersion(array);
            }

            Assert.Equal("netcoreapp/2.1.8", clientVersion);
        }

        [Fact]
        public void ResolveTest()
        {
            var UserAgent = new UserAgent();
            var agent = UserAgent.Resolve(UserAgent, null);
            Assert.Equal(UserAgent.GetDefaultMessage(), agent);

            agent = UserAgent.Resolve(null, UserAgent);
            Assert.Equal(UserAgent.GetDefaultMessage(), agent);

            UserAgent.AppendUserAgent("test", "2.2.3");
            UserAgent.AppendUserAgent("Core", "22");
            var resultStr = UserAgent.GetDefaultMessage() + " test/2.2.3";

            agent = UserAgent.Resolve(null, UserAgent);
            Assert.Equal(resultStr, agent);

            agent = UserAgent.Resolve(UserAgent, null);
            Assert.Equal(resultStr, agent);

            agent = UserAgent.Resolve(null, null);
            Assert.Equal(UserAgent.GetDefaultMessage(), agent);

            var requestUserAgent = new UserAgent();
            requestUserAgent.AppendUserAgent("requestUserAgent", "1.1.1");
            requestUserAgent.AppendUserAgent("test", "23");

            resultStr = UserAgent.GetDefaultMessage() + " requestUserAgent/1.1.1" + " test/23";
            agent = UserAgent.Resolve(requestUserAgent, UserAgent);

            Assert.Equal(resultStr, agent);
        }

        [Fact]
        public void RuntimeDirectoryRegexTest()
        {
            var rx = new Regex(@"(Microsoft).*(\\|/).*(\d)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            char[] separator = {'\\', '/'};

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
    }
}
