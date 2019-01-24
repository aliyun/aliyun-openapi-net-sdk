using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.UnitTests.Reader
{
    public class JsonReaderTest
    {
        private string jsonStr = "   {\"key\":\"value\",\"trueValue\":true,\"falseValue\":false,\"nullValue\":null,\"0\":{\"arrayKey0\":\"arrayValue0\",\"arrayInArray\":[\"index0\",\"index1\",\"index2\",46,1.1,-1,1000,-1000],\"number\":[1E+4,1e+4,1E-2,10,1234567890234567,1-,0.001,-0.1111,1+2],\"string\":{\"\\\\\\\\a\":\"\\\\\\\\b\\\\\\\\\"}   }  }   ";

        private string itemsTitle = "endpoints";

        [Fact]
        public void Read()
        {
            JsonReader json = new JsonReader();
            var result = json.Read(this.jsonStr, this.itemsTitle);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal("value", context.StringValue(this.itemsTitle + ".key"));
        }

        [Fact]
        public void ReadForHideArrayItem()
        {
            JsonReader json = new JsonReader();
            var result = json.ReadForHideArrayItem(this.jsonStr, this.itemsTitle);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal("arrayValue0", context.StringValue(this.itemsTitle + ".0.arrayKey0"));
        }

        [Fact]
        public void ReadCharEnumerator()
        {
            JsonReader json = new JsonReader();
            string jsonResponse = this.jsonStr;
            CharEnumerator ci = jsonResponse.GetEnumerator();
            var result = json.Read(ci, this.itemsTitle);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal(1, context.IntegerValue(this.itemsTitle + ".0[8]"));
        }

        [Fact]
        public void ReadForHideArrayItemCharEnumerator()
        {
            JsonReader json = new JsonReader();
            string jsonResponse = this.jsonStr;
            CharEnumerator ci = jsonResponse.GetEnumerator();
            var result = json.ReadForHideArrayItem(ci, this.itemsTitle);
            UnmarshallerContext context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal(1, context.IntegerValue(this.itemsTitle + ".0.number[8]"));
        }

        [Fact]
        public void TrimFromLast()
        {
            var result = JsonReader.TrimFromLast(this.jsonStr, this.itemsTitle);
            Assert.Equal(this.jsonStr, result);
        }
    }
}
