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
using Aliyun.Acs.Actiontrail.Model.V20200706;

namespace Aliyun.Acs.Actiontrail.Transform.V20200706
{
    public class GetAccessKeyLastUsedEventsResponseUnmarshaller
    {
        public static GetAccessKeyLastUsedEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetAccessKeyLastUsedEventsResponse getAccessKeyLastUsedEventsResponse = new GetAccessKeyLastUsedEventsResponse();

			getAccessKeyLastUsedEventsResponse.HttpResponse = _ctx.HttpResponse;
			getAccessKeyLastUsedEventsResponse.RequestId = _ctx.StringValue("GetAccessKeyLastUsedEvents.RequestId");
			getAccessKeyLastUsedEventsResponse.NextToken = _ctx.StringValue("GetAccessKeyLastUsedEvents.NextToken");

			List<GetAccessKeyLastUsedEventsResponse.GetAccessKeyLastUsedEvents_EventsItem> getAccessKeyLastUsedEventsResponse_events = new List<GetAccessKeyLastUsedEventsResponse.GetAccessKeyLastUsedEvents_EventsItem>();
			for (int i = 0; i < _ctx.Length("GetAccessKeyLastUsedEvents.Events.Length"); i++) {
				GetAccessKeyLastUsedEventsResponse.GetAccessKeyLastUsedEvents_EventsItem eventsItem = new GetAccessKeyLastUsedEventsResponse.GetAccessKeyLastUsedEvents_EventsItem();
				eventsItem.UsedTimestamp = _ctx.LongValue("GetAccessKeyLastUsedEvents.Events["+ i +"].UsedTimestamp");
				eventsItem.Detail = _ctx.StringValue("GetAccessKeyLastUsedEvents.Events["+ i +"].Detail");
				eventsItem.EventName = _ctx.StringValue("GetAccessKeyLastUsedEvents.Events["+ i +"].EventName");
				eventsItem.Source = _ctx.StringValue("GetAccessKeyLastUsedEvents.Events["+ i +"].Source");

				getAccessKeyLastUsedEventsResponse_events.Add(eventsItem);
			}
			getAccessKeyLastUsedEventsResponse.Events = getAccessKeyLastUsedEventsResponse_events;
        
			return getAccessKeyLastUsedEventsResponse;
        }
    }
}
