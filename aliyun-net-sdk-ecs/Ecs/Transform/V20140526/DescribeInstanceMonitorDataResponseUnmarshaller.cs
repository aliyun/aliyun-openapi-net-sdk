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
    public class DescribeInstanceMonitorDataResponseUnmarshaller
    {
        public static DescribeInstanceMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceMonitorDataResponse describeInstanceMonitorDataResponse = new DescribeInstanceMonitorDataResponse();

			describeInstanceMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeInstanceMonitorDataResponse.RequestId = context.StringValue("DescribeInstanceMonitorData.RequestId");

			List<DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData> describeInstanceMonitorDataResponse_monitorData = new List<DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData>();
			for (int i = 0; i < context.Length("DescribeInstanceMonitorData.MonitorData.Length"); i++) {
				DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData instanceMonitorData = new DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData();
				instanceMonitorData.InstanceId = context.StringValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InstanceId");
				instanceMonitorData.CPU = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPU");
				instanceMonitorData.IntranetRX = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IntranetRX");
				instanceMonitorData.IntranetTX = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IntranetTX");
				instanceMonitorData.IntranetBandwidth = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IntranetBandwidth");
				instanceMonitorData.InternetRX = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InternetRX");
				instanceMonitorData.InternetTX = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InternetTX");
				instanceMonitorData.InternetBandwidth = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InternetBandwidth");
				instanceMonitorData.IOPSRead = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IOPSRead");
				instanceMonitorData.IOPSWrite = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IOPSWrite");
				instanceMonitorData.BPSRead = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].BPSRead");
				instanceMonitorData.BPSWrite = context.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].BPSWrite");
				instanceMonitorData.CPUCreditUsage = context.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUCreditUsage");
				instanceMonitorData.CPUCreditBalance = context.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUCreditBalance");
				instanceMonitorData.CPUAdvanceCreditBalance = context.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUAdvanceCreditBalance");
				instanceMonitorData.CPUNotpaidSurplusCreditUsage = context.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUNotpaidSurplusCreditUsage");
				instanceMonitorData.TimeStamp = context.StringValue("DescribeInstanceMonitorData.MonitorData["+ i +"].TimeStamp");

				describeInstanceMonitorDataResponse_monitorData.Add(instanceMonitorData);
			}
			describeInstanceMonitorDataResponse.MonitorData = describeInstanceMonitorDataResponse_monitorData;
        
			return describeInstanceMonitorDataResponse;
        }
    }
}
