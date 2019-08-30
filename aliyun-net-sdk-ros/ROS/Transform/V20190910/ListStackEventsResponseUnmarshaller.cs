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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListStackEventsResponseUnmarshaller
    {
        public static ListStackEventsResponse Unmarshall(UnmarshallerContext context)
        {
			ListStackEventsResponse listStackEventsResponse = new ListStackEventsResponse();

			listStackEventsResponse.HttpResponse = context.HttpResponse;
			listStackEventsResponse.PageNumber = context.IntegerValue("ListStackEvents.PageNumber");
			listStackEventsResponse.PageSize = context.IntegerValue("ListStackEvents.PageSize");
			listStackEventsResponse.RequestId = context.StringValue("ListStackEvents.RequestId");
			listStackEventsResponse.TotalCount = context.IntegerValue("ListStackEvents.TotalCount");

			List<ListStackEventsResponse.ListStackEvents__Event> listStackEventsResponse_events = new List<ListStackEventsResponse.ListStackEvents__Event>();
			for (int i = 0; i < context.Length("ListStackEvents.Events.Length"); i++) {
				ListStackEventsResponse.ListStackEvents__Event _event = new ListStackEventsResponse.ListStackEvents__Event();
				_event.CreateTime = context.StringValue("ListStackEvents.Events["+ i +"].CreateTime");
				_event.EventId = context.StringValue("ListStackEvents.Events["+ i +"].EventId");
				_event.LogicalResourceId = context.StringValue("ListStackEvents.Events["+ i +"].LogicalResourceId");
				_event.PhysicalResourceId = context.StringValue("ListStackEvents.Events["+ i +"].PhysicalResourceId");
				_event.ResourceType = context.StringValue("ListStackEvents.Events["+ i +"].ResourceType");
				_event.StackId = context.StringValue("ListStackEvents.Events["+ i +"].StackId");
				_event.StackName = context.StringValue("ListStackEvents.Events["+ i +"].StackName");
				_event.Status = context.StringValue("ListStackEvents.Events["+ i +"].Status");
				_event.StatusReason = context.StringValue("ListStackEvents.Events["+ i +"].StatusReason");

				listStackEventsResponse_events.Add(_event);
			}
			listStackEventsResponse.Events = listStackEventsResponse_events;
        
			return listStackEventsResponse;
        }
    }
}
