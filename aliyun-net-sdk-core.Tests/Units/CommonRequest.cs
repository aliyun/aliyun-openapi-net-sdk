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

using System.Text;

using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units
{
    public class CommonRequestTest
    {
        [Fact]
        public void Add()
        {
            var context = new UnmarshallerContext();
            var instance = new CommonRequest();

            instance.AddQueryParameters("AddQueryParameters", "a");
            context.ResponseDictionary = instance.QueryParameters;
            Assert.Equal("a", context.StringValue("AddQueryParameters"));

            instance.AddBodyParameters("AddBodyParameters", "b");
            context.ResponseDictionary = instance.BodyParameters;
            Assert.Equal("b", context.StringValue("AddBodyParameters"));

            instance.AddHeadParameters("AddHeadParameters", "c");
            context.ResponseDictionary = instance.HeadParameters;
            Assert.Equal("c", context.StringValue("AddHeadParameters"));

            instance.AddPathParameters("AddPathParameters", "d");
            context.ResponseDictionary = instance.PathParameters;
            Assert.Equal("d", context.StringValue("AddPathParameters"));
        }

        [Fact]
        public void BuildRequest()
        {
            var instance = new CommonRequest();
            var request = instance.BuildRequest();

            // all parameters is null
            request = instance.BuildRequest();

            // all parameters  is not null
            instance.UriPattern = "https://www.alibabacloud.com";
            instance.AddPathParameters("foo", "bar");
            instance.Action = "Action";
            instance.RegionId = "RegionId";
            instance.LocationProduct = "LocationProduct";
            instance.LocationEndpointType = "LocationEndpointType";
            instance.TimeoutInMilliSeconds = 100000;
            instance.Method = MethodType.GET;
            instance.Domain = "Domain";
            var content = Encoding.GetEncoding("UTF-8").GetBytes("somestring");
            instance.SetContent(content, "UTF-8", FormatType.JSON);
            instance.AddQueryParameters("foo", "bar");
            instance.AddBodyParameters("foo", "bar");
            request = instance.BuildRequest();
        }

        [Fact]
        public void Instance()
        {
            var instance = new CommonRequest();
        }

        [Fact]
        public void SetContent()
        {
            var instance = new CommonRequest();
            var content = Encoding.ASCII.GetBytes("someString");
            instance.SetContent(content, "UTF-8", FormatType.JSON);
        }
    }
}
