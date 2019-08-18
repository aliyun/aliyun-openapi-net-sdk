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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Profile
{
    public class DefaultProfileTest
    {
        [Fact]
        public void AddEndpoint()
        {
            var endpointName = "AddEndpoint.someString";
            var regionId = "AddEndpoint.someString";
            var productName = "product_name";
            var productDomain = "product_domain";
            List<Endpoint> endpoints;
            List<ProductDomain> products;
            DefaultProfile.ClearProfile();
            var profile = DefaultProfile.GetProfile();

            // Add endpoint
            profile.AddEndpoint(endpointName, regionId, productName, productDomain);
            endpoints = profile.GetEndpoints(regionId, productName);
            Assert.NotNull(endpoints);
            foreach (var endpoint in endpoints)
            {
                Assert.Equal(endpointName, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (var product in products)
                {
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomainName);
                }
            }

            profile.AddEndpoint(endpointName, regionId, productName, productDomain);
            endpoints = profile.GetEndpoints(regionId, productName);
            Assert.NotNull(endpoints);
            foreach (var endpoint in endpoints)
            {
                Assert.Equal(endpointName, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (var product in products)
                {
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomainName);
                }
            }
        }

        [Fact]
        public void Get()
        {
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
                    Assert.Equal(productDomain, product.DomainName);
                }
            }
        }

        [Fact]
        public void GetEndpoints2()
        {
            // When product = null
            var profile = DefaultProfile.GetProfile();

            var endpoints1 = profile.GetEndpoints(null, null);

            var endpoints2 = profile.GetEndpoints(null, null, null, null);

            Assert.Equal(endpoints1, endpoints2);
        }

        [Fact]
        public void GetProfile()
        {
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

            Assert.NotNull(profile);
        }

        [Fact]
        public void SetCredentialsProvider()
        {
            Credential credential;
            var profile = DefaultProfile.GetProfile();
            var provider = new AccessKeyCredentialProvider("TestAK", "TestAKS");

            profile.SetCredentialsProvider(provider);
            credential = profile.GetCredential();
            Assert.NotNull(credential);
            Assert.IsType<Credential>(credential);

            profile.SetCredentialsProvider(null);
            credential = profile.GetCredential();
            Assert.NotNull(credential);
            Assert.IsType<Credential>(credential);
        }

        [Fact]
        public void SetLocationConfig()
        {
            var regionId = "cn-hangzhou-1";
            var product = "ecs";
            var endpoint = "cn-hangzhou";

            var profile = DefaultProfile.GetProfile();
            profile.SetLocationConfig(regionId, product, endpoint);
        }
    }
}
