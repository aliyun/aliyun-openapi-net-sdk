using System.Collections.Generic;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Transform
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
                { "EnumValue", "0" },
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

            result = this.getInstance().IntegerValue("IntegerValueNotExist");
            Assert.Null(result);
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

            result = this.getInstance().LongValue("LongValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void BooleanValue()
        {
            var result = this.getInstance().BooleanValue("BooleanValue");
            Assert.True(result);

            result = this.getInstance().BooleanValue("BooleanValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void FloatValue()
        {
            float? result = this.getInstance().FloatValue("FloatValue");
            Assert.IsType<float>(result);

            result = this.getInstance().FloatValue("FloatValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void DoubleValue()
        {
            double? result = this.getInstance().DoubleValue("DoubleValue");
            Assert.IsType<double>(result);

            result = this.getInstance().DoubleValue("DoubleValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void EnumValue()
        {
            FormatType? result = this.getInstance().EnumValue<FormatType>("EnumValue");
            Assert.IsType<FormatType>(result);
            Assert.Equal(FormatType.XML, result);

            result = this.getInstance().EnumValue<FormatType>("EnumValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void Length()
        {
            var result = this.getInstance().Length("Length");
            Assert.Equal(12000, result);

            result = this.getInstance().Length("LengthNotExist");
            Assert.Equal(0, result);
        }
    }
}
