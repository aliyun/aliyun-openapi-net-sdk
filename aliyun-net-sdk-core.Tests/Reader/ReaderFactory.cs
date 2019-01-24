using System;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Reader;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Reader
{
    public class ReaderFactoryTest
    {
        [Fact]
        public void CreateInstance()
        {
            Assert.IsType<JsonReader>(ReaderFactory.CreateInstance(FormatType.JSON));

            Assert.IsType<XmlReader>(ReaderFactory.CreateInstance(FormatType.XML));

            Assert.Null(ReaderFactory.CreateInstance(FormatType.FORM));
        }
    }
}
