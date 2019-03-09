using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Utils;

namespace Aliyun.Acs.Core.Auth
{
    public class EcsRamRoleCredential : BasicSessionCredentials
    {
        private readonly long expiration;
        private readonly double expireFact = 0.9;
        private readonly long refreshIntervalInMillSeconds = 10000; // 10 sec
        private long lastFailedRefreshTime = 0;

        public EcsRamRoleCredential(
            string accessKeyId,
            string accessKeySecret,
            string sessionToken,
            string expiration,
            long roleSessionDurationSeconds) : base(accessKeyId, accessKeySecret, sessionToken, roleSessionDurationSeconds)
        {
            expiration = expiration.Replace('T', ' ').Replace('Z', ' ');
            DateTime dt = Convert.ToDateTime(expiration);

            this.expiration = dt.Ticks;
        }

        public override bool WillSoonExpire()
        {
            return this.roleSessionDurationSeconds * (1 - expireFact) > this.RemainTicks() / 1000;
        }

        public bool IsExpired()
        {
            return refreshIntervalInMillSeconds >= this.RemainTicks();
        }

        public bool ShouldRefresh()
        {
            long now = DateTime.Now.Ticks;
            if (now - lastFailedRefreshTime > refreshIntervalInMillSeconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetLastFailedRefreshTime()
        {
            lastFailedRefreshTime = DateTime.Now.Ticks;
        }

        public virtual long RemainTicks()
        {
            return expiration - DateTime.Now.Ticks;
        }
    }
}
