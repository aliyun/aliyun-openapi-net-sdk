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
    public class CommonLogTest
    {
        [Fact]
        public void OutputLogException()
        {
            CommonLog.EnableLogger();

            var exception = new Exception();

            CommonLog.LogException(exception, "errorcode", "errormessage");

            Assert.True(CommonLog.GetEnableLoggerStatus());

            // Should return directly
            CommonLog.DisableLogger();
            CommonLog.LogException(exception, "error", "error");
            Assert.False(CommonLog.GetEnableLoggerStatus());
        }

        [Fact]
        public void OutputLogInfoTestInValid()
        {
            CommonLog.EnableLogger();

            var request = new AssumeRoleRequest
            {
                Url = "https://www.alibabacloud.com"
            };
            var response = new HttpResponse();

            Assert.True(CommonLog.GetEnableLoggerStatus());

            Assert.Throws<ClientException>(() =>
            {
                CommonLog.LogInfo(request, null, 100);
            });
        }

        [Fact]
        public void OutputLogInfoTestValid()
        {
            CommonLog.EnableLogger();

            var request = new AssumeRoleRequest
            {
                Url = "https://www.alibabacloud.com"
            };
            var response = new HttpResponse();
            long executeTime = 100;

            CommonLog.LogInfo(request, response, executeTime);
            Assert.True(CommonLog.GetEnableLoggerStatus());
        }
    }
}
