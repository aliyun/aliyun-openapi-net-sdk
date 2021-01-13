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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeBoardEventsResponseUnmarshaller
    {
        public static DescribeBoardEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBoardEventsResponse describeBoardEventsResponse = new DescribeBoardEventsResponse();

			describeBoardEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeBoardEventsResponse.RequestId = _ctx.StringValue("DescribeBoardEvents.RequestId");

			List<DescribeBoardEventsResponse.DescribeBoardEvents__Event> describeBoardEventsResponse_events = new List<DescribeBoardEventsResponse.DescribeBoardEvents__Event>();
			for (int i = 0; i < _ctx.Length("DescribeBoardEvents.Events.Length"); i++) {
				DescribeBoardEventsResponse.DescribeBoardEvents__Event _event = new DescribeBoardEventsResponse.DescribeBoardEvents__Event();
				_event.EventId = _ctx.LongValue("DescribeBoardEvents.Events["+ i +"].EventId");
				_event.EventType = _ctx.IntegerValue("DescribeBoardEvents.Events["+ i +"].EventType");
				_event.UserId = _ctx.IntegerValue("DescribeBoardEvents.Events["+ i +"].UserId");
				_event.Data = _ctx.StringValue("DescribeBoardEvents.Events["+ i +"].Data");
				_event.Timestamp = _ctx.LongValue("DescribeBoardEvents.Events["+ i +"].Timestamp");

				describeBoardEventsResponse_events.Add(_event);
			}
			describeBoardEventsResponse.Events = describeBoardEventsResponse_events;
        
			return describeBoardEventsResponse;
        }
    }
}
