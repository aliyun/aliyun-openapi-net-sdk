using System;

using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public class StsCredential : AlibabaCloudCredentials
    {
        public DateTime RefreshDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string AccessKeyId { get; set; }
        public string AccessSecret { get; set; }
        public string SecurityToken { get; set; }

        public StsCredential()
        {
            this.RefreshDate = DateTime.Now;
        }

        public StsCredential(string keyId, string secret)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.RefreshDate = DateTime.Now;
        }

        public StsCredential(string keyId, string secret, string securityToken)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.SecurityToken = securityToken;
            this.RefreshDate = new DateTime();
        }

        public StsCredential(string keyId, string secret, int expiredHours)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.RefreshDate = new DateTime();

            SetExpiredDate(expiredHours);
        }

        public StsCredential(string keyId, string secret, string securityToken, int expiredHours)
        {
            this.AccessKeyId = keyId;
            this.AccessSecret = secret;
            this.SecurityToken = securityToken;
            this.RefreshDate = new DateTime();

            SetExpiredDate(expiredHours);
        }

        private void SetExpiredDate(int expiredHours)
        {
            if (expiredHours > 0)
            {
                ExpiredDate = DateTime.Now.AddHours(expiredHours);
            }
        }

        public bool IsExpired()
        {
            if (this.ExpiredDate == null)
            {
                return false;
            }
            if (this.ExpiredDate < DateTime.Now)
            {
                return false;
            }
            return true;
        }

        public string GetAccessKeyId()
        {
            return this.AccessKeyId;
        }

        public string GetAccessKeySecret()
        {
            return this.AccessSecret;
        }
    }
}
