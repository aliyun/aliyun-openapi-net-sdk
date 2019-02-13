using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Location;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions
{
    public class InternalEndpointsParserTest
    {
        [Fact]
        public void GetEndpoint1()
        {
            // Not Supported Action
            InternalEndpointsParser instance = new InternalEndpointsParser();

            Assert.Throws<NotSupportedException>(
                () =>
                {
                    Credential credential = new Credential();
                    LocationConfig locationConfig = new LocationConfig();
                    instance.GetEndpoint("", "", "", "", credential, locationConfig);
                }
            );
        }

        [Fact]
        public void GetEndpoint2()
        {
            // When Product List is empty

            // Mock Product List
            List<InternalEndpointsParser.Product> productList = new List<InternalEndpointsParser.Product>() { };

            // Mock InternalEndpointsParser
            var mockInstance = new Mock<InternalEndpointsParser>();
            mockInstance.Setup(foo => foo.GetProducts()).Returns(productList);
            InternalEndpointsParser instance = mockInstance.Object;

            var result = instance.GetEndpoint("regionIdKey", "ProductCode");
            Assert.Equal("regionIdKey", result.Name);
            Assert.Empty(result.ProductDomains);
            Assert.Empty(result.RegionIds);
        }

        [Fact]
        public void GetEndpoint3()
        {
            // When 
            // Product List is not empty
            // p.Code is not exist

            // Mock Product
            InternalEndpointsParser.Product product = new InternalEndpointsParser.Product();
            product.Code = "ProductCode";
            product.LocationServiceCode = "LocationServiceCode";
            product.DocumentId = "DocumentId";
            product.RegionalEndpoints = new Dictionary<string, string>() { };
            product.GlobalEndpoint = "GlobalEndpoint";
            product.RegionalEndpointPattern = "RegionalEndpointPattern";

            // Mock Product List
            List<InternalEndpointsParser.Product> productList = new List<InternalEndpointsParser.Product>() { };

            // Mock InternalEndpointsParser
            var mockInstance = new Mock<InternalEndpointsParser>();
            mockInstance.Setup(foo => foo.GetProducts()).Returns(productList);
            InternalEndpointsParser instance = mockInstance.Object;

            var result = instance.GetEndpoint("regionIdKey", "ProductCodeNotExist");
            Assert.Equal("regionIdKey", result.Name);
            Assert.Empty(result.ProductDomains);
            Assert.Empty(result.RegionIds);
        }

        [Fact]
        public void GetEndpoint4()
        {
            // When Product List is not empty
            // p.Code is exist

            // Mock Product
            // regionKey is not exist
            // regionSet is empty
            // GlobalEndpoint is empty
            InternalEndpointsParser.Product product = new InternalEndpointsParser.Product();
            product.Code = "ProductCode";
            product.LocationServiceCode = "LocationServiceCode";
            product.DocumentId = "DocumentId";
            product.RegionalEndpoints = new Dictionary<string, string>() { };
            product.GlobalEndpoint = "";
            product.RegionalEndpointPattern = "RegionalEndpointPattern";

            // Mock Product List
            List<InternalEndpointsParser.Product> productList = new List<InternalEndpointsParser.Product>() { };

            productList.Add(product);

            // Mock InternalEndpointsParser
            var mockInstance = new Mock<InternalEndpointsParser>();
            mockInstance.Setup(foo => foo.GetProducts()).Returns(productList);
            InternalEndpointsParser instance = mockInstance.Object;

            var result = instance.GetEndpoint("regionKey", "ProductCode");
            Assert.Null(result);
        }

        [Fact]
        public void GetEndpoint5()
        {
            // When Product List is not empty
            // p.Code is exist

            // Mock Product
            // regionKey is not exist
            // regionSet is empty
            // GlobalEndpoint is not empty
            InternalEndpointsParser.Product product = new InternalEndpointsParser.Product();
            product.Code = "ProductCode";
            product.LocationServiceCode = "LocationServiceCode";
            product.DocumentId = "DocumentId";
            product.RegionalEndpoints = new Dictionary<string, string>() { };
            product.RegionalEndpoints.Add("regionKeyNotExist", "regionValue");
            product.GlobalEndpoint = "GlobalEndpoint";
            product.RegionalEndpointPattern = "RegionalEndpointPattern";

            // Mock Product List
            List<InternalEndpointsParser.Product> productList = new List<InternalEndpointsParser.Product>() { };

            productList.Add(product);

            // Mock InternalEndpointsParser
            var mockInstance = new Mock<InternalEndpointsParser>();
            mockInstance.Setup(foo => foo.GetProducts()).Returns(productList);
            InternalEndpointsParser instance = mockInstance.Object;

            var result = instance.GetEndpoint("regionKey", "ProductCode");
            Assert.Equal("regionKey", result.Name);
            Assert.NotEmpty(result.ProductDomains);
            Assert.NotEmpty(result.RegionIds);
        }

        [Fact]
        public void GetEndpoint6()
        {
            // When Product List is not empty
            // p.Code is exist

            // Mock Product3
            // regionKey is exist
            // regionSet is not empty
            InternalEndpointsParser.Product product = new InternalEndpointsParser.Product();
            product.Code = "ProductCode";
            product.LocationServiceCode = "LocationServiceCode";
            product.DocumentId = "DocumentId";
            product.RegionalEndpoints = new Dictionary<string, string>() { };
            product.RegionalEndpoints.Add("regionKey", "regionValue");
            product.GlobalEndpoint = "GlobalEndpoint";
            product.RegionalEndpointPattern = "RegionalEndpointPattern";

            // Mock Product List
            List<InternalEndpointsParser.Product> productList = new List<InternalEndpointsParser.Product>() { };

            productList.Add(product);

            // Mock InternalEndpointsParser
            var mockInstance = new Mock<InternalEndpointsParser>();
            mockInstance.Setup(foo => foo.GetProducts()).Returns(productList);
            InternalEndpointsParser instance = mockInstance.Object;

            var result = instance.GetEndpoint("regionKey", "ProductCode");
            Assert.Equal("regionKey", result.Name);
            Assert.NotEmpty(result.ProductDomains);
            Assert.NotEmpty(result.RegionIds);
        }
    }
}
