using System;

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public class RamRoleArnCredential : BasicSessionCredentials
    {
        private readonly string roleArn;
        private string roleSessionName;

        public RamRoleArnCredential(
            string accessKeyId,
            string accessKeySecret,
            string roleArn,
            string roleSessionName,
            string sessionToken,
            long roleSessionDurationSeconds) : base(accessKeyId, accessKeySecret, sessionToken, roleSessionDurationSeconds)
        {
            this.roleArn = roleArn;
            this.roleSessionName = roleSessionName;
        }

        public string GetRoleArn()
        {
            return this.roleArn;
        }

        public string GetRoleSessionName()
        {
            return this.roleSessionName;
        }
    }
}
