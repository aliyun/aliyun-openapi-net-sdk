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

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class CommonRpcRequestTest
    {
        [Fact]
        public void AcsRequestUserAgentConfigTest()
        {
            var request = new CommonRpcRequest("productTest");
            request.AppendUserAgent("test", "1.2.3");
            request.AppendUserAgent("test", "1.2.4");
            request.AppendUserAgent("mock", "1.1.2");

            var userAgent = UserAgent.Resolve(request.GetSysUserAgentConfig(), null);
            var resultStr = UserAgent.GetDefaultMessage() + " test/1.2.4" + " mock/1.1.2";

            Assert.Equal(resultStr, userAgent);
        }

        [Fact]
        public void Instance()
        {
            var request = new CommonRpcRequest("productName");
            var context = new UnmarshallerContext();
            var result = request.GetResponse(context);
            Assert.Null(result);
        }
    }
}
