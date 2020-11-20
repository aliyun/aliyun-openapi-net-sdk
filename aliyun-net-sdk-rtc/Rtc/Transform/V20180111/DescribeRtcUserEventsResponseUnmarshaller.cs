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
using Aliyun.Acs.rtc.Model.V20180111;

namespace Aliyun.Acs.rtc.Transform.V20180111
{
    public class DescribeRtcUserEventsResponseUnmarshaller
    {
        public static DescribeRtcUserEventsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRtcUserEventsResponse describeRtcUserEventsResponse = new DescribeRtcUserEventsResponse();

			describeRtcUserEventsResponse.HttpResponse = _ctx.HttpResponse;
			describeRtcUserEventsResponse.RequestId = _ctx.StringValue("DescribeRtcUserEvents.RequestId");

			List<DescribeRtcUserEventsResponse.DescribeRtcUserEvents__Event> describeRtcUserEventsResponse_events = new List<DescribeRtcUserEventsResponse.DescribeRtcUserEvents__Event>();
			for (int i = 0; i < _ctx.Length("DescribeRtcUserEvents.Events.Length"); i++) {
				DescribeRtcUserEventsResponse.DescribeRtcUserEvents__Event _event = new DescribeRtcUserEventsResponse.DescribeRtcUserEvents__Event();
				_event.EventId = _ctx.StringValue("DescribeRtcUserEvents.Events["+ i +"].EventId");
				_event.EventTime = _ctx.LongValue("DescribeRtcUserEvents.Events["+ i +"].EventTime");
				_event.Category = _ctx.StringValue("DescribeRtcUserEvents.Events["+ i +"].Category");

				describeRtcUserEventsResponse_events.Add(_event);
			}
			describeRtcUserEventsResponse.Events = describeRtcUserEventsResponse_events;
        
			return describeRtcUserEventsResponse;
        }
    }
}
