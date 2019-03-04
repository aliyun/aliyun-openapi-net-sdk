using System;
using System.Collections.Generic;

using Aliyun.Acs.Cdn.Model.V20180510;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Ecs.Model.V20140526;
using Aliyun.Acs.Ram.Model.V20150501;
using Aliyun.Acs.Rds.Model.V20140815;
using Aliyun.Acs.ROS.Model.V20150901;
using Aliyun.Acs.Slb.Model.V20140515;
using Aliyun.Acs.Vpc.Model.V20160428;

using Xunit;

namespace Aliyun.Acs.Feature.Test.APIEncapsulate
{
    public class APIEncapsulateTest : FeatureTestBase
    {
        [Trait("Category", "FeatureTest")]
        [Fact]
        public void EcsRequestTest()
        {
            DescribeInstancesRequest request = new DescribeInstancesRequest();
            DescribeInstancesResponse response = this.client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.TotalCount);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void RdsRequestTest()
        {
            Rds.Model.V20140815.DescribeRegionsRequest request = new Rds.Model.V20140815.DescribeRegionsRequest();
            Rds.Model.V20140815.DescribeRegionsResponse response = this.client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void CdnRequestTest()
        {
            DescribeCdnCertificateDetailRequest request = new DescribeCdnCertificateDetailRequest();
            request.CertName = "cdnRequestTest";

            DescribeCdnCertificateDetailResponse response = this.client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void SlbRequestTest()
        {
            DescribeAccessControlListsRequest request = new DescribeAccessControlListsRequest();
            DescribeAccessControlListsResponse response = this.client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.Acls.Count);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void RamRequestTest()
        {
            ListAccessKeysRequest request = new ListAccessKeysRequest();
            ListAccessKeysResponse response = this.client.GetAcsResponse(request);

            Assert.NotNull(response.AccessKeys);
            Assert.NotNull(response.RequestId);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void VpcRequestTest()
        {
            Vpc.Model.V20160428.DescribeVpcsRequest request = new Vpc.Model.V20160428.DescribeVpcsRequest();
            Vpc.Model.V20160428.DescribeVpcsResponse response = this.client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.Vpcs.Count);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void JsonPutTypeTest()
        {
            UpdateStackRequest request = new UpdateStackRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.JSON;
            request.BodyParameters.Add("ContentMD5NotMatched", "test");

            try
            {
                this.client.GetAcsResponse(request);
            }
            catch (ClientException ex)
            {
                Assert.Equal("HTTPBadRequest", ex.ErrorCode);
                Assert.Equal("The server could not comply with the request since it is either malformed or otherwise incorrect. The content type is None. Try use \"application/json\" instead.", ex.ErrorMessage);
            }
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void XmlPutTypeTest()
        {
            UpdateStackRequest request = new UpdateStackRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.XML;
            request.BodyParameters.Add("ContentMD5NotMatched", "test");

            try
            {
                this.client.GetAcsResponse(request);
            }
            catch (ClientException ex)
            {
                Assert.Equal("HTTPBadRequest", ex.ErrorCode);
                Assert.Equal("The server could not comply with the request since it is either malformed or otherwise incorrect. The content type is None. Try use \"application/json\" instead.", ex.ErrorMessage);
            }
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void FormPutTypeTest()
        {
            UpdateStackRequest request = new UpdateStackRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.FORM;
            request.BodyParameters.Add("ContentMD5NotMatched", "test");

            try
            {
                this.client.GetAcsResponse(request);
            }
            catch (ClientException ex)
            {
                Assert.Equal("HTTPBadRequest", ex.ErrorCode);
                Assert.Equal("The server could not comply with the request since it is either malformed or otherwise incorrect. The content type is None. Try use \"application/json\" instead.", ex.ErrorMessage);
            }
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void JsonPostTypeTest()
        {
            DoActionsRequest request = new DoActionsRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.JSON;
            request.BodyParameters.Add("test", "test");

            try
            {
                this.client.GetAcsResponse(request);
            }
            catch (ClientException ex)
            {
                Assert.Equal("HTTPBadRequest", ex.ErrorCode);
                Assert.Equal("No action specified", ex.ErrorMessage);
            }
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void XmlPostTypeTest()
        {
            DoActionsRequest request = new DoActionsRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.XML;
            request.BodyParameters.Add("test", "test");
            request.BodyParameters.Add("test2", "test2");

            try
            {
                this.client.GetAcsResponse(request);
            }
            catch (ClientException ex)
            {
                Assert.Equal("HTTPBadRequest", ex.ErrorCode);
                Assert.Equal("No action specified", ex.ErrorMessage);
            }
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void FormPostTypeTest()
        {
            DoActionsRequest request = new DoActionsRequest();
            request.StackName = "test";
            request.StackId = "test";
            request.ContentType = FormatType.FORM;
            request.BodyParameters.Add("test", "test");

            try
            {
                this.client.GetAcsResponse(request);
            }
            catch (ClientException ex)
            {
                Assert.Equal("HTTPBadRequest", ex.ErrorCode);
                Assert.Equal("No action specified", ex.ErrorMessage);
            }
        }
    }
}
