using Aliyun.Acs.Core.Regions.Location;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions.Location
{
    public class LocationConfigTest
    {
        [Fact]
        public void createLocationConfig()
        {
            LocationConfig instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            Assert.IsType<LocationConfig>(instance);
            Assert.Equal("RegionId", instance.RegionId);
            Assert.Equal("Product", instance.Product);
            Assert.Equal("Endpoint", instance.Endpoint);
        }

        [Fact]
        public void RegionId()
        {
            LocationConfig instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            instance.RegionId = "setRegionId";
            Assert.Equal("setRegionId", instance.RegionId);
        }

        [Fact]
        public void Product()
        {
            LocationConfig instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            instance.Product = "setProduct";
            Assert.Equal("setProduct", instance.Product);
        }

        [Fact]
        public void Endpoint()
        {
            LocationConfig instance = LocationConfig.createLocationConfig("RegionId", "Product", "Endpoint");
            instance.Endpoint = "setEndpoint";
            Assert.Equal("setEndpoint", instance.Endpoint);
        }
    }
}
