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
    public class DescribeInstancesFullStatusResponseUnmarshaller
    {
        public static DescribeInstancesFullStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesFullStatusResponse describeInstancesFullStatusResponse = new DescribeInstancesFullStatusResponse();

			describeInstancesFullStatusResponse.HttpResponse = context.HttpResponse;
			describeInstancesFullStatusResponse.RequestId = context.StringValue("DescribeInstancesFullStatus.RequestId");
			describeInstancesFullStatusResponse.TotalCount = context.IntegerValue("DescribeInstancesFullStatus.TotalCount");
			describeInstancesFullStatusResponse.PageNumber = context.IntegerValue("DescribeInstancesFullStatus.PageNumber");
			describeInstancesFullStatusResponse.PageSize = context.IntegerValue("DescribeInstancesFullStatus.PageSize");

			List<DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType> describeInstancesFullStatusResponse_instanceFullStatusSet = new List<DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType>();
			for (int i = 0; i < context.Length("DescribeInstancesFullStatus.InstanceFullStatusSet.Length"); i++) {
				DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType instanceFullStatusType = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType();
				instanceFullStatusType.InstanceId = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].InstanceId");

				DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_Status status = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_Status();
				status.Code = context.IntegerValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].Status.Code");
				status.Name = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].Status.Name");
				instanceFullStatusType.Status = status;

				DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_HealthStatus healthStatus = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_HealthStatus();
				healthStatus.Code = context.IntegerValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].HealthStatus.Code");
				healthStatus.Name = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].HealthStatus.Name");
				instanceFullStatusType.HealthStatus = healthStatus;

				List<DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType> instanceFullStatusType_scheduledSystemEventSet = new List<DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType>();
				for (int j = 0; j < context.Length("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet.Length"); j++) {
					DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType scheduledSystemEventType = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType();
					scheduledSystemEventType.EventId = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].EventId");
					scheduledSystemEventType.EventPublishTime = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].EventPublishTime");
					scheduledSystemEventType.NotBefore = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].NotBefore");
					scheduledSystemEventType.Reason = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].Reason");
					scheduledSystemEventType.ImpactLevel = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ImpactLevel");

					DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_EventCycleStatus eventCycleStatus = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_EventCycleStatus();
					eventCycleStatus.Code = context.IntegerValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].EventCycleStatus.Code");
					eventCycleStatus.Name = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].EventCycleStatus.Name");
					scheduledSystemEventType.EventCycleStatus = eventCycleStatus;

					DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_EventType eventType = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_EventType();
					eventType.Code = context.IntegerValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].EventType.Code");
					eventType.Name = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].EventType.Name");
					scheduledSystemEventType.EventType = eventType;

					DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_ExtendedAttribute extendedAttribute = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_ExtendedAttribute();
					extendedAttribute.DiskId = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.DiskId");
					extendedAttribute.Device = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.Device");

					List<DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_ExtendedAttribute.DescribeInstancesFullStatus_InactiveDisk> extendedAttribute_inactiveDisks = new List<DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_ExtendedAttribute.DescribeInstancesFullStatus_InactiveDisk>();
					for (int k = 0; k < context.Length("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.InactiveDisks.Length"); k++) {
						DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_ExtendedAttribute.DescribeInstancesFullStatus_InactiveDisk inactiveDisk = new DescribeInstancesFullStatusResponse.DescribeInstancesFullStatus_InstanceFullStatusType.DescribeInstancesFullStatus_ScheduledSystemEventType.DescribeInstancesFullStatus_ExtendedAttribute.DescribeInstancesFullStatus_InactiveDisk();
						inactiveDisk.CreationTime = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.InactiveDisks["+ k +"].CreationTime");
						inactiveDisk.ReleaseTime = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.InactiveDisks["+ k +"].ReleaseTime");
						inactiveDisk.DeviceType = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.InactiveDisks["+ k +"].DeviceType");
						inactiveDisk.DeviceCategory = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.InactiveDisks["+ k +"].DeviceCategory");
						inactiveDisk.DeviceSize = context.StringValue("DescribeInstancesFullStatus.InstanceFullStatusSet["+ i +"].ScheduledSystemEventSet["+ j +"].ExtendedAttribute.InactiveDisks["+ k +"].DeviceSize");

						extendedAttribute_inactiveDisks.Add(inactiveDisk);
					}
					extendedAttribute.InactiveDisks = extendedAttribute_inactiveDisks;
					scheduledSystemEventType.ExtendedAttribute = extendedAttribute;

					instanceFullStatusType_scheduledSystemEventSet.Add(scheduledSystemEventType);
				}
				instanceFullStatusType.ScheduledSystemEventSet = instanceFullStatusType_scheduledSystemEventSet;

				describeInstancesFullStatusResponse_instanceFullStatusSet.Add(instanceFullStatusType);
			}
			describeInstancesFullStatusResponse.InstanceFullStatusSet = describeInstancesFullStatusResponse_instanceFullStatusSet;
        
			return describeInstancesFullStatusResponse;
        }
    }
}
