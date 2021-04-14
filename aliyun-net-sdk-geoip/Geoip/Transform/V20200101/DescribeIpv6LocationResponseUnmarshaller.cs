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
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.geoip.Model.V20200101;

namespace Aliyun.Acs.geoip.Transform.V20200101
{
    public class DescribeIpv6LocationResponseUnmarshaller
    {
        public static DescribeIpv6LocationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpv6LocationResponse describeIpv6LocationResponse = new DescribeIpv6LocationResponse();

			describeIpv6LocationResponse.HttpResponse = _ctx.HttpResponse;
			describeIpv6LocationResponse.RequestId = _ctx.StringValue("DescribeIpv6Location.RequestId");
			describeIpv6LocationResponse.Ip = _ctx.StringValue("DescribeIpv6Location.Ip");
			describeIpv6LocationResponse.Country = _ctx.StringValue("DescribeIpv6Location.Country");
			describeIpv6LocationResponse.Province = _ctx.StringValue("DescribeIpv6Location.Province");
			describeIpv6LocationResponse.City = _ctx.StringValue("DescribeIpv6Location.City");
			describeIpv6LocationResponse.County = _ctx.StringValue("DescribeIpv6Location.County");
			describeIpv6LocationResponse.Isp = _ctx.StringValue("DescribeIpv6Location.Isp");
			describeIpv6LocationResponse.CountryCode = _ctx.StringValue("DescribeIpv6Location.CountryCode");
			describeIpv6LocationResponse.CountryEn = _ctx.StringValue("DescribeIpv6Location.CountryEn");
			describeIpv6LocationResponse.ProvinceEn = _ctx.StringValue("DescribeIpv6Location.ProvinceEn");
			describeIpv6LocationResponse.CityEn = _ctx.StringValue("DescribeIpv6Location.CityEn");
			describeIpv6LocationResponse.Longitude = _ctx.StringValue("DescribeIpv6Location.Longitude");
			describeIpv6LocationResponse.Latitude = _ctx.StringValue("DescribeIpv6Location.Latitude");
        
			return describeIpv6LocationResponse;
        }
    }
}
