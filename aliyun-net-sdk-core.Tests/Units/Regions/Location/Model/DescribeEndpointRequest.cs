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

using Aliyun.Acs.Core.Regions.Location.Model;
using Aliyun.Acs.Core.Transform;

using Xunit;

namespace Aliyun.Acs.Core.Tests.Units.Regions.Location.Model
{
    public class DescribeEndpointRequestTest
    {
        [Fact]
        public void EndpointType()
        {
            var instance = new DescribeEndpointRequest();
            var EndpointType = "EndpointType";
            instance.EndpointType = EndpointType;
            Assert.Equal(EndpointType, instance.EndpointType);
        }

        [Fact]
        public void GetResponse()
        {
            var instance = new DescribeEndpointRequest();
            var unmarshallerContext = new UnmarshallerContext();
            if (unmarshallerContext.ResponseDictionary == null)
            {
                unmarshallerContext.ResponseDictionary = new Dictionary<string, string>
                {
                    {"foo", "bar"},
                    {"a", "A"},
                    {"b", "B"}
                };
            }

            var result = instance.GetResponse(unmarshallerContext);
            Assert.Null(result);
        }

        [Fact]
        public void Id()
        {
            var instance = new DescribeEndpointRequest();
            var Id = "Id";
            instance.Id = Id;
            Assert.Equal(Id, instance.Id);
        }

        [Fact]
        public void LocationProduct()
        {
            var instance = new DescribeEndpointRequest();
            var LocationProduct = "LocationProduct";
            instance.LocationProduct = LocationProduct;
            Assert.Equal(LocationProduct, instance.LocationProduct);
        }
    }
}
