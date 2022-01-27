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
    public class DescribeIpv4LocationResponseUnmarshaller
    {
        public static DescribeIpv4LocationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIpv4LocationResponse describeIpv4LocationResponse = new DescribeIpv4LocationResponse();

			describeIpv4LocationResponse.HttpResponse = _ctx.HttpResponse;
			describeIpv4LocationResponse.RequestId = _ctx.StringValue("DescribeIpv4Location.RequestId");
			describeIpv4LocationResponse.Ip = _ctx.StringValue("DescribeIpv4Location.Ip");
			describeIpv4LocationResponse.Country = _ctx.StringValue("DescribeIpv4Location.Country");
			describeIpv4LocationResponse.Province = _ctx.StringValue("DescribeIpv4Location.Province");
			describeIpv4LocationResponse.City = _ctx.StringValue("DescribeIpv4Location.City");
			describeIpv4LocationResponse.County = _ctx.StringValue("DescribeIpv4Location.County");
			describeIpv4LocationResponse.Isp = _ctx.StringValue("DescribeIpv4Location.Isp");
			describeIpv4LocationResponse.CountryCode = _ctx.StringValue("DescribeIpv4Location.CountryCode");
			describeIpv4LocationResponse.CountryEn = _ctx.StringValue("DescribeIpv4Location.CountryEn");
			describeIpv4LocationResponse.ProvinceEn = _ctx.StringValue("DescribeIpv4Location.ProvinceEn");
			describeIpv4LocationResponse.CityEn = _ctx.StringValue("DescribeIpv4Location.CityEn");
			describeIpv4LocationResponse.Longitude = _ctx.StringValue("DescribeIpv4Location.Longitude");
			describeIpv4LocationResponse.Latitude = _ctx.StringValue("DescribeIpv4Location.Latitude");
        
			return describeIpv4LocationResponse;
        }
    }
}
