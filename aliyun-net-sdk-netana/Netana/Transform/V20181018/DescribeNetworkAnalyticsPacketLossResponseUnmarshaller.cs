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
    public class DescribeNetworkAnalyticsPacketLossResponseUnmarshaller
    {
        public static DescribeNetworkAnalyticsPacketLossResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNetworkAnalyticsPacketLossResponse describeNetworkAnalyticsPacketLossResponse = new DescribeNetworkAnalyticsPacketLossResponse();

			describeNetworkAnalyticsPacketLossResponse.HttpResponse = context.HttpResponse;
			describeNetworkAnalyticsPacketLossResponse.RequestId = context.StringValue("DescribeNetworkAnalyticsPacketLoss.RequestId");
			describeNetworkAnalyticsPacketLossResponse.TotalCount = context.IntegerValue("DescribeNetworkAnalyticsPacketLoss.TotalCount");
			describeNetworkAnalyticsPacketLossResponse.PageNumber = context.IntegerValue("DescribeNetworkAnalyticsPacketLoss.PageNumber");
			describeNetworkAnalyticsPacketLossResponse.PageSize = context.IntegerValue("DescribeNetworkAnalyticsPacketLoss.PageSize");

			List<DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo> describeNetworkAnalyticsPacketLossResponse_packetLossInfos = new List<DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo>();
			for (int i = 0; i < context.Length("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos.Length"); i++) {
				DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo packetLossInfo = new DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo();
				packetLossInfo.InBoundTotalPacket = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].InBoundTotalPacket");
				packetLossInfo.OutBoundTotalPacket = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].OutBoundTotalPacket");
				packetLossInfo.DataType = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].DataType");
				packetLossInfo.DateTime = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].DateTime");
				packetLossInfo.Ip = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Ip");

				DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo.DescribeNetworkAnalyticsPacketLoss_Country country = new DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo.DescribeNetworkAnalyticsPacketLoss_Country();
				country.CountryCode = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Country.CountryCode");
				country.CountryCn = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Country.CountryCn");
				country.CountryEn = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Country.CountryEn");
				packetLossInfo.Country = country;

				DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo.DescribeNetworkAnalyticsPacketLoss_Province province = new DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo.DescribeNetworkAnalyticsPacketLoss_Province();
				province.ProvinceCode = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Province.ProvinceCode");
				province.ProvinceCn = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Province.ProvinceCn");
				province.ProvinceEn = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Province.ProvinceEn");
				packetLossInfo.Province = province;

				DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo.DescribeNetworkAnalyticsPacketLoss_Carrier carrier = new DescribeNetworkAnalyticsPacketLossResponse.DescribeNetworkAnalyticsPacketLoss_PacketLossInfo.DescribeNetworkAnalyticsPacketLoss_Carrier();
				carrier.CarrierCode = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Carrier.CarrierCode");
				carrier.CarrierCn = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Carrier.CarrierCn");
				carrier.CarrierEn = context.StringValue("DescribeNetworkAnalyticsPacketLoss.PacketLossInfos["+ i +"].Carrier.CarrierEn");
				packetLossInfo.Carrier = carrier;

				describeNetworkAnalyticsPacketLossResponse_packetLossInfos.Add(packetLossInfo);
			}
			describeNetworkAnalyticsPacketLossResponse.PacketLossInfos = describeNetworkAnalyticsPacketLossResponse_packetLossInfos;
        
			return describeNetworkAnalyticsPacketLossResponse;
        }
    }
}
