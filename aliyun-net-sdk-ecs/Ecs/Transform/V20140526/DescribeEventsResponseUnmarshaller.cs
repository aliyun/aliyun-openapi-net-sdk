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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeEventsResponseUnmarshaller
    {
        public static DescribeEventsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeEventsResponse describeEventsResponse = new DescribeEventsResponse();

			describeEventsResponse.HttpResponse = context.HttpResponse;
			describeEventsResponse.RequestId = context.StringValue("DescribeEvents.RequestId");
			describeEventsResponse.PageNumber = context.IntegerValue("DescribeEvents.PageNumber");
			describeEventsResponse.PageSize = context.IntegerValue("DescribeEvents.PageSize");
			describeEventsResponse.TotalCount = context.IntegerValue("DescribeEvents.TotalCount");

			List<DescribeEventsResponse.DescribeEvents__Event> describeEventsResponse_events = new List<DescribeEventsResponse.DescribeEvents__Event>();
			for (int i = 0; i < context.Length("DescribeEvents.Events.Length"); i++) {
				DescribeEventsResponse.DescribeEvents__Event _event = new DescribeEventsResponse.DescribeEvents__Event();
				_event.ResourceId = context.StringValue("DescribeEvents.Events["+ i +"].ResourceId");
				_event.EventType = context.StringValue("DescribeEvents.Events["+ i +"].EventType");
				_event.EventCategory = context.StringValue("DescribeEvents.Events["+ i +"].EventCategory");
				_event.Status = context.StringValue("DescribeEvents.Events["+ i +"].Status");
				_event.SupportModify = context.StringValue("DescribeEvents.Events["+ i +"].SupportModify");
				_event.PlanTime = context.StringValue("DescribeEvents.Events["+ i +"].PlanTime");
				_event.ExpireTime = context.StringValue("DescribeEvents.Events["+ i +"].ExpireTime");
				_event.EventId = context.StringValue("DescribeEvents.Events["+ i +"].EventId");

				describeEventsResponse_events.Add(_event);
			}
			describeEventsResponse.Events = describeEventsResponse_events;
        
			return describeEventsResponse;
        }
    }
}