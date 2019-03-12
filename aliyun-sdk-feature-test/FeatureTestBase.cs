using System;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Auth.Sts;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Feature.Test
{
    public class FeatureTestBase
    {
        public string regionId = "cn-shanghai";
        private static readonly string AccessKeyId = "ACCESS_KEY_ID";
        private static readonly string AccessKeySecret = "ACCESS_KEY_SECRET";
        private static readonly string roleArn = "RAM";

        private IClientProfile profile;
        public static DefaultAcsClient client;

        public FeatureTestBase()
        {
            profile = DefaultProfile.GetProfile(regionId, GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            client = new DefaultAcsClient(profile);
        }

        public string GetBasicAccessKeyId()
        {
            return Environment.GetEnvironmentVariable(AccessKeyId) ?? "FakeAccessKeyId";
        }

        public string GetBasicAccessKeySecret()
        {
            return Environment.GetEnvironmentVariable(AccessKeySecret) ?? "FakeAccessKeySecret";
        }

        public string GetRoleArn()
        {
            return Environment.GetEnvironmentVariable(roleArn) ?? "FakeRoleArn";
        }

        public string GetToken()
        {
            DefaultProfile profile = DefaultProfile.GetProfile(this.regionId, GetBasicAccessKeyId(), GetBasicAccessKeySecret());
            IAcsClient client = new DefaultAcsClient(profile);

            AssumeRoleRequest assumeRoleRequest = new AssumeRoleRequest();
            assumeRoleRequest.RoleArn = GetRoleArn();
            assumeRoleRequest.RoleSessionName = "robert_test";

            AssumeRoleResponse assumeRoleResponse = client.GetAcsResponse(assumeRoleRequest);

            return assumeRoleResponse.Credentials.SecurityToken;
        }
    }
}
