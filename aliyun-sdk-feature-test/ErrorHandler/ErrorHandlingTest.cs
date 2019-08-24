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

using System.Text;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Vpc.Model.V20160428;

using Xunit;

namespace Aliyun.Acs.Feature.Test.ErrorHandler
{
    [Trait("Category", "FeatureTest")]
    public class ErrorHandlingTest
    {
        [Fact]
        public void BadFormatTypeTest()
        {
            var request = new ActiveFlowLogRequest();
            request.FlowLogId = "testFlow";

            var profile = DefaultProfile.GetProfile("cn-hangzhou", FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var client = new DefaultAcsClient(profile);

            var exceptionMsg = Assert.Throws<ClientException>(() =>
            {
                var response = client.GetAcsResponse(request);
            });

            Assert.Equal("The specfied instance is not existed.", exceptionMsg.ErrorMessage);
            Assert.Equal("InvalidInstanceId.NotFound", exceptionMsg.ErrorCode);
        }

        [Fact]
        public void ParameterErrorTest()
        {
            var request = new CommonRequest();
            request.Domain = "ecs-cn-hangzhou.aliyuncs.com";
            request.Version = "2014-05-26";
            request.Action = "actionError";

            var response = FeatureTest.DefaultClient.GetCommonResponse(request);
            var content = Encoding.UTF8.GetString(response.HttpResponse.Content);

            Assert.Contains("Keyword=InvalidParameter", content);
        }
    }
}
