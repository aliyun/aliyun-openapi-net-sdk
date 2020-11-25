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
    public class DescribeDisksFullStatusResponseUnmarshaller
    {
        public static DescribeDisksFullStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDisksFullStatusResponse describeDisksFullStatusResponse = new DescribeDisksFullStatusResponse();

			describeDisksFullStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeDisksFullStatusResponse.RequestId = _ctx.StringValue("DescribeDisksFullStatus.RequestId");
			describeDisksFullStatusResponse.TotalCount = _ctx.IntegerValue("DescribeDisksFullStatus.TotalCount");
			describeDisksFullStatusResponse.PageNumber = _ctx.IntegerValue("DescribeDisksFullStatus.PageNumber");
			describeDisksFullStatusResponse.PageSize = _ctx.IntegerValue("DescribeDisksFullStatus.PageSize");

			List<DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType> describeDisksFullStatusResponse_diskFullStatusSet = new List<DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType>();
			for (int i = 0; i < _ctx.Length("DescribeDisksFullStatus.DiskFullStatusSet.Length"); i++) {
				DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType diskFullStatusType = new DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType();
				diskFullStatusType.DiskId = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskId");
				diskFullStatusType.InstanceId = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].InstanceId");
				diskFullStatusType.Device = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].Device");

				DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_Status status = new DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_Status();
				status.Code = _ctx.IntegerValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].Status.Code");
				status.Name = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].Status.Name");
				diskFullStatusType.Status = status;

				DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_HealthStatus healthStatus = new DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_HealthStatus();
				healthStatus.Code = _ctx.IntegerValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].HealthStatus.Code");
				healthStatus.Name = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].HealthStatus.Name");
				diskFullStatusType.HealthStatus = healthStatus;

				List<DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_DiskEventType> diskFullStatusType_diskEventSet = new List<DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_DiskEventType>();
				for (int j = 0; j < _ctx.Length("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet.Length"); j++) {
					DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_DiskEventType diskEventType = new DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_DiskEventType();
					diskEventType.EventId = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet["+ j +"].EventId");
					diskEventType.EventTime = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet["+ j +"].EventTime");
					diskEventType.EventEndTime = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet["+ j +"].EventEndTime");
					diskEventType.ImpactLevel = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet["+ j +"].ImpactLevel");

					DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_DiskEventType.DescribeDisksFullStatus_EventType eventType = new DescribeDisksFullStatusResponse.DescribeDisksFullStatus_DiskFullStatusType.DescribeDisksFullStatus_DiskEventType.DescribeDisksFullStatus_EventType();
					eventType.Code = _ctx.IntegerValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet["+ j +"].EventType.Code");
					eventType.Name = _ctx.StringValue("DescribeDisksFullStatus.DiskFullStatusSet["+ i +"].DiskEventSet["+ j +"].EventType.Name");
					diskEventType.EventType = eventType;

					diskFullStatusType_diskEventSet.Add(diskEventType);
				}
				diskFullStatusType.DiskEventSet = diskFullStatusType_diskEventSet;

				describeDisksFullStatusResponse_diskFullStatusSet.Add(diskFullStatusType);
			}
			describeDisksFullStatusResponse.DiskFullStatusSet = describeDisksFullStatusResponse_diskFullStatusSet;
        
			return describeDisksFullStatusResponse;
        }
    }
}
