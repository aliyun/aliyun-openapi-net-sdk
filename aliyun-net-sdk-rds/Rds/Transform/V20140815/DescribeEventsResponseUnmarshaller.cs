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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeEventsResponseUnmarshaller
    {
        public static DescribeEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventsResponse describeEventsResponse = new DescribeEventsResponse();

			describeEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeEventsResponse.RequestId = _ctx.StringValue("DescribeEvents.RequestId");
			describeEventsResponse.TotalRecordCount = _ctx.IntegerValue("DescribeEvents.TotalRecordCount");
			describeEventsResponse.PageSize = _ctx.IntegerValue("DescribeEvents.PageSize");
			describeEventsResponse.PageNumber = _ctx.IntegerValue("DescribeEvents.PageNumber");

			List<DescribeEventsResponse.DescribeEvents_EventItemsItem> describeEventsResponse_eventItems = new List<DescribeEventsResponse.DescribeEvents_EventItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeEvents.EventItems.Length"); i++) {
				DescribeEventsResponse.DescribeEvents_EventItemsItem eventItemsItem = new DescribeEventsResponse.DescribeEvents_EventItemsItem();
				eventItemsItem.EventId = _ctx.IntegerValue("DescribeEvents.EventItems["+ i +"].EventId");
				eventItemsItem.EventType = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventType");
				eventItemsItem.EventName = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventName");
				eventItemsItem.EventTime = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventTime");
				eventItemsItem.ResourceType = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].ResourceType");
				eventItemsItem.ResourceName = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].ResourceName");
				eventItemsItem.RegionId = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].RegionId");
				eventItemsItem.EventUserType = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventUserType");
				eventItemsItem.EventReason = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventReason");
				eventItemsItem.EventPayload = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventPayload");
				eventItemsItem.EventRecordTime = _ctx.StringValue("DescribeEvents.EventItems["+ i +"].EventRecordTime");

				describeEventsResponse_eventItems.Add(eventItemsItem);
			}
			describeEventsResponse.EventItems = describeEventsResponse_eventItems;
        
			return describeEventsResponse;
        }
    }
}
