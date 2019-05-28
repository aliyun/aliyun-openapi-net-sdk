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
            var unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                {
                    {"IntegerValue", "1"},
                    {"StringValue", "string"},
                    {"LongValue", "9223372036854775807"},
                    {"BooleanValue", "true"},
                    {"FloatValue", "0.123456"},
                    {"DoubleValue", "0.123456"},
                    {"EnumValue", "0"},
                    {"Length", "012000"}
                };
            }

            return unmarshallerContext;
        }

        [Fact]
        public void BooleanValue()
        {
            var result = getInstance().BooleanValue("BooleanValue");
            Assert.True(result);

            result = getInstance().BooleanValue("BooleanValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void DoubleValue()
        {
            var result = getInstance().DoubleValue("DoubleValue");
            Assert.IsType<double>(result);

            result = getInstance().DoubleValue("DoubleValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void EnumValue()
        {
            var result = getInstance().EnumValue<FormatType>("EnumValue");
            Assert.IsType<FormatType>(result);
            Assert.Equal(FormatType.XML, result);

            result = getInstance().EnumValue<FormatType>("EnumValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void FloatValue()
        {
            var result = getInstance().FloatValue("FloatValue");
            Assert.IsType<float>(result);

            result = getInstance().FloatValue("FloatValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void IntegerValue()
        {
            var result = getInstance().IntegerValue("IntegerValue");
            Assert.Equal(1, result);

            result = getInstance().IntegerValue("IntegerValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void Length()
        {
            var result = getInstance().Length("Length");
            Assert.Equal(12000, result);

            result = getInstance().Length("LengthNotExist");
            Assert.Equal(0, result);
        }

        [Fact]
        public void LongValue()
        {
            var result = getInstance().LongValue("LongValue");
            Assert.Equal(9223372036854775807, result);

            result = getInstance().LongValue("LongValueNotExist");
            Assert.Null(result);
        }

        [Fact]
        public void StringValue()
        {
            var result = getInstance().StringValue("StringValue");
            Assert.Equal("string", result);
        }
    }
}
