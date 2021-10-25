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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListDiskOpsEventsResponseUnmarshaller
    {
        public static ListDiskOpsEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDiskOpsEventsResponse listDiskOpsEventsResponse = new ListDiskOpsEventsResponse();

			listDiskOpsEventsResponse.HttpResponse = _ctx.HttpResponse;
			listDiskOpsEventsResponse.RequestId = _ctx.StringValue("ListDiskOpsEvents.RequestId");
			listDiskOpsEventsResponse.PageNumber = _ctx.IntegerValue("ListDiskOpsEvents.PageNumber");
			listDiskOpsEventsResponse.PageSize = _ctx.IntegerValue("ListDiskOpsEvents.PageSize");
			listDiskOpsEventsResponse.TotalCount = _ctx.IntegerValue("ListDiskOpsEvents.TotalCount");

			List<ListDiskOpsEventsResponse.ListDiskOpsEvents_DiskOpsEventInfo> listDiskOpsEventsResponse_eventList = new List<ListDiskOpsEventsResponse.ListDiskOpsEvents_DiskOpsEventInfo>();
			for (int i = 0; i < _ctx.Length("ListDiskOpsEvents.EventList.Length"); i++) {
				ListDiskOpsEventsResponse.ListDiskOpsEvents_DiskOpsEventInfo diskOpsEventInfo = new ListDiskOpsEventsResponse.ListDiskOpsEvents_DiskOpsEventInfo();
				diskOpsEventInfo.RegionId = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].RegionId");
				diskOpsEventInfo.UserId = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].UserId");
				diskOpsEventInfo.ClusterBizId = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].ClusterBizId");
				diskOpsEventInfo.ClusterName = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].ClusterName");
				diskOpsEventInfo.InstanceId = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].InstanceId");
				diskOpsEventInfo.InstanceName = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].InstanceName");
				diskOpsEventInfo.InstanceStatus = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].InstanceStatus");
				diskOpsEventInfo.PrivateIp = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].PrivateIp");
				diskOpsEventInfo.DiskId = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].DiskId");
				diskOpsEventInfo.DiskDevice = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].DiskDevice");
				diskOpsEventInfo.DiskMountPoint = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].DiskMountPoint");
				diskOpsEventInfo.EventId = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].EventId");
				diskOpsEventInfo.EventType = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].EventType");
				diskOpsEventInfo.EventTriggerTime = _ctx.LongValue("ListDiskOpsEvents.EventList["+ i +"].EventTriggerTime");
				diskOpsEventInfo.CurrentActivity = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].CurrentActivity");
				diskOpsEventInfo.CurrentActivityState = _ctx.StringValue("ListDiskOpsEvents.EventList["+ i +"].CurrentActivityState");

				listDiskOpsEventsResponse_eventList.Add(diskOpsEventInfo);
			}
			listDiskOpsEventsResponse.EventList = listDiskOpsEventsResponse_eventList;
        
			return listDiskOpsEventsResponse;
        }
    }
}
