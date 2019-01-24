using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Utils
{
    public class ParameterHelperTest
    {
        public DateTime dateTime()
        {
            DateTime datetime;
            long timeStamp = 1548311719318;
            DateTime startTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            datetime = startTime.AddMilliseconds(timeStamp);
            datetime = TimeZoneInfo.ConvertTimeToUtc(datetime);
            return datetime;
        }

        [Fact]
        public void FormatIso8601Date()
        {
            DateTime datetime = this.dateTime();
            string result = ParameterHelper.FormatIso8601Date(datetime);
            Assert.NotEqual(datetime.ToString(), result);
            Assert.Equal("2019-01-24T06:35:19Z", result);
        }

        [Fact]
        public void GetRFC2616Date()
        {
            DateTime datetime = this.dateTime();
            string result = ParameterHelper.GetRFC2616Date(datetime);
            Assert.Equal("Thu, 24 Jan 2019 06:35:19 GMT", result);
        }

        [Fact]
        public void Md5Sum()
        {
            string str = "md5 sum";
            byte[] buff = System.Text.Encoding.Default.GetBytes(str);
            string result = ParameterHelper.Md5Sum(buff);
            Assert.Equal("018A7FC7456F40EE0D083CFCBF1EE472", result);
        }

        [Fact]
        public void Md5SumAndBase64()
        {
            string str = "md5 sum";
            byte[] buff = System.Text.Encoding.Default.GetBytes(str);
            string result = ParameterHelper.Md5SumAndBase64(buff);
            // Console.WriteLine(result);
            Assert.Equal("AYp/x0VvQO4NCDz8vx7kcg==", result);
        }

        [Fact]
        public void FormatTypeToString()
        {
            Assert.Equal("application/xml", ParameterHelper.FormatTypeToString(FormatType.XML));
            Assert.Equal("application/json", ParameterHelper.FormatTypeToString(FormatType.JSON));
            Assert.Equal("application/x-www-form-urlencoded", ParameterHelper.FormatTypeToString(FormatType.FORM));
            Assert.Equal("application/octet-stream", ParameterHelper.FormatTypeToString(FormatType.RAW));
        }

        [Fact]
        public void StingToFormatType()
        {
            Assert.Equal("application/xml",
                ParameterHelper.FormatTypeToString(ParameterHelper.StingToFormatType("application/xml"))
            );
            Assert.Equal("application/xml",
                ParameterHelper.FormatTypeToString(ParameterHelper.StingToFormatType("text/xml"))
            );
            Assert.Equal("application/json",
                ParameterHelper.FormatTypeToString(ParameterHelper.StingToFormatType("application/json"))
            );
            Assert.Equal("application/x-www-form-urlencoded",
                ParameterHelper.FormatTypeToString(ParameterHelper.StingToFormatType("application/x-www-form-urlencoded"))
            );

            Assert.Equal(FormatType.RAW, ParameterHelper.StingToFormatType("raw"));
        }

        [Fact]
        public void StringToMethodType()
        {
            Assert.True(MethodType.GET == ParameterHelper.StringToMethodType("get"));
            Assert.True(MethodType.POST == ParameterHelper.StringToMethodType("post"));
            Assert.True(MethodType.DELETE == ParameterHelper.StringToMethodType("delete"));
            Assert.True(MethodType.PUT == ParameterHelper.StringToMethodType("put"));
            Assert.True(MethodType.HEAD == ParameterHelper.StringToMethodType("head"));
            Assert.True(MethodType.OPTIONS == ParameterHelper.StringToMethodType("options"));
            Assert.True(null == ParameterHelper.StringToMethodType("test"));
        }
    }
}
