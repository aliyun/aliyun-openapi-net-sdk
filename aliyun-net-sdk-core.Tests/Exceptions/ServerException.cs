using Aliyun.Acs.Core.Exceptions;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Exceptions
{
    public class ServerExceptionTest
    {
        [Fact]
        public void Instance1()
        {
            ServerException exception = new ServerException("200", "message", "requestId");
            Assert.Equal("200", exception.ErrorCode);
            Assert.Equal("message", exception.ErrorMessage);
            Assert.Equal("requestId", exception.RequestId);
        }

        [Fact]
        public void Instance2()
        {
            ServerException exception = new ServerException("200", "message");
            Assert.Equal("200", exception.ErrorCode);
            Assert.Equal("message", exception.ErrorMessage);
            Assert.Null(exception.RequestId);
        }
    }
}
