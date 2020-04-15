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
    public class DescribeNetworkAnalyticsDataTransferResponseUnmarshaller
    {
        public static DescribeNetworkAnalyticsDataTransferResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkAnalyticsDataTransferResponse describeNetworkAnalyticsDataTransferResponse = new DescribeNetworkAnalyticsDataTransferResponse();

			describeNetworkAnalyticsDataTransferResponse.HttpResponse = context.HttpResponse;
			describeNetworkAnalyticsDataTransferResponse.RequestId = context.StringValue("DescribeNetworkAnalyticsDataTransfer.RequestId");
			describeNetworkAnalyticsDataTransferResponse.TotalCount = context.IntegerValue("DescribeNetworkAnalyticsDataTransfer.TotalCount");
			describeNetworkAnalyticsDataTransferResponse.PageNumber = context.IntegerValue("DescribeNetworkAnalyticsDataTransfer.PageNumber");
			describeNetworkAnalyticsDataTransferResponse.PageSize = context.IntegerValue("DescribeNetworkAnalyticsDataTransfer.PageSize");

			List<DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo> describeNetworkAnalyticsDataTransferResponse_dataTransferInfos = new List<DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo>();
			for (int i = 0; i < context.Length("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos.Length"); i++) {
				DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo dataTransferInfo = new DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo();
				dataTransferInfo.InBoundTotalBytes = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].InBoundTotalBytes");
				dataTransferInfo.OutBoundTotalBytes = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].OutBoundTotalBytes");
				dataTransferInfo.DataType = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].DataType");
				dataTransferInfo.DateTime = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].DateTime");
				dataTransferInfo.Ip = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Ip");

				DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo.DescribeNetworkAnalyticsDataTransfer_Country country = new DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo.DescribeNetworkAnalyticsDataTransfer_Country();
				country.CountryCode = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Country.CountryCode");
				country.CountryCn = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Country.CountryCn");
				country.CountryEn = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Country.CountryEn");
				dataTransferInfo.Country = country;

				DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo.DescribeNetworkAnalyticsDataTransfer_Province province = new DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo.DescribeNetworkAnalyticsDataTransfer_Province();
				province.ProvinceCode = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Province.ProvinceCode");
				province.ProvinceCn = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Province.ProvinceCn");
				province.ProvinceEn = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Province.ProvinceEn");
				dataTransferInfo.Province = province;

				DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo.DescribeNetworkAnalyticsDataTransfer_Carrier carrier = new DescribeNetworkAnalyticsDataTransferResponse.DescribeNetworkAnalyticsDataTransfer_DataTransferInfo.DescribeNetworkAnalyticsDataTransfer_Carrier();
				carrier.CarrierCode = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Carrier.CarrierCode");
				carrier.CarrierCn = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Carrier.CarrierCn");
				carrier.CarrierEn = context.StringValue("DescribeNetworkAnalyticsDataTransfer.DataTransferInfos["+ i +"].Carrier.CarrierEn");
				dataTransferInfo.Carrier = carrier;

				describeNetworkAnalyticsDataTransferResponse_dataTransferInfos.Add(dataTransferInfo);
			}
			describeNetworkAnalyticsDataTransferResponse.DataTransferInfos = describeNetworkAnalyticsDataTransferResponse_dataTransferInfos;
        
			return describeNetworkAnalyticsDataTransferResponse;
        }
    }
}
