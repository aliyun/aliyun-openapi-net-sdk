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
        public static DescribeInstanceHistoryEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceHistoryEventsResponse describeInstanceHistoryEventsResponse = new DescribeInstanceHistoryEventsResponse();

			describeInstanceHistoryEventsResponse.HttpResponse = context.HttpResponse;
			describeInstanceHistoryEventsResponse.RequestId = context.StringValue("DescribeInstanceHistoryEvents.RequestId");
			describeInstanceHistoryEventsResponse.TotalCount = context.IntegerValue("DescribeInstanceHistoryEvents.TotalCount");
			describeInstanceHistoryEventsResponse.PageNumber = context.IntegerValue("DescribeInstanceHistoryEvents.PageNumber");
			describeInstanceHistoryEventsResponse.PageSize = context.IntegerValue("DescribeInstanceHistoryEvents.PageSize");

			List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType> describeInstanceHistoryEventsResponse_instanceSystemEventSet = new List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType>();
			for (int i = 0; i < context.Length("DescribeInstanceHistoryEvents.InstanceSystemEventSet.Length"); i++) {
				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType instanceSystemEventType = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType();
				instanceSystemEventType.InstanceId = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].InstanceId");
				instanceSystemEventType.EventId = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventId");
				instanceSystemEventType.EventPublishTime = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventPublishTime");
				instanceSystemEventType.NotBefore = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].NotBefore");
				instanceSystemEventType.EventFinishTime = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventFinishTime");
				instanceSystemEventType.Reason = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].Reason");
				instanceSystemEventType.ImpactLevel = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ImpactLevel");

				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventType eventType = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventType();
				eventType.Code = context.IntegerValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventType.Code");
				eventType.Name = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventType.Name");
				instanceSystemEventType.EventType = eventType;

				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventCycleStatus eventCycleStatus = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_EventCycleStatus();
				eventCycleStatus.Code = context.IntegerValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventCycleStatus.Code");
				eventCycleStatus.Name = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].EventCycleStatus.Name");
				instanceSystemEventType.EventCycleStatus = eventCycleStatus;

				DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute extendedAttribute = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute();
				extendedAttribute.DiskId = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.DiskId");
				extendedAttribute.Device = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.Device");

				List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk> extendedAttribute_inactiveDisks = new List<DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk>();
				for (int j = 0; j < context.Length("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks.Length"); j++) {
					DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk inactiveDisk = new DescribeInstanceHistoryEventsResponse.DescribeInstanceHistoryEvents_InstanceSystemEventType.DescribeInstanceHistoryEvents_ExtendedAttribute.DescribeInstanceHistoryEvents_InactiveDisk();
					inactiveDisk.CreationTime = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].CreationTime");
					inactiveDisk.ReleaseTime = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].ReleaseTime");
					inactiveDisk.DeviceType = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].DeviceType");
					inactiveDisk.DeviceCategory = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].DeviceCategory");
					inactiveDisk.DeviceSize = context.StringValue("DescribeInstanceHistoryEvents.InstanceSystemEventSet["+ i +"].ExtendedAttribute.InactiveDisks["+ j +"].DeviceSize");

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
