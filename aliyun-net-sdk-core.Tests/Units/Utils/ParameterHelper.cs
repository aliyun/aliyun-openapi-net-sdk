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

using System;
using System.Text;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Utils;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Utils
{
    public class ParameterHelperTest
    {
        public DateTime dateTime()
        {
            DateTime datetime;
            var timeStamp = 1548311719318;
            var startTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            datetime = startTime.AddMilliseconds(timeStamp);
            datetime = TimeZoneInfo.ConvertTimeToUtc(datetime);
            return datetime;
        }

        [Fact]
        public void FormatIso8601Date()
        {
            var datetime = dateTime();
            var result = ParameterHelper.FormatIso8601Date(datetime);
            Assert.NotEqual(datetime.ToString(), result);
            Assert.Equal("2019-01-24T06:35:19Z", result);
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
        public void GetRFC2616Date()
        {
            var datetime = dateTime();
            var result = ParameterHelper.GetRFC2616Date(datetime);
            Assert.Equal("Thu, 24 Jan 2019 06:35:19 GMT", result);
        }

        [Fact]
        public void Md5Sum()
        {
            var str = "md5 sum";
            var buff = Encoding.Default.GetBytes(str);
            var result = ParameterHelper.Md5Sum(buff);
            Assert.Equal("018A7FC7456F40EE0D083CFCBF1EE472", result);
        }

        [Fact]
        public void Md5SumAndBase64()
        {
            var str = "md5 sum";
            var buff = Encoding.Default.GetBytes(str);
            var result = ParameterHelper.Md5SumAndBase64(buff);
            // Console.WriteLine(result);
            Assert.Equal("AYp/x0VvQO4NCDz8vx7kcg==", result);
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
                ParameterHelper.FormatTypeToString(
                    ParameterHelper.StingToFormatType("application/x-www-form-urlencoded"))
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
