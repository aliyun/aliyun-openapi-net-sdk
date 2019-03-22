using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Ecs.Model.V20140526;
using Aliyun.Acs.Ram.Model.V20150501;

using Xunit;

namespace Aliyun.Acs.Feature.Test.EndPoint
{
    [Trait("Category", "FeatureTest")]
    public class EndPointTest : FeatureTestBase
    {
        [Fact]
        public void TestProductsWithLocationService()
        {
            var request = new DescribeRegionsRequest();
            DescribeRegionsResponse response = client.GetAcsResponse(request);

            Assert.True(0 < response.Regions.Count);
        }

        [Fact]
        public void TestProductsWithoutLocationService()
        {
            var request = new ListAccessKeysRequest();
            var response = client.GetAcsResponse(request);

            Assert.True(0 < response.AccessKeys.Count);
        }

        [Fact]
        public void TestAddNewEndPointManually()
        {
            var profile = DefaultProfile.GetProfile("cn-wenzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            var testClient = new Acs.Core.DefaultAcsClient(profile);

            DescribeRegionsRequest request = new DescribeRegionsRequest();

            var exceptionMsg = Assert.Throws<ClientException>(() =>
            {
                var response = testClient.GetAcsResponse(request);
            });

            Assert.Equal("Can not find endpoint to access.", exceptionMsg.ErrorMessage);

            DefaultProfile.AddEndpoint("cn-wenzhou", "cn-wenzhou", "Ecs", "abc.cn-wenzhou.endpoint-test.exception.com");

            Assert.Throws<ClientException>(() =>
            {
                testClient.GetAcsResponse(request);

            });
        }

        [Fact]
        public void TestAddExistingEndpointManually()
        {
            DescribeRegionsRequest request = new DescribeRegionsRequest();
            var profile = DefaultProfile.GetProfile("cn-wenzhou", GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            var testClient = new Acs.Core.DefaultAcsClient(profile);

            DefaultProfile.AddEndpoint("cn-hangzhou", "cn-hangzhou", "Ecs", "abc.cn-hangzhou.endpoint-test.exception.com");

            Assert.Throws<ClientException>(() =>
            {
                testClient.GetAcsResponse(request);

            });
        }
    }
}
