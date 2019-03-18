using System;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Auth.Credential
{
    public class AccessKeyCredential
    {
        [Fact]
        public void GetAccessKey()
        {
            var accessKeyCredential = new Core.Auth.AccessKeyCredential("accessKeyId", "accessKeySecret");

            Assert.Equal("accessKeyId", accessKeyCredential.GetAccessKeyId());
            Assert.Equal("accessKeySecret", accessKeyCredential.GetAccessKeySecret());
        }

        [Fact]
        public void GetAccessKeyWithException()
        {
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var accessKeyCredential = new Core.Auth.AccessKeyCredential("accessKeyId", null);
            });
            Assert.Equal("Access key secret cannot be null.", exception.ParamName);

            exception = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var accessKeyCredential = new Core.Auth.AccessKeyCredential(null, "accessKeySecret");
            });
            Assert.Equal("Access key ID cannot be null.", exception.ParamName);
        }
    }
}
