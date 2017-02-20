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
using Aliyun.Acs.Ecs.Model.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDiskMonitorDataResponseUnmarshaller
    {
        public static DescribeDiskMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDiskMonitorDataResponse describeDiskMonitorDataResponse = new DescribeDiskMonitorDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDiskMonitorData.RequestId"),
                TotalCount = context.IntegerValue("DescribeDiskMonitorData.TotalCount")
            };
            List<DescribeDiskMonitorDataResponse.DiskMonitorData> monitorData = new List<DescribeDiskMonitorDataResponse.DiskMonitorData>();
			for (int i = 0; i < context.Length("DescribeDiskMonitorData.MonitorData.Length"); i++) {
                DescribeDiskMonitorDataResponse.DiskMonitorData diskMonitorData = new DescribeDiskMonitorDataResponse.DiskMonitorData()
                {
                    DiskId = context.StringValue($"DescribeDiskMonitorData.MonitorData[{i}].DiskId"),
                    IopsRead = context.IntegerValue($"DescribeDiskMonitorData.MonitorData[{i}].IOPSRead"),
                    IopsWrite = context.IntegerValue($"DescribeDiskMonitorData.MonitorData[{i}].IOPSWrite"),
                    IopsTotal = context.IntegerValue($"DescribeDiskMonitorData.MonitorData[{i}].IOPSTotal"),
                    BpsRead = context.IntegerValue($"DescribeDiskMonitorData.MonitorData[{i}].BPSRead"),
                    BpsWrite = context.IntegerValue($"DescribeDiskMonitorData.MonitorData[{i}].BPSWrite"),
                    BpsTotal = context.IntegerValue($"DescribeDiskMonitorData.MonitorData[{i}].BPSTotal"),
                    TimeStamp = context.StringValue($"DescribeDiskMonitorData.MonitorData[{i}].TimeStamp")
                };
                monitorData.Add(diskMonitorData);
			}
			describeDiskMonitorDataResponse.MonitorData = monitorData;
        
			return describeDiskMonitorDataResponse;
        }
    }
}