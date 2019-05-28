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

using System.Collections.Generic;

using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Sts
{
    public class AssumeRoleRequestTest
    {
        [Fact]
        public void DurationSecondsTest()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            var source = 10000000000;
            assumeRoleRequest.DurationSeconds = source;
            Assert.Equal(source, assumeRoleRequest.DurationSeconds);
        }

        [Fact]
        public void GetResponseTest()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            var unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                {
                    {"foo", "bar"},
                    {"a", "A"},
                    {"b", "B"}
                };
            }

            assumeRoleRequest.GetResponse(unmarshallerContext);
        }

        [Fact]
        public void PolicyTest()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            var source = "foo";
            assumeRoleRequest.Policy = source;
            Assert.Equal(source, assumeRoleRequest.Policy);
        }

        [Fact]
        public void RoleArnTest()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            var source = "foo";
            assumeRoleRequest.RoleArn = source;
            Assert.Equal(source, assumeRoleRequest.RoleArn);
        }

        [Fact]
        public void RoleSessionNameTest()
        {
            var assumeRoleRequest = new AssumeRoleRequest();
            var source = "foo";
            assumeRoleRequest.RoleSessionName = source;
            Assert.Equal(source, assumeRoleRequest.RoleSessionName);
        }
    }
}
