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

using System;

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class SerilogHelperTest
    {
        [Fact]
        public void OutputLogException()
        {
            var format = "{Exception}";
            var logger = new Logger(EnvironmentUtil.GetHomePath() + EnvironmentUtil.GetOSSlash() + "log.txt",
                template: format);

            SerilogHelper.SetLogger(logger);

            var exception = new Exception();

            SerilogHelper.LogException(exception, "errorcode", "errormessage");

            SerilogHelper.CloseLogger();
            Assert.False(SerilogHelper.EnableLogger);

            // Should return directly
            SerilogHelper.LogException(exception, "error", "error");
        }

        [Fact]
        public void OutputLogInfoTestInValid()
        {
            var format = "{code}|{pid}|{start_time}";
            var logger = new Logger(EnvironmentUtil.GetHomePath() + EnvironmentUtil.GetOSSlash() + "log.txt",
                template: format);

            SerilogHelper.SetLogger(logger);

            var request = new AssumeRoleRequest
            {
                Url = "https://www.alibabacloud.com"
            };
            var response = new HttpResponse();
            long executeTime = 100;
            var startTime = DateTime.Now.ToString();

            Assert.Throws<ClientException>(() => { SerilogHelper.LogInfo(request, null, executeTime, startTime); });

            SerilogHelper.CloseLogger();
            Assert.False(SerilogHelper.EnableLogger);

            SerilogHelper.LogInfo(request, null, 100, "100");
        }

        [Fact]
        public void OutputLogInfoTestValid()
        {
            var format = "{start_time}|{code}|{pid}|{cost}";

            var logger = new Logger(EnvironmentUtil.GetHomePath() + EnvironmentUtil.GetOSSlash() + "log.txt",
                template: format);

            SerilogHelper.SetLogger(logger);

            var request = new AssumeRoleRequest
            {
                Url = "https://www.alibabacloud.com"
            };
            var response = new HttpResponse();
            long executeTime = 100;
            var startTime = DateTime.Now.ToString();

            SerilogHelper.LogInfo(request, response, executeTime, startTime);
            Assert.True(SerilogHelper.EnableLogger);

            SerilogHelper.CloseLogger();
        }
    }
}
