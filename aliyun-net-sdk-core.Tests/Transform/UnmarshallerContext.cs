using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Transform
{
    public class UnmarshallerContextTest
    {
        public UnmarshallerContext getInstance()
        {
            UnmarshallerContext unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                { { "IntegerValue", "1" },
                { "StringValue", "string" },
                { "LongValue", "9223372036854775807" },
                { "BooleanValue", "true" },
                { "FloatValue", "0.123456" },
                { "DoubleValue", "0.123456" },
                { "EnumValue", "{1,2,3,4,5}" },
                { "Length", "012000" }
                };
            }
            return unmarshallerContext;
        }

        [Fact]
        public void IntegerValue()
        {
            var result = this.getInstance().IntegerValue("IntegerValue");
            Assert.Equal(1, result);
        }

        [Fact]
        public void StringValue()
        {
            var result = this.getInstance().StringValue("StringValue");
            Assert.Equal("string", result);
        }

        [Fact]
        public void LongValue()
        {
            var result = this.getInstance().LongValue("LongValue");
            Assert.Equal(9223372036854775807, result);
        }

        [Fact]
        public void BooleanValue()
        {
            var result = this.getInstance().BooleanValue("BooleanValue");
            Assert.True(result);
        }

        [Fact]
        public void FloatValue()
        {
            float? result = this.getInstance().FloatValue("FloatValue");
            Assert.IsType<float>(result);
        }

        [Fact]
        public void DoubleValue()
        {
            double? result = this.getInstance().DoubleValue("DoubleValue");
            Assert.IsType<double>(result);
        }

        [Fact]
        public void EnumValue()
        {
            // this.getInstance().EnumValue("EnumValue");
        }

        [Fact]
        public void Length()
        {
            var result = this.getInstance().Length("Length");
            Assert.Equal(12000, result);
        }
    }
}
