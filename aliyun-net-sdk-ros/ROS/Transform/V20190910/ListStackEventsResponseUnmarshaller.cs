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
        public static ListStackEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStackEventsResponse listStackEventsResponse = new ListStackEventsResponse();

			listStackEventsResponse.HttpResponse = _ctx.HttpResponse;
			listStackEventsResponse.PageNumber = _ctx.IntegerValue("ListStackEvents.PageNumber");
			listStackEventsResponse.PageSize = _ctx.IntegerValue("ListStackEvents.PageSize");
			listStackEventsResponse.RequestId = _ctx.StringValue("ListStackEvents.RequestId");
			listStackEventsResponse.TotalCount = _ctx.IntegerValue("ListStackEvents.TotalCount");

			List<ListStackEventsResponse.ListStackEvents__Event> listStackEventsResponse_events = new List<ListStackEventsResponse.ListStackEvents__Event>();
			for (int i = 0; i < _ctx.Length("ListStackEvents.Events.Length"); i++) {
				ListStackEventsResponse.ListStackEvents__Event _event = new ListStackEventsResponse.ListStackEvents__Event();
				_event.CreateTime = _ctx.StringValue("ListStackEvents.Events["+ i +"].CreateTime");
				_event.EventId = _ctx.StringValue("ListStackEvents.Events["+ i +"].EventId");
				_event.LogicalResourceId = _ctx.StringValue("ListStackEvents.Events["+ i +"].LogicalResourceId");
				_event.PhysicalResourceId = _ctx.StringValue("ListStackEvents.Events["+ i +"].PhysicalResourceId");
				_event.ResourceType = _ctx.StringValue("ListStackEvents.Events["+ i +"].ResourceType");
				_event.StackId = _ctx.StringValue("ListStackEvents.Events["+ i +"].StackId");
				_event.StackName = _ctx.StringValue("ListStackEvents.Events["+ i +"].StackName");
				_event.Status = _ctx.StringValue("ListStackEvents.Events["+ i +"].Status");
				_event.StatusReason = _ctx.StringValue("ListStackEvents.Events["+ i +"].StatusReason");

				listStackEventsResponse_events.Add(_event);
			}
			listStackEventsResponse.Events = listStackEventsResponse_events;
        
			return listStackEventsResponse;
        }
    }
}
