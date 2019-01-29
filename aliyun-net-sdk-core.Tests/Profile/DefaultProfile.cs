using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Regions;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Profile
{
    public class DefaultProfileTest
    {
        [Fact]
        public void GetProfile()
        {
            DefaultProfile.ClearDefaultProfile();

            // DefaultProfile 提供了7种private 实例化方式
            // 但是GetProfile只实现了4个，其它3个无法覆盖
            DefaultProfile profile = DefaultProfile.GetProfile();
            Assert.IsType<DefaultProfile>(profile);

            string regionId = "cn-hangzhou";
            profile = DefaultProfile.GetProfile(regionId);
            Assert.Equal(regionId, profile.GetRegionId());

            string accessKeyId = "accessKeyId";
            string accessKeysecret = "accessKeysecret";
            profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeysecret);
            Assert.Equal(accessKeyId, profile.GetCredential().AccessKeyId);

            var mockICredentialProvider = new Mock<ICredentialProvider>();
            Exception exception = new Exception();
            mockICredentialProvider.Setup(foo => foo.Fresh()).Throws(exception);
            ICredentialProvider iCredentialProvider = mockICredentialProvider.Object;
            profile = DefaultProfile.GetProfile(regionId, iCredentialProvider);
            // 有异常抛出,说明执行了Fresh方法
            Assert.Throws<Exception>(
                () =>
                {
                    profile.GetCredential();
                }
            );
        }

        [Fact]
        public void Get()
        {
            DefaultProfile.ClearDefaultProfile();

            string regionId = "cn-hangzhou";
            string accessKeyId = "accessKeyId";
            string accessKeysecret = "accessKeysecret";
            DefaultProfile profile = DefaultProfile.GetProfile(regionId, accessKeyId, accessKeysecret);

            Assert.Equal(regionId, profile.GetRegionId());
            Assert.Equal(FormatType.XML, profile.GetFormat());

            Assert.IsType<Credential>(profile.GetCredential());
        }

        [Fact]
        public void SetLocationConfig()
        {
            DefaultProfile.ClearDefaultProfile();

            string regionId = "cn-hangzhou-1";
            string product = "ecs";
            string endpoint = "cn-hangzhou";

            DefaultProfile profile = DefaultProfile.GetProfile();
            profile.SetLocationConfig(regionId, product, endpoint);
            // locationConfig 为私有成员 无法获取

            // Done With No Exception
        }

        [Fact]
        public void GetEndpoints()
        {
            DefaultProfile.ClearDefaultProfile();

            // Console.WriteLine("------GetEndpoints-------");
            string regionId = "GetEndpoints.someString";
            string productName = "ecs";
            string productDomain = "product_domain";
            List<Endpoint> endpoints;
            List<ProductDomain> products;
            DefaultProfile profile = DefaultProfile.GetProfile();

            profile = DefaultProfile.GetProfile();

            // 未添加endpoint前，无endpoints节点
            // 使用已存在的阿里云的 productName (如ecs) , 不会初始化endpoints , endpoints为null
            endpoints = profile.GetEndpoints(regionId, productName);
            // Assert.Null(endpoints);

            // 使用不存在的名称 , endpoints 会初始化, 会添加进endpoints节点
            // 但是会把regionId作为endpoint.Name
            productName = "product_name";
            endpoints = profile.GetEndpoints(regionId, productName);
            // Assert.NotNull(endpoints);
            foreach (Endpoint endpoint in endpoints)
            {
                // Console.WriteLine(endpoint.Name);
                Assert.Equal(regionId, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (ProductDomain product in products)
                {
                    // Console.WriteLine(product.ProductName + "   " + product.DomianName);
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomianName);
                }
            }
        }

        [Fact]
        public void AddEndpoint()
        {
            DefaultProfile.ClearDefaultProfile();

            // Console.WriteLine("-------AddEndpoint------");
            string endpointName = "AddEndpoint.someString";
            string regionId = "AddEndpoint.someString";
            string productName = "product_name";
            string productDomain = "product_domain";
            List<Endpoint> endpoints;
            List<ProductDomain> products;
            DefaultProfile profile = DefaultProfile.GetProfile();
            profile = DefaultProfile.GetProfile();

            // 添加endpoint节点
            DefaultProfile.AddEndpoint(endpointName, regionId, productName, productDomain, false);
            endpoints = profile.GetEndpoints(regionId, productName);
            Assert.NotNull(endpoints);
            foreach (Endpoint endpoint in endpoints)
            {
                // Console.WriteLine(endpoint.Name);
                Assert.Equal(endpointName, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (ProductDomain product in products)
                {
                    // Console.WriteLine(product.ProductName + "   " + product.DomianName);
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomianName);
                }
            }

            DefaultProfile.ClearDefaultProfile();
            DefaultProfile.AddEndpoint(endpointName, regionId, productName, productDomain); // 多条件覆盖
            endpoints = profile.GetEndpoints(regionId, productName);
            Assert.NotNull(endpoints);
            foreach (Endpoint endpoint in endpoints)
            {
                Assert.Equal(endpointName, endpoint.Name);
                products = endpoint.ProductDomains;
                foreach (ProductDomain product in products)
                {
                    Assert.Equal(productName, product.ProductName);
                    Assert.Equal(productDomain, product.DomianName);
                }
            }
            DefaultProfile.AddEndpoint(endpointName, regionId, productName, productDomain, true);
        }

        [Fact]
        public void SetCredentialsProvider()
        {
            DefaultProfile.ClearDefaultProfile();
            Credential credential;
            DefaultProfile profile = DefaultProfile.GetProfile();
            var mock = new Mock<AlibabaCloudCredentialsProvider>();
            AlibabaCloudCredentialsProvider provider = mock.Object;

            profile.SetCredentialsProvider(provider); // 不为null时，直接回调，即此操作无效
            credential = profile.GetCredential(); // 会执行credential初始化
            Assert.NotNull(credential);
            Assert.IsType<CredentialsBackupCompatibilityAdaptor>(credential);

            profile.SetCredentialsProvider(null); // 会执行credential初始化
            credential = profile.GetCredential(); // 不会执行credential初始化
            Assert.NotNull(credential);
            Assert.IsType<CredentialsBackupCompatibilityAdaptor>(credential);
        }
    }
}
