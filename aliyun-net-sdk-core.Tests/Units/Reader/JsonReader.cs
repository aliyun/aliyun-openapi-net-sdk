/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Aliyun.Acs.Core.Reader;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Reader
{
    public class JsonReaderTest
    {
        private readonly string jsonStr =
            "   {\"key\":\"value\",\"trueValue\":true,\"falseValue\":false,\"nullValue\":null,\"0\":{\"arrayKey0\":\"arrayValue0\",\"arrayInArray\":[\"index0\",\"index1\",\"index2\",46,1.1,-1,1000,-1000],\"number\":[1E+4,1e+4,1E-2,10,1234567890234567,1-,0.001,-0.1111,1+2],\"string\":{\"\\\\\\\\a\":\"\\\\\\\\b\\\\\\\\\"}   }  }   ";

        private readonly string itemsTitle = "endpoints";

        [Fact]
        public void Read()
        {
            var json = new JsonReader();
            var result = json.Read(jsonStr, itemsTitle);
            var context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal("value", context.StringValue(itemsTitle + ".key"));
        }

        [Fact]
        public void ReadCharEnumerator()
        {
            var json = new JsonReader();
            var jsonResponse = jsonStr;
            var ci = jsonResponse.GetEnumerator();
            var result = json.Read(ci, itemsTitle);
            var context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal(1, context.IntegerValue(itemsTitle + ".0[8]"));
        }

        [Fact]
        public void ReadForHideArrayItem()
        {
            var json = new JsonReader();
            var result = json.ReadForHideArrayItem(jsonStr, itemsTitle);
            var context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal("arrayValue0", context.StringValue(itemsTitle + ".0.arrayKey0"));
        }

        [Fact]
        public void ReadForHideArrayItemCharEnumerator()
        {
            var json = new JsonReader();
            var jsonResponse = jsonStr;
            var ci = jsonResponse.GetEnumerator();
            var result = json.ReadForHideArrayItem(ci, itemsTitle);
            var context = new UnmarshallerContext();
            context.ResponseDictionary = result;
            Assert.Equal(1, context.IntegerValue(itemsTitle + ".0.number[8]"));
        }

        [Fact]
        public void TrimFromLast()
        {
            var result = JsonReader.TrimFromLast(jsonStr, itemsTitle);
            Assert.Equal(jsonStr, result);
        }
    }
}
