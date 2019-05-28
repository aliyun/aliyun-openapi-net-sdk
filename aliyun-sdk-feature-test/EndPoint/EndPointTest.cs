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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Ecs.Model.V20140526;
using Aliyun.Acs.Ram.Model.V20150501;

using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Aliyun.Acs.Feature.Test.EndPoint
{
    [Trait("Category", "FeatureTest")]
    public class EndPointTest : FeatureTestBase
    {
        [Fact]
        public void TestAddExistingEndpointManually()
        {
            var request = new DescribeRegionsRequest();
            var profile = DefaultProfile.GetProfile("cn-wenzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            var testClient = new DefaultAcsClient(profile);

            DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", "Ecs",
                "abc.cn-hangzhou.endpoint-test.exception.com");

            Assert.Throws<ClientException>(() => { testClient.GetAcsResponse(request); });
        }

        [Fact]
        public void TestAddNewEndPointManually()
        {
            var profile = DefaultProfile.GetProfile("cn-wenzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            var testClient = new DefaultAcsClient(profile);

            var request = new DescribeRegionsRequest();

            var exceptionMsg = Assert.Throws<ClientException>(() =>
            {
                var response = testClient.GetAcsResponse(request);
            });

            Assert.Equal("Can not find endpoint to access.", exceptionMsg.ErrorMessage);

            DefaultProfile.AddEndpoint("cn-wenzhou", "cn-wenzhou", "Ecs", "abc.cn-wenzhou.endpoint-test.exception.com");

            Assert.Throws<ClientException>(() => { testClient.GetAcsResponse(request); });
        }

        [Fact]
        public void TestProductsWithLocationService()
        {
            var request = new DescribeRegionsRequest();
            var response = client.GetAcsResponse(request);

            Assert.True(0 < response.Regions.Count);
        }

        [Fact]
        public void TestProductsWithoutLocationService()
        {
            var request = new ListAccessKeysRequest();
            var response = client.GetAcsResponse(request);

            Assert.True(0 < response.AccessKeys.Count);
        }
    }
}
