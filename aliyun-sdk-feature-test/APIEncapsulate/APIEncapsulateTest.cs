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

using Aliyun.Acs.Cdn.Model.V20180510;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Ecs.Model.V20140526;
using Aliyun.Acs.Ram.Model.V20150501;
using Aliyun.Acs.ROS.Model.V20150901;
using Aliyun.Acs.Slb.Model.V20140515;

using Xunit;

using DescribeRegionsRequest = Aliyun.Acs.Rds.Model.V20140815.DescribeRegionsRequest;
using DescribeVpcsRequest = Aliyun.Acs.Vpc.Model.V20160428.DescribeVpcsRequest;

namespace Aliyun.Acs.Feature.Test.APIEncapsulate
{
    [Trait("Category", "FeatureTest")]
    public class APIEncapsulateTest
    {
        [Fact]
        public void CdnRequestTest()
        {
            var request = new DescribeCdnCertificateDetailRequest();
            request.CertName = "cdnRequestTest";

            var response = FeatureTest.DefaultClient.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }

        [Fact]
        public void EcsRequestTest()
        {
            var request = new DescribeImagesRequest();
            var response = FeatureTest.DefaultClient.GetAcsResponse(request);

            Assert.NotNull(response);
        }

        [Fact]
        public void FormPostTypeTest()
        {
            var request = new DoActionsRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.FORM;
            request.BodyParameters.Add("test", "test");

            DefaultAcsClient client = FeatureTest.DefaultClient;
            var exception = Assert.Throws<ClientException>(() =>
            {
                client.GetAcsResponse(request);
            });
            Assert.Equal("HTTPBadRequest", exception.ErrorCode);
            Assert.Equal("No action specified", exception.ErrorMessage);
        }

        [Fact]
        public void FormPutTypeTest()
        {
            var request = new UpdateStackRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.FORM;
            request.BodyParameters.Add("ContentMD5NotMatched", "test");

            DefaultAcsClient client = FeatureTest.DefaultClient;
            var exception = Assert.Throws<ClientException>(() =>
            {
                client.GetAcsResponse(request);
            });
            Assert.Equal("HTTPBadRequest", exception.ErrorCode);
        }

        [Fact]
        public void JsonPostTypeTest()
        {
            var request = new DoActionsRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.JSON;
            request.BodyParameters.Add("test", "test");

            DefaultAcsClient client = FeatureTest.DefaultClient;
            var exception = Assert.Throws<ClientException>(() =>
            {
                client.GetAcsResponse(request);
            });
            Assert.NotNull(exception);
        }

        [Fact]
        public void JsonPutTypeTest()
        {
            var request = new UpdateStackRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.JSON;
            request.BodyParameters.Add("ContentMD5NotMatched", "test");

            DefaultAcsClient client = FeatureTest.DefaultClient;
            var exception = Assert.Throws<ClientException>(() =>
            {
                client.GetAcsResponse(request);
            });

            Assert.Equal("HTTPBadRequest", exception.ErrorCode);
        }

        [Fact]
        public void RamRequestTest()
        {
            var request = new ListAccessKeysRequest();
            var response = FeatureTest.DefaultClient.GetAcsResponse(request);

            Assert.NotNull(response.AccessKeys);
            Assert.NotNull(response.RequestId);
        }

        [Fact]
        public void RdsRequestTest()
        {
            var request = new DescribeRegionsRequest();
            var response = FeatureTest.DefaultClient.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }

        [Fact]
        public void SlbRequestTest()
        {
            var request = new DescribeAccessControlListsRequest();
            var response = FeatureTest.DefaultClient.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.Acls.Count);
        }

        [Fact]
        public void VpcRequestTest()
        {
            var request = new DescribeVpcsRequest();
            var response = FeatureTest.DefaultClient.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.Vpcs.Count);
        }

        [Fact]
        public void XmlPostTypeTest()
        {
            var request = new DoActionsRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.XML;
            request.BodyParameters.Add("test", "test");
            request.BodyParameters.Add("test2", "test2");
            DefaultAcsClient client = FeatureTest.DefaultClient;
            var exception = Assert.Throws<ClientException>(() =>
            {
                client.GetAcsResponse(request);
            });
            Assert.Equal("HTTPBadRequest", exception.ErrorCode);
            Assert.Equal("No action specified", exception.ErrorMessage);
        }

        [Fact]
        public void XmlPutTypeTest()
        {
            var request = new UpdateStackRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.XML;
            request.BodyParameters.Add("ContentMD5NotMatched", "test");
            DefaultAcsClient client = FeatureTest.DefaultClient;
            var exception = Assert.Throws<ClientException>(() =>
            {
                client.GetAcsResponse(request);
            });
            Assert.Equal("HTTPBadRequest", exception.ErrorCode);
        }
    }
}
