using System;

using Aliyun.Acs.Core.Auth;
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
    }
}
