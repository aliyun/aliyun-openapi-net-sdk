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

using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;

using Moq;

using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Aliyun.Acs.Core.Tests.Units.Profile
{
    public class DefaultProfileTest
    {
        [Fact]
        public void AddEndpoint()
        {
            DefaultProfile.ClearDefaultProfile();

            var endpointName = "AddEndpoint.someString";
            var regionId = "AddEndpoint.someString";
            var productName = "product_name";
            var productDomain = "product_domain";
            List<Endpoint> endpoints;
            List<ProductDomain> products;
            var profile = DefaultProfile.GetProfile();
            profile = DefaultProfile.GetProfile();

            // Add endpoint
            DefaultProfile.AddEndpoint(endpointName, regionId, productName, productDomain, false);
            endpoints = profile.GetEndpoints(regionId, productName);
            Assert.NotNull(endpoints);
            foreach (var endpoint in endpoints)
            {
                Assert.Equal(endpointName, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (var product in products)
                {
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomianName);
                }
            }

            DefaultProfile.ClearDefaultProfile();
            DefaultProfile.AddEndpoint(endpointName, regionId, productName, productDomain);
            endpoints = profile.GetEndpoints(regionId, productName);
            Assert.NotNull(endpoints);
            foreach (var endpoint in endpoints)
            {
                Assert.Equal(endpointName, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (var product in products)
                {
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomianName);
                }
            }

            DefaultProfile.AddEndpoint(endpointName, regionId, productName, productDomain, true);
        }

        [Fact]
        public void Get()
        {
            DefaultProfile.ClearDefaultProfile();

            var regionId = "cn-hangzhou";
            var accessKeyId = "accessKeyId";
            var accessKeysecret = "accessKeysecret";
            var profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeysecret);

            Assert.Equal(regionId, profile.GetRegionId());
            Assert.Equal(FormatType.XML, profile.GetFormat());

            Assert.IsType<Credential>(profile.GetCredential());
        }

        [Fact]
        public void GetEndpoints1()
        {
            DefaultProfile.ClearDefaultProfile();

            var regionId = "GetEndpoints.someString";
            var productName = "ecs";
            var productDomain = "product_domain";
            List<Endpoint> endpoints;
            List<ProductDomain> products;
            var profile = DefaultProfile.GetProfile();

            profile = DefaultProfile.GetProfile();

            endpoints = profile.GetEndpoints(regionId, productName);

            productName = "product_name";
            endpoints = profile.GetEndpoints(regionId, productName);
            foreach (var endpoint in endpoints)
            {
                Assert.Equal(regionId, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (var product in products)
                {
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomianName);
                }
            }
        }

        [Fact]
        public void GetEndpoints2()
        {
            DefaultProfile.ClearDefaultProfile();

            // When product = null

            var profile = DefaultProfile.GetProfile();

            var endpoints1 = profile.GetEndpoints(null, null);

            var endpoints2 = profile.GetEndpoints(null, null, null, null);

            Assert.Equal(endpoints1, endpoints2);
        }

        [Fact]
        public void GetEndpoints3()
        {
            DefaultProfile.ClearDefaultProfile();

            // Mock RegionIds
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains
            var productDomains = new List<ProductDomain>();
            var productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint
            var endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            var mock = new Mock<DefaultProfile>(true);
            mock.Setup(foo => foo.GetEndpointByIEndpoints(
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);
            mock.Setup(foo => foo.GetEndpointByRemoteProvider(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);

            var profile = mock.Object;
            profile.GetEndpoints("product", "regionId", "serviceCode", "endpointType");
        }

        [Fact]
        public void GetEndpoints4()
        {
            DefaultProfile.ClearDefaultProfile();

            // Mock RegionIds	
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains	
            var productDomains = new List<ProductDomain>();
            var productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint	
            var endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            var mock = new Mock<DefaultProfile>(true);
            mock.Setup(foo => foo.GetEndpointByIEndpoints(
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);
            mock.Setup(foo => foo.GetEndpointByRemoteProvider(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);

            var profile = mock.Object;
            var endpoints = profile.GetEndpoints("cn-hangzhou", "Ess");

            profile.GetEndpoints("productNotExist", "regionId", "serviceCode", "endpointType");
        }

        [Fact]
        public void GetEndpoints5()
        {
            DefaultProfile.ClearDefaultProfile();

            Endpoint endpoint = null;

            var mock = new Mock<DefaultProfile>(true);
            mock.Setup(foo => foo.GetEndpointByIEndpoints(
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);
            mock.Setup(foo => foo.GetEndpointByRemoteProvider(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);

            var profile = mock.Object;
            var endpoints = profile.GetEndpoints("cn-hangzhou", "Ess");

            Assert.Throws<ClientException>(
                () => { profile.GetEndpoints("productNotExist", "regionId", "serviceCode", "endpointType"); }
            );
        }

        [Fact]
        public void GetEndpoints6()
        {
            DefaultProfile.ClearDefaultProfile();

            // Mock RegionIds	
            ISet<string> regionIds = new HashSet<string>();
            regionIds.Add("cn-hangzhou");

            // Mock productDomains	
            var productDomains = new List<ProductDomain>();
            var productDomain = new ProductDomain("Ess", "ess.aliyuncs.com");
            productDomains.Add(productDomain);

            // Mock endpoint	
            var endpoint = new Endpoint("cn-hangzhou", regionIds, productDomains);

            var mock1 = new Mock<DefaultProfile>(true);
            mock1.Setup(foo => foo.GetEndpointByIEndpoints(
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);
            mock1.Setup(foo => foo.GetEndpointByRemoteProvider(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);

            var profile = mock1.Object;
            // When Get endpoint is not null
            var endpoints1 = profile.GetEndpoints("cn-hangzhou", "Ess");
            Assert.NotNull(endpoints1);

            // When Get endpoint is null
            endpoint = null;
            mock1.Setup(foo => foo.GetEndpointByIEndpoints(
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);
            mock1.Setup(foo => foo.GetEndpointByRemoteProvider(
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>(),
                It.IsAny<string>()
            )).Returns(endpoint);

            profile = mock1.Object;

            var endpoints2 = profile.GetEndpoints("productNotExist", "regionId", "serviceCode", "endpointType");

            Assert.Equal(endpoints1, endpoints2);
        }

        [Fact]
        public void GetProfile()
        {
            DefaultProfile.ClearDefaultProfile();

            var profile = DefaultProfile.GetProfile();
            Assert.IsType<DefaultProfile>(profile);

            var regionId = "cn-hangzhou";
            profile = DefaultProfile.GetProfile(regionId);
            Assert.Equal(regionId, profile.GetRegionId());

            var accessKeyId = "accessKeyId";
            var accessKeysecret = "accessKeysecret";
            profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeysecret);
            Assert.Equal(accessKeyId, profile.GetCredential().AccessKeyId);

            var mockICredentialProvider = new Mock<ICredentialProvider>();
            var exception = new Exception();
            mockICredentialProvider.Setup(foo => foo.Fresh()).Throws(exception);
            var iCredentialProvider = mockICredentialProvider.Object;
            profile = DefaultProfile.GetProfile(regionId, iCredentialProvider);

            Assert.Throws<Exception>(
                () => { profile.GetCredential(); }
            );
        }

        [Fact]
        public void SetCredentialsProvider()
        {
            DefaultProfile.ClearDefaultProfile();
            Credential credential;
            var profile = DefaultProfile.GetProfile();
            var mock = new Mock<AlibabaCloudCredentialsProvider>();
            var provider = mock.Object;

            profile.SetCredentialsProvider(provider);
            credential = profile.GetCredential();
            Assert.NotNull(credential);
            Assert.IsType<CredentialsBackupCompatibilityAdaptor>(credential);

            profile.SetCredentialsProvider(null);
            credential = profile.GetCredential();
            Assert.NotNull(credential);
            Assert.IsType<CredentialsBackupCompatibilityAdaptor>(credential);
        }

        [Fact]
        public void SetLocationConfig()
        {
            DefaultProfile.ClearDefaultProfile();

            var regionId = "cn-hangzhou-1";
            var product = "ecs";
            var endpoint = "cn-hangzhou";

            var profile = DefaultProfile.GetProfile();
            profile.SetLocationConfig(regionId, product, endpoint);
        }
    }
}
