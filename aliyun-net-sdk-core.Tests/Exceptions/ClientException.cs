using Aliyun.Acs.Core.Exceptions;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Exceptions
{
    public class ClientExceptioinTest
    {
        [Fact]
        public void Instance1()
        {
            ClientException exception = new ClientException("200", "message", "requestId");
            Assert.Equal("200", exception.ErrorCode);
            Assert.Equal("message", exception.ErrorMessage);
            Assert.Null(exception.RequestId);
        }

        [Fact]
        public void Instance2()
        {
            ClientException exception = new ClientException("200", "message");
            Assert.Equal("200", exception.ErrorCode);
            Assert.Equal("message", exception.ErrorMessage);
            Assert.Null(exception.RequestId);
        }

        [Fact]
        public void Instance3()
        {
            ClientException exception = new ClientException("");
            Assert.Null(exception.ErrorMessage);
            Assert.Null(exception.ErrorCode);
            Assert.Null(exception.RequestId);
        }
    }
}
