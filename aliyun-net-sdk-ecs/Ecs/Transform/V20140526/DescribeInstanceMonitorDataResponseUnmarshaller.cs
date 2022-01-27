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
        public static DescribeInstanceMonitorDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceMonitorDataResponse describeInstanceMonitorDataResponse = new DescribeInstanceMonitorDataResponse();

			describeInstanceMonitorDataResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceMonitorDataResponse.RequestId = _ctx.StringValue("DescribeInstanceMonitorData.RequestId");

			List<DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData> describeInstanceMonitorDataResponse_monitorData = new List<DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceMonitorData.MonitorData.Length"); i++) {
				DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData instanceMonitorData = new DescribeInstanceMonitorDataResponse.DescribeInstanceMonitorData_InstanceMonitorData();
				instanceMonitorData.CPUCreditBalance = _ctx.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUCreditBalance");
				instanceMonitorData.BPSRead = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].BPSRead");
				instanceMonitorData.InternetTX = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InternetTX");
				instanceMonitorData.CPU = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPU");
				instanceMonitorData.CPUCreditUsage = _ctx.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUCreditUsage");
				instanceMonitorData.IOPSWrite = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IOPSWrite");
				instanceMonitorData.IntranetTX = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IntranetTX");
				instanceMonitorData.InstanceId = _ctx.StringValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InstanceId");
				instanceMonitorData.BPSWrite = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].BPSWrite");
				instanceMonitorData.CPUNotpaidSurplusCreditUsage = _ctx.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUNotpaidSurplusCreditUsage");
				instanceMonitorData.CPUAdvanceCreditBalance = _ctx.FloatValue("DescribeInstanceMonitorData.MonitorData["+ i +"].CPUAdvanceCreditBalance");
				instanceMonitorData.IOPSRead = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IOPSRead");
				instanceMonitorData.InternetBandwidth = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InternetBandwidth");
				instanceMonitorData.InternetRX = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].InternetRX");
				instanceMonitorData.TimeStamp = _ctx.StringValue("DescribeInstanceMonitorData.MonitorData["+ i +"].TimeStamp");
				instanceMonitorData.IntranetRX = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IntranetRX");
				instanceMonitorData.IntranetBandwidth = _ctx.IntegerValue("DescribeInstanceMonitorData.MonitorData["+ i +"].IntranetBandwidth");

				describeInstanceMonitorDataResponse_monitorData.Add(instanceMonitorData);
			}
			describeInstanceMonitorDataResponse.MonitorData = describeInstanceMonitorDataResponse_monitorData;
        
			return describeInstanceMonitorDataResponse;
        }
    }
}
