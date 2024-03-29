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
    public class DescribeInstanceHistoryEventsResponseUnmarshaller
    {
        public static DescribeInstanceHistoryEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceHistoryEventsResponse describeInstanceHistoryEventsResponse = new DescribeInstanceHistoryEventsResponse();

			describeInstanceHistoryEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceHistoryEventsResponse.PageSize = _ctx.IntegerValue("DescribeInstanceHistoryEvents.PageSize");
			describeInstanceHistoryEventsResponse.RequestId = _ctx.StringValue("DescribeInstanceHistoryEvents.RequestId");
			describeInstanceHistoryEventsResponse.PageNumber = _ctx.IntegerValue("DescribeInstanceHistoryEvents.PageNumber");
			describeInstanceHistoryEventsResponse.TotalCount = _ctx.IntegerValue("DescribeInstanceHistoryEvents.TotalCount");

			List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType> describeInstanceHistoryEventsResponse_instanceSystemEventSet = new List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceHistoryEvents.InstanceSystemEventSet.Length"); i++) {
				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType instanceSystemEventType = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType();
				instanceSystemEventType.EventId = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventId");
				instanceSystemEventType.EventPublishTime = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventPublishTime");
				instanceSystemEventType.EventFinishTime = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventFinishTime");
				instanceSystemEventType.ResourceType = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ResourceType");
				instanceSystemEventType.ImpactLevel = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ImpactLevel");
				instanceSystemEventType.NotBefore = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].NotBefore");
				instanceSystemEventType.InstanceId = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].InstanceId");
				instanceSystemEventType.Reason = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].Reason");

				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventType eventType = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventType();
				eventType.Name = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventType.Name");
				eventType.Code = _ctx.IntegerValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventType.Code");
				instanceSystemEventType.EventType = eventType;

				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventCycleStatus eventCycleStatus = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventCycleStatus();
				eventCycleStatus.Name = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventCycleStatus.Name");
				eventCycleStatus.Code = _ctx.IntegerValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventCycleStatus.Code");
				instanceSystemEventType.EventCycleStatus = eventCycleStatus;

				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute extendedAttribute = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute();
				extendedAttribute.Device = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.Device");
				extendedAttribute.DiskId = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.DiskId");
				extendedAttribute.HostType = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.HostType");
				extendedAttribute.HostId = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.HostId");
				extendedAttribute.OnlineRepairPolicy = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.OnlineRepairPolicy");
				extendedAttribute.Rack = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.Rack");

				List<string> extendedAttribute_migrationOptions = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.MigrationOptions.Length"); j++) {
					extendedAttribute_migrationOptions.Add(_ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.MigrationOptions["+ j +"]"));
				}
				extendedAttribute.MigrationOptions = extendedAttribute_migrationOptions;

				List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk> extendedAttribute_inactiveDisks = new List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks.Length"); j++) {
					DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk inactiveDisk = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk();
					inactiveDisk.CreationTime = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].CreationTime");
					inactiveDisk.DeviceSize = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].DeviceSize");
					inactiveDisk.DeviceCategory = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].DeviceCategory");
					inactiveDisk.DeviceType = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].DeviceType");
					inactiveDisk.ReleaseTime = _ctx.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].ReleaseTime");

					extendedAttribute_inactiveDisks.Add(inactiveDisk);
				}
				extendedAttribute.InactiveDisks = extendedAttribute_inactiveDisks;
				instanceSystemEventType.ExtendedAttribute = extendedAttribute;

				describeInstanceHistoryEventsResponse_instanceSystemEventSet.Add(instanceSystemEventType);
			}
			describeInstanceHistoryEventsResponse.InstanceSystemEventSet = describeInstanceHistoryEventsResponse_instanceSystemEventSet;
        
			return describeInstanceHistoryEventsResponse;
        }
    }
}
