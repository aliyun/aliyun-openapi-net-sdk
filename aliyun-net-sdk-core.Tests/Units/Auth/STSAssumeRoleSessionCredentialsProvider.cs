using System;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

using Moq;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth
{
    public class STSAssumeRoleSessionCredentialsProviderTest
    {
        [Fact]
        public void Instance()
        {
            DefaultProfile.ClearDefaultProfile();
            var mock = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials longLivedCredentials = mock.Object;
            string roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");

            STSAssumeRoleSessionCredentialsProvider instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            Assert.NotNull(instance);
        }

        [Fact]
        public void InstanceProvider()
        {
            DefaultProfile.ClearDefaultProfile();
            var mock = new Mock<AlibabaCloudCredentialsProvider>();
            AlibabaCloudCredentialsProvider longLivedCredentialsProvider = mock.Object;
            string roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");

            STSAssumeRoleSessionCredentialsProvider instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentialsProvider, roleArn, profile);

            Assert.NotNull(instance);
        }

        [Fact]
        public void WithRoleSessionName()
        {
            DefaultProfile.ClearDefaultProfile();
            var mock = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials longLivedCredentials = mock.Object;
            string roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            STSAssumeRoleSessionCredentialsProvider instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            instance.WithRoleSessionName("roleSessionName"); // 方法回调 STSAssumeRoleSessionCredentialsProvider 实例

            Assert.IsType<STSAssumeRoleSessionCredentialsProvider>(instance);
        }

        [Fact]
        public void WithRoleSessionDurationSecondss()
        {
            DefaultProfile.ClearDefaultProfile();
            var mock = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials longLivedCredentials = mock.Object;
            string roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            STSAssumeRoleSessionCredentialsProvider instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            long roleSessionDurationSeconds = 1000;

            // No Exception
            instance.WithRoleSessionDurationSeconds(roleSessionDurationSeconds);

            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    instance.WithRoleSessionDurationSeconds(100);
                }
            );
        }

        [Fact]
        public void WithSTSClient()
        {
            DefaultProfile.ClearDefaultProfile();
            var mock = new Mock<AlibabaCloudCredentials>();
            AlibabaCloudCredentials longLivedCredentials = mock.Object;
            string roleArn = "roleArn";
            IClientProfile profile = DefaultProfile.GetProfile("cn-shanghai", "accessKeyId", "accessKeySecret");
            STSAssumeRoleSessionCredentialsProvider instance = new STSAssumeRoleSessionCredentialsProvider(longLivedCredentials, roleArn, profile);

            var mockClient = new Mock<IAcsClient>();
            IAcsClient client = mockClient.Object;
            instance.WithSTSClient(client); // 方法回调 STSAssumeRoleSessionCredentialsProvider 实例

            Assert.IsType<STSAssumeRoleSessionCredentialsProvider>(instance);
        }

        [Fact]
        public void GetCredentials()
        {
            DefaultProfile.ClearDefaultProfile();

            var mock = new Mock<AlibabaCloudCredentials>();
            mock.Setup(foo => foo.GetAccessKeyId()).Returns("accessKeyId");
            mock.Setup(foo => foo.GetAccessKeySecret()).Returns("accessKeySecret");

            AlibabaCloudCredentials longLivedCredentials = mock.Object;

            IClientProfile profile = DefaultProfile.GetProfile(
                "cn-hangzhou",
                "accessKeyId",
                "accessKeySecret"
            );

            var mockInstance = new Mock<STSAssumeRoleSessionCredentialsProvider>(longLivedCredentials, "roleArn", profile);
            AssumeRoleResponse response = new AssumeRoleResponse();
            response.Credentials = new AssumeRoleResponse.AssumeRole_Credentials();
            response.Credentials.AccessKeyId = "MockAccessKeyId";
            response.Credentials.AccessKeySecret = "MockAccessKeyId";
            response.Credentials.SecurityToken = "MockSecurityToken";

            mockInstance.Setup(foo => foo.GetResponse(
                It.IsAny<AssumeRoleRequest>()
            )).Returns(response);
            STSAssumeRoleSessionCredentialsProvider instance = mockInstance.Object;

            var credentials = instance.GetCredentials(); // 执行credential初始化
            Assert.IsType<BasicSessionCredentials>(credentials);

            var credentials2 = instance.GetCredentials(); // 不执行credential初始化，直接获取
            Assert.IsType<BasicSessionCredentials>(credentials);
            Assert.Equal(credentials.GetAccessKeyId(), credentials2.GetAccessKeyId());
            Assert.Equal(credentials.GetAccessKeySecret(), credentials2.GetAccessKeySecret());
        }
    }
}
