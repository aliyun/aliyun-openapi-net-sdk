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
    public class DescribeSnapshotMonitorDataResponseUnmarshaller
    {
        public static DescribeSnapshotMonitorDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnapshotMonitorDataResponse describeSnapshotMonitorDataResponse = new DescribeSnapshotMonitorDataResponse();

			describeSnapshotMonitorDataResponse.HttpResponse = context.HttpResponse;
			describeSnapshotMonitorDataResponse.RequestId = context.StringValue("DescribeSnapshotMonitorData.RequestId");

			List<DescribeSnapshotMonitorDataResponse.DescribeSnapshotMonitorData_DataPoint> describeSnapshotMonitorDataResponse_monitorData = new List<DescribeSnapshotMonitorDataResponse.DescribeSnapshotMonitorData_DataPoint>();
			for (int i = 0; i < context.Length("DescribeSnapshotMonitorData.MonitorData.Length"); i++) {
				DescribeSnapshotMonitorDataResponse.DescribeSnapshotMonitorData_DataPoint dataPoint = new DescribeSnapshotMonitorDataResponse.DescribeSnapshotMonitorData_DataPoint();
				dataPoint.TimeStamp = context.StringValue("DescribeSnapshotMonitorData.MonitorData["+ i +"].TimeStamp");
				dataPoint.Size = context.LongValue("DescribeSnapshotMonitorData.MonitorData["+ i +"].Size");

				describeSnapshotMonitorDataResponse_monitorData.Add(dataPoint);
			}
			describeSnapshotMonitorDataResponse.MonitorData = describeSnapshotMonitorDataResponse_monitorData;
        
			return describeSnapshotMonitorDataResponse;
        }
    }
}
