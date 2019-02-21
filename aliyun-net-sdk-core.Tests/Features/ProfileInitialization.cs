using System;

using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Core.Tests.Mock;

namespace Aliyun.Acs.Core.Tests.Feature
{
    public class ProfileInitialization
    {
        //To-Do Move ProfileInitialization to AccessCredentialTest
        private string regionId = "cn-shanghai";
        private string accessKey;
        private string accessKeySecret;

        private IClientProfile profile;

        public DefaultAcsClient client;

        public ProfileInitialization()
        {
            accessKey = ACKMock.GetAccessKeyId();
            accessKeySecret = ACKMock.GetAccessKeySecret();

            profile = DefaultProfile.GetProfile(regionId, accessKey, accessKeySecret);
            client = new DefaultAcsClient(profile);
        }
    }
}
