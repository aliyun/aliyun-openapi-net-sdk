using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Regions
{
    public class EndpointTest
    {
        [Fact]
        public void Instance()
        {
            Endpoint endpoint = new Endpoint("endpointName", null, null);
            Assert.Equal("endpointName", endpoint.Name);
            Assert.Null(endpoint.RegionIds);
            Assert.Null(endpoint.ProductDomains);
        }

        [Fact]
        public void FindProductDomain1()
        {
            // endpoints is null
            List<Endpoint> endpoints = null;
            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain2()
        {
            // endpoints is not null , but empty
            List<Endpoint> endpoints = new List<Endpoint> { };
            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain3()
        {
            // endpoints is not null and not empty
            // regionIds is empty
            // productDomains is null
            List<Endpoint> endpoints = new List<Endpoint> { };
            ISet<String> regionIds = new HashSet<String>();
            Endpoint endpoint = new Endpoint("endpointName", regionIds, null);
            endpoints.Add(endpoint);
            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain4()
        {
            // endpoints is not null and not empty
            // regionIds is not empty
            // productDomains is null
            List<Endpoint> endpoints = new List<Endpoint> { };
            ISet<String> regionIds = new HashSet<String>();
            regionIds.Add("regionId");

            List<ProductDomain> productDomains = null;

            Endpoint endpoint = new Endpoint("endpointName", regionIds, productDomains);
            endpoints.Add(endpoint);

            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain5()
        {
            // endpoints is not null and not empty
            // regionIds is not empty
            // productDomains is not null but empty
            List<Endpoint> endpoints = new List<Endpoint> { };
            ISet<String> regionIds = new HashSet<String>();
            regionIds.Add("regionId");

            List<ProductDomain> productDomains = new List<ProductDomain>() { };

            Endpoint endpoint = new Endpoint("endpointName", regionIds, productDomains);
            endpoints.Add(endpoint);

            var result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.Null(result);
        }

        [Fact]
        public void FindProductDomain6()
        {
            // endpoints is not null and not empty
            // regionIds is not empty
            // productDomains is not empty
            List<Endpoint> endpoints = new List<Endpoint> { };
            ISet<String> regionIds = new HashSet<String>();
            regionIds.Add("regionId");

            List<ProductDomain> productDomains = new List<ProductDomain>() { };
            ProductDomain productDomain = new ProductDomain("productName", "productDomain");
            productDomains.Add(productDomain);

            Endpoint endpoint = new Endpoint("endpointName", regionIds, productDomains);
            endpoints.Add(endpoint);

            // productName id not exist
            var result = Endpoint.FindProductDomain("regionId", "notExistProductName", endpoints);
            Assert.Null(result);

            // productName id exist
            result = Endpoint.FindProductDomain("regionId", "productName", endpoints);
            Assert.NotNull(result);
            Assert.Equal("productDomain", result.DomianName);
        }
    }
}
