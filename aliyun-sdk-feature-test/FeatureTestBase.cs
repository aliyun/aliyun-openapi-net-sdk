using System;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;

namespace Aliyun.Acs.Feature.Test
{
    public class FeatureTestBase
    {
        private static string regionId = "cn-shanghai";
        private static readonly string AccessKeyId = "ACCESS_KEY_ID";
        private static readonly string AccessKeySecret = "ACCESS_KEY_SECRET";

        private string accessKey;
        private string accessKeySecret;

        private IClientProfile profile;
        public DefaultAcsClient client;

        public FeatureTestBase()
        {
            accessKey = GetAccessKeyId();
            accessKeySecret = GetAccessKeySecret();

            profile = DefaultProfile.GetProfile(regionId, accessKey, accessKeySecret);
            client = new DefaultAcsClient(profile);
        }

        private string GetAccessKeyId()
        {
            return Environment.GetEnvironmentVariable(AccessKeyId) ?? "FakeAccessKeyId";
        }

        private string GetAccessKeySecret()
        {
            return Environment.GetEnvironmentVariable(AccessKeySecret) ?? "FakeAccessKeySecret";
        }
    }
}
