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
    public class DescribeDiskMonitorDataResponseUnmarshaller
    {
        public static DescribeDiskMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDiskMonitorDataResponse describeDiskMonitorDataResponse = new DescribeDiskMonitorDataResponse();

			describeDiskMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeDiskMonitorDataResponse.RequestId = context.StringValue("DescribeDiskMonitorData.RequestId");
			describeDiskMonitorDataResponse.TotalCount = context.IntegerValue("DescribeDiskMonitorData.TotalCount");

			List<DescribeDiskMonitorDataResponse.DescribeDiskMonitorData_DiskMonitorData> describeDiskMonitorDataResponse_monitorData = new List<DescribeDiskMonitorDataResponse.DescribeDiskMonitorData_DiskMonitorData>();
			for (int i = 0; i < context.Length("DescribeDiskMonitorData.MonitorData.Length"); i++) {
				DescribeDiskMonitorDataResponse.DescribeDiskMonitorData_DiskMonitorData diskMonitorData = new DescribeDiskMonitorDataResponse.DescribeDiskMonitorData_DiskMonitorData();
				diskMonitorData.DiskId = context.StringValue("DescribeDiskMonitorData.MonitorData["+ i +"].DiskId");
				diskMonitorData.IOPSRead = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].IOPSRead");
				diskMonitorData.IOPSWrite = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].IOPSWrite");
				diskMonitorData.IOPSTotal = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].IOPSTotal");
				diskMonitorData.BPSRead = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].BPSRead");
				diskMonitorData.BPSWrite = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].BPSWrite");
				diskMonitorData.BPSTotal = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].BPSTotal");
				diskMonitorData.LatencyRead = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].LatencyRead");
				diskMonitorData.LatencyWrite = context.IntegerValue("DescribeDiskMonitorData.MonitorData["+ i +"].LatencyWrite");
				diskMonitorData.TimeStamp = context.StringValue("DescribeDiskMonitorData.MonitorData["+ i +"].TimeStamp");

				describeDiskMonitorDataResponse_monitorData.Add(diskMonitorData);
			}
			describeDiskMonitorDataResponse.MonitorData = describeDiskMonitorDataResponse_monitorData;
        
			return describeDiskMonitorDataResponse;
        }
    }
}
