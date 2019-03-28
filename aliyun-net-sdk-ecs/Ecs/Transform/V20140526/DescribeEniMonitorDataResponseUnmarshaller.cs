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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeEniMonitorDataResponseUnmarshaller
    {
        public static DescribeEniMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEniMonitorDataResponse describeEniMonitorDataResponse = new DescribeEniMonitorDataResponse();

			describeEniMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeEniMonitorDataResponse.RequestId = context.StringValue("DescribeEniMonitorData.RequestId");
			describeEniMonitorDataResponse.TotalCount = context.IntegerValue("DescribeEniMonitorData.TotalCount");

			List<DescribeEniMonitorDataResponse.DescribeEniMonitorData_EniMonitorData> describeEniMonitorDataResponse_monitorData = new List<DescribeEniMonitorDataResponse.DescribeEniMonitorData_EniMonitorData>();
			for (int i = 0; i < context.Length("DescribeEniMonitorData.MonitorData.Length"); i++) {
				DescribeEniMonitorDataResponse.DescribeEniMonitorData_EniMonitorData eniMonitorData = new DescribeEniMonitorDataResponse.DescribeEniMonitorData_EniMonitorData();
				eniMonitorData.EniId = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].EniId");
				eniMonitorData.TimeStamp = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].TimeStamp");
				eniMonitorData.PacketTx = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].PacketTx");
				eniMonitorData.PacketRx = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].PacketRx");
				eniMonitorData.IntranetTx = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].IntranetTx");
				eniMonitorData.IntranetRx = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].IntranetRx");
				eniMonitorData.DropPacketTx = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].DropPacketTx");
				eniMonitorData.DropPacketRx = context.StringValue("DescribeEniMonitorData.MonitorData["+ i +"].DropPacketRx");

				describeEniMonitorDataResponse_monitorData.Add(eniMonitorData);
			}
			describeEniMonitorDataResponse.MonitorData = describeEniMonitorDataResponse_monitorData;
        
			return describeEniMonitorDataResponse;
        }
    }
}
