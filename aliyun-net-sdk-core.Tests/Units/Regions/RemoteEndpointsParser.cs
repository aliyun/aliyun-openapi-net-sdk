using System;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;
using Aliyun.Acs.Core.Regions.Location.Model;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class RemoteEndpointsParserTest
    {
        [Fact]
        public void GetEndpoint()
        {
            RemoteEndpointsParser instance = new RemoteEndpointsParser();

            Assert.Throws<NotSupportedException>(
                () =>
                {
                    instance.GetEndpoint("", "");
                }
            );
        }

        [Fact]
        public void GetEndpointWhenServiceCodeIsNull()
        {
            RemoteEndpointsParser instance = new RemoteEndpointsParser();
            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();
            var result = instance.GetEndpoint("regionId", "product", null, "endpointType", credential, locationConfig);
            Assert.Null(result);
        }

        [Fact]
        public void GetEndpointWhenResponseIsNull()
        {
            DescribeEndpointResponse response = null;

            var mock = new Mock<DescribeEndpointService>();
            //String regionId, String serviceCode, String endpointType,Credential credential,LocationConfig locationConfig
            mock.Setup(foo => foo.DescribeEndpoint(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<Credential>(),
                It.IsAny<LocationConfig>()
            )).Returns(response);

            DescribeEndpointService describeEndpointService = mock.Object;
            RemoteEndpointsParser instance = new RemoteEndpointsParser();
            instance.SetDescribeEndpointService(describeEndpointService);

            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();
            var result = instance.GetEndpoint("regionId", "product", "serviceCode", "endpointType", credential, locationConfig);
            Assert.Null(result);
        }

        [Fact]
        public void GetEndpointWhenResponseIsNotNull()
        {
            DescribeEndpointResponse response = new DescribeEndpointResponse();
            response.RegionId = "RegionId";
            response.Endpoint = "Endpoint";

            var mock = new Mock<DescribeEndpointService>();

            mock.Setup(foo => foo.DescribeEndpoint(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<Credential>(),
                It.IsAny<LocationConfig>()
            )).Returns(response);

            DescribeEndpointService describeEndpointService = mock.Object;
            RemoteEndpointsParser instance = new RemoteEndpointsParser();
            instance.SetDescribeEndpointService(describeEndpointService);

            Credential credential = new Credential();
            LocationConfig locationConfig = new LocationConfig();
            var result = instance.GetEndpoint("regionId", "product", "serviceCode", "endpointType", credential, locationConfig);
            Assert.IsType<Endpoint>(result);
            Assert.NotNull(result);
            Assert.Equal("RegionId", result.Name);
            Assert.NotEmpty(result.ProductDomains);
            Assert.NotEmpty(result.RegionIds);
        }
    }
}
