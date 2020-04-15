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
    public class DescribeNetworkAnalyticsLatencyResponseUnmarshaller
    {
        public static DescribeNetworkAnalyticsLatencyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkAnalyticsLatencyResponse describeNetworkAnalyticsLatencyResponse = new DescribeNetworkAnalyticsLatencyResponse();

			describeNetworkAnalyticsLatencyResponse.HttpResponse = context.HttpResponse;
			describeNetworkAnalyticsLatencyResponse.RequestId = context.StringValue("DescribeNetworkAnalyticsLatency.RequestId");
			describeNetworkAnalyticsLatencyResponse.TotalCount = context.IntegerValue("DescribeNetworkAnalyticsLatency.TotalCount");
			describeNetworkAnalyticsLatencyResponse.PageNumber = context.IntegerValue("DescribeNetworkAnalyticsLatency.PageNumber");
			describeNetworkAnalyticsLatencyResponse.PageSize = context.IntegerValue("DescribeNetworkAnalyticsLatency.PageSize");

			List<DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo> describeNetworkAnalyticsLatencyResponse_roundTripLatencies = new List<DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo>();
			for (int i = 0; i < context.Length("DescribeNetworkAnalyticsLatency.RoundTripLatencies.Length"); i++) {
				DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo roundTripLatencyInfo = new DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo();
				roundTripLatencyInfo.RoundTripLatency = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].RoundTripLatency");
				roundTripLatencyInfo.DataType = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].DataType");
				roundTripLatencyInfo.DateTime = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].DateTime");
				roundTripLatencyInfo.Ip = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Ip");

				DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo.DescribeNetworkAnalyticsLatency_Country country = new DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo.DescribeNetworkAnalyticsLatency_Country();
				country.CountryCode = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Country.CountryCode");
				country.CountryCn = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Country.CountryCn");
				country.CountryEn = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Country.CountryEn");
				roundTripLatencyInfo.Country = country;

				DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo.DescribeNetworkAnalyticsLatency_Province province = new DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo.DescribeNetworkAnalyticsLatency_Province();
				province.ProvinceCode = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Province.ProvinceCode");
				province.ProvinceCn = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Province.ProvinceCn");
				province.ProvinceEn = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Province.ProvinceEn");
				roundTripLatencyInfo.Province = province;

				DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo.DescribeNetworkAnalyticsLatency_Carrier carrier = new DescribeNetworkAnalyticsLatencyResponse.DescribeNetworkAnalyticsLatency_RoundTripLatencyInfo.DescribeNetworkAnalyticsLatency_Carrier();
				carrier.CarrierCode = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Carrier.CarrierCode");
				carrier.CarrierCn = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Carrier.CarrierCn");
				carrier.CarrierEn = context.StringValue("DescribeNetworkAnalyticsLatency.RoundTripLatencies["+ i +"].Carrier.CarrierEn");
				roundTripLatencyInfo.Carrier = carrier;

				describeNetworkAnalyticsLatencyResponse_roundTripLatencies.Add(roundTripLatencyInfo);
			}
			describeNetworkAnalyticsLatencyResponse.RoundTripLatencies = describeNetworkAnalyticsLatencyResponse_roundTripLatencies;
        
			return describeNetworkAnalyticsLatencyResponse;
        }
    }
}
