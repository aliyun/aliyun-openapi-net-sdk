using System;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Ecs.Model.V20140526;

using Xunit;

namespace Aliyun.Acs.Feature.Test.Core
{
    public class CoreTest : FeatureTestBase
    {

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void BasicRpcConnectionsTest()
        {
            CommonRequest request = new CommonRequest();
            request.Domain = "ecs-cn-hangzhou.aliyuncs.com";
            request.Version = "2014-05-26";
            request.Action = "DescribeAccessPoints";

            CommonResponse response = client.GetCommonResponse(request);

            Assert.Equal("200", response.HttpStatus.ToString());
            Assert.NotNull(response.Data);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void BasicRoaConnectionsTest()
        {
            CommonRequest request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;

            CommonResponse response = client.GetCommonResponse(request);

            Assert.Equal("200", response.HttpStatus.ToString());
            Assert.NotNull(response.Data);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void BasicRpcStsTokenConnectionsTest()
        {
            if (base.GetRoleArn().Equals("FakeRoleArn"))
                return;

            BasicSessionCredentials basciCredential = new BasicSessionCredentials(this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret(), this.GetToken());
            DefaultProfile profile = DefaultProfile.GetProfile(this.regionId, this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret());
            DefaultAcsClient client = new DefaultAcsClient(profile, basciCredential);

            DescribeInstancesRequest request = new DescribeInstancesRequest();
            DescribeInstancesResponse response = client.GetAcsResponse(request);

            Assert.NotNull(response);
            Assert.True(0 <= response.TotalCount);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void BasicRoaTokenConnection()
        {
            if (base.GetRoleArn().Equals("FakeRoleArn"))
                return;

            BasicSessionCredentials basciCredential = new BasicSessionCredentials(this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret(), this.GetToken());
            DefaultProfile profile = DefaultProfile.GetProfile(this.regionId, this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret());
            DefaultAcsClient client = new DefaultAcsClient(profile, basciCredential);

            CommonRequest request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;

            CommonResponse response = client.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void HttpsModeOfRpcConnectionTest()
        {
            CommonRequest request = new CommonRequest();
            request.Domain = "ecs-cn-hangzhou.aliyuncs.com";
            request.Version = "2014-05-26";
            request.Action = "DescribeAccessPoints";
            request.Protocol = ProtocolType.HTTPS;

            CommonResponse response = client.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void HttpsModeOfRoaConnectionTest()
        {
            CommonRequest request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;
            request.Protocol = ProtocolType.HTTPS;

            CommonResponse response = client.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }

        [Trait("Category", "FeatureTest")]
        [Fact]
        public void UnicodeAndQueryTest()
        {
            if (base.GetRoleArn().Equals("FakeRoleArn"))
                return;

            BasicSessionCredentials basciCredential = new BasicSessionCredentials(this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret(), this.GetToken());
            DefaultProfile profile = DefaultProfile.GetProfile(this.regionId, this.GetBasicAccessKeyId(), this.GetBasicAccessKeySecret());
            DefaultAcsClient client = new DefaultAcsClient(profile, basciCredential);

            CommonRequest request = new CommonRequest();
            request.Domain = "ros.aliyuncs.com";
            request.Version = "2015-09-01";
            request.Action = "DescribeResourceTypes";
            request.UriPattern = "/resource_types";
            request.Method = MethodType.GET;
            request.QueryParameters.Add("testParams", "SDFSDFSAetTEWTEWQO(∩_∩)O哈哈~");

            CommonResponse response = client.GetCommonResponse(request);
            Assert.Equal(200, response.HttpStatus);
            Assert.NotNull(response.Data);
        }
    }
}
