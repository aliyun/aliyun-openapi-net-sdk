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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeBandwidthPackagePublicIpMonitorDataResponseUnmarshaller
    {
        public static DescribeBandwidthPackagePublicIpMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBandwidthPackagePublicIpMonitorDataResponse describeBandwidthPackagePublicIpMonitorDataResponse = new DescribeBandwidthPackagePublicIpMonitorDataResponse();

			describeBandwidthPackagePublicIpMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeBandwidthPackagePublicIpMonitorDataResponse.RequestId = context.StringValue("DescribeBandwidthPackagePublicIpMonitorData.RequestId");

			List<DescribeBandwidthPackagePublicIpMonitorDataResponse.DescribeBandwidthPackagePublicIpMonitorData_MonitorData> describeBandwidthPackagePublicIpMonitorDataResponse_monitorDatas = new List<DescribeBandwidthPackagePublicIpMonitorDataResponse.DescribeBandwidthPackagePublicIpMonitorData_MonitorData>();
			for (int i = 0; i < context.Length("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas.Length"); i++) {
				DescribeBandwidthPackagePublicIpMonitorDataResponse.DescribeBandwidthPackagePublicIpMonitorData_MonitorData monitorData = new DescribeBandwidthPackagePublicIpMonitorDataResponse.DescribeBandwidthPackagePublicIpMonitorData_MonitorData();
				monitorData.RX = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].RX");
				monitorData.TX = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].TX");
				monitorData.ReceivedBandwidth = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].ReceivedBandwidth");
				monitorData.TransportedBandwidth = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].TransportedBandwidth");
				monitorData.Flow = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].Flow");
				monitorData.Bandwidth = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].Bandwidth");
				monitorData.Packets = context.LongValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].Packets");
				monitorData.TimeStamp = context.StringValue("DescribeBandwidthPackagePublicIpMonitorData.MonitorDatas["+ i +"].TimeStamp");

				describeBandwidthPackagePublicIpMonitorDataResponse_monitorDatas.Add(monitorData);
			}
			describeBandwidthPackagePublicIpMonitorDataResponse.MonitorDatas = describeBandwidthPackagePublicIpMonitorDataResponse_monitorDatas;
        
			return describeBandwidthPackagePublicIpMonitorDataResponse;
        }
    }
}