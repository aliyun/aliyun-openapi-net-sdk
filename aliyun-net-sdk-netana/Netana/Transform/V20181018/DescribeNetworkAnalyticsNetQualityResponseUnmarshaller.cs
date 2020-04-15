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
using Aliyun.Acs.Netana.Model.V20181018;

namespace Aliyun.Acs.Netana.Transform.V20181018
{
    public class DescribeNetworkAnalyticsNetQualityResponseUnmarshaller
    {
        public static DescribeNetworkAnalyticsNetQualityResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkAnalyticsNetQualityResponse describeNetworkAnalyticsNetQualityResponse = new DescribeNetworkAnalyticsNetQualityResponse();

			describeNetworkAnalyticsNetQualityResponse.HttpResponse = context.HttpResponse;
			describeNetworkAnalyticsNetQualityResponse.RequestId = context.StringValue("DescribeNetworkAnalyticsNetQuality.RequestId");
			describeNetworkAnalyticsNetQualityResponse.TotalCount = context.IntegerValue("DescribeNetworkAnalyticsNetQuality.TotalCount");
			describeNetworkAnalyticsNetQualityResponse.PageNumber = context.IntegerValue("DescribeNetworkAnalyticsNetQuality.PageNumber");
			describeNetworkAnalyticsNetQualityResponse.PageSize = context.IntegerValue("DescribeNetworkAnalyticsNetQuality.PageSize");

			List<DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality> describeNetworkAnalyticsNetQualityResponse_netQualities = new List<DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality>();
			for (int i = 0; i < context.Length("DescribeNetworkAnalyticsNetQuality.NetQualities.Length"); i++) {
				DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality netQuality = new DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality();
				netQuality.RoundTripLatency = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].RoundTripLatency");
				netQuality.NetLevel = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].NetLevel");
				netQuality.DataType = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].DataType");
				netQuality.DateTime = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].DateTime");

				DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality.DescribeNetworkAnalyticsNetQuality_Country country = new DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality.DescribeNetworkAnalyticsNetQuality_Country();
				country.CountryCode = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Country.CountryCode");
				country.CountryCn = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Country.CountryCn");
				country.CountryEn = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Country.CountryEn");
				netQuality.Country = country;

				DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality.DescribeNetworkAnalyticsNetQuality_Province province = new DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality.DescribeNetworkAnalyticsNetQuality_Province();
				province.ProvinceCode = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Province.ProvinceCode");
				province.ProvinceCn = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Province.ProvinceCn");
				province.ProvinceEn = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Province.ProvinceEn");
				netQuality.Province = province;

				DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality.DescribeNetworkAnalyticsNetQuality_Carrier carrier = new DescribeNetworkAnalyticsNetQualityResponse.DescribeNetworkAnalyticsNetQuality_NetQuality.DescribeNetworkAnalyticsNetQuality_Carrier();
				carrier.CarrierCode = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Carrier.CarrierCode");
				carrier.CarrierCn = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Carrier.CarrierCn");
				carrier.CarrierEn = context.StringValue("DescribeNetworkAnalyticsNetQuality.NetQualities["+ i +"].Carrier.CarrierEn");
				netQuality.Carrier = carrier;

				describeNetworkAnalyticsNetQualityResponse_netQualities.Add(netQuality);
			}
			describeNetworkAnalyticsNetQualityResponse.NetQualities = describeNetworkAnalyticsNetQualityResponse_netQualities;
        
			return describeNetworkAnalyticsNetQualityResponse;
        }
    }
}
