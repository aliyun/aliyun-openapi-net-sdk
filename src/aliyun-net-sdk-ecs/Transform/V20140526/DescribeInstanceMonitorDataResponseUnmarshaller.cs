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
    public class DescribeInstanceMonitorDataResponseUnmarshaller
    {
        public static DescribeInstanceMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeInstanceMonitorDataResponse describeInstanceMonitorDataResponse = new DescribeInstanceMonitorDataResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeInstanceMonitorData.RequestId")
            };
            List<DescribeInstanceMonitorDataResponse.InstanceMonitorData> monitorData = new List<DescribeInstanceMonitorDataResponse.InstanceMonitorData>();
			for (int i = 0; i < context.Length("DescribeInstanceMonitorData.MonitorData.Length"); i++) {
                DescribeInstanceMonitorDataResponse.InstanceMonitorData instanceMonitorData = new DescribeInstanceMonitorDataResponse.InstanceMonitorData()
                {
                    InstanceId = context.StringValue($"DescribeInstanceMonitorData.MonitorData[{i}].InstanceId"),
                    Cpu = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].CPU"),
                    IntranetRx = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].IntranetRX"),
                    IntranetTx = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].IntranetTX"),
                    IntranetBandwidth = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].IntranetBandwidth"),
                    InternetRx = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].InternetRX"),
                    InternetTx = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].InternetTX"),
                    InternetBandwidth = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].InternetBandwidth"),
                    IopsRead = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].IOPSRead"),
                    IopsWrite = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].IOPSWrite"),
                    BpsRead = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].BPSRead"),
                    BpsWrite = context.IntegerValue($"DescribeInstanceMonitorData.MonitorData[{i}].BPSWrite"),
                    TimeStamp = context.StringValue($"DescribeInstanceMonitorData.MonitorData[{i}].TimeStamp")
                };
                monitorData.Add(instanceMonitorData);
			}
			describeInstanceMonitorDataResponse.MonitorData = monitorData;
        
			return describeInstanceMonitorDataResponse;
        }
    }
}