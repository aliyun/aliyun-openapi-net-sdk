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
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Slb.Model.V20140515;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Core
{
    [Trait("Category", "FeatureTest")]
    public class CoreTest
    {
        [Fact]
        public void BasicRoaConnectionsTest()
        {
            var request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;

            var response = FeatureTest.DefaultClient.GetCommonResponse(request);

            Assert.Equal("200", response.HttpStatus.ToString());
            Assert.NotNull(response.Data);
        }

        [Fact]
        public void BasicRoaTokenConnection()
        {
            if (FeatureTest.RoleArn.Equals("FakeRoleArn"))
            {
                return;
            }

            var basciCredential =
                new BasicSessionCredentials(FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret, FeatureTest.GetToken());
            var profile = DefaultProfile.GetProfile(FeatureTest.RegionId, FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var client = new DefaultAcsClient(profile, basciCredential);

            var request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;

            var response = client.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public void BasicRpcConnectionsTest()
        {
            var request = new CommonRequest();
            request.Domain = "ecs-cn-hangzhou.aliyuncs.com";
            request.Version = "2014-05-26";
            request.Action = "DescribeAccessPoints";

            var response = FeatureTest.DefaultClient.GetCommonResponse(request);

            Assert.Equal("200", response.HttpStatus.ToString());
            Assert.NotNull(response.Data);
        }

        [Fact]
        public void BasicRpcStsTokenConnectionsTest()
        {
            if (FeatureTest.RoleArn.Equals("FakeRoleArn"))
            {
                return;
            }

            var basciCredential =
                new BasicSessionCredentials(FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret, FeatureTest.GetToken());
            var profile = DefaultProfile.GetProfile(FeatureTest.RegionId, FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var client = new DefaultAcsClient(profile, basciCredential);

            var request = new DescribeAccessControlListsRequest();
            var response = client.GetAcsResponse(request);

            Assert.NotNull(response);
        }

        [Fact]
        public void HttpsModeOfRoaConnectionTest()
        {
            var request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;
            request.Protocol = ProtocolType.HTTPS;

            var response = FeatureTest.DefaultClient.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public void HttpsModeOfRpcConnectionTest()
        {
            var request = new CommonRequest();
            request.Domain = "ecs-cn-hangzhou.aliyuncs.com";
            request.Version = "2014-05-26";
            request.Action = "DescribeAccessPoints";
            request.Protocol = ProtocolType.HTTPS;

            var response = FeatureTest.DefaultClient.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }

        [Fact]
        public void ServerUnreachableTest()
        {
            var request = new CommonRequest();
            request.Domain = "www.serverUnreachableTest.com";
            request.Version = "2018-11-28";
            request.Action = "serverUnreachableTest";

            Assert.Throws<ClientException>(() => { FeatureTest.DefaultClient.GetCommonResponse(request); });
        }

        [Fact]
        public void UnicodeAndQueryTest()
        {
            if (FeatureTest.RoleArn.Equals("FakeRoleArn"))
            {
                return;
            }

            var basciCredential =
                new BasicSessionCredentials(FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret, FeatureTest.GetToken());
            var profile = DefaultProfile.GetProfile(FeatureTest.RegionId, FeatureTest.BasicAccessKeyId, FeatureTest.BasicAccessKeySecret);
            var client = new DefaultAcsClient(profile, basciCredential);

            var request = new CommonRequest();
            request.TimeoutInMilliSeconds = 30000;
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;
            request.QueryParameters.Add("testParams", "SDFSDFSAetTEWTEWQO(∩_∩)O哈哈~");

            var response = client.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }
    }
}
